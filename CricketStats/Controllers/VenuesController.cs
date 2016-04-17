using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CricketStats.Models;

namespace CricketStats.Controllers
{
    public class VenuesController : Controller
    {
        private Entities db = new Entities();

        // GET: Venues
        public async Task<ActionResult> Index()
        {
            var venues = db.Venues.Include(v => v.Country);
            return View(await venues.OrderBy(v => v.venuecity).ThenBy(v => v.Country.countrydesc).ToListAsync());
        }

        // GET: Venues/Details/5
        public async Task<ActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Venue venue = await db.Venues.FindAsync(id);
            if (venue == null)
            {
                return HttpNotFound();
            }
            return View(venue);
        }

        // GET: Venues/Create
        public ActionResult Create()
        {
            ViewBag.countryid = new SelectList(db.Countries, "countryid", "countrydesc");
            return View();
        }

        // POST: Venues/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "venueid,venuename,venuecity,countryid")] Venue venue)
        {
            if (ModelState.IsValid)
            {
                venue.venueid = Guid.NewGuid();
                venue.lastupdated = DateTime.Now;
                db.Venues.Add(venue);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.countryid = new SelectList(db.Countries, "countryid", "countrydesc", venue.countryid);
            return View(venue);
        }

        // GET: Venues/Edit/5
        public async Task<ActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Venue venue = await db.Venues.FindAsync(id);
            if (venue == null)
            {
                return HttpNotFound();
            }
            ViewBag.countryid = new SelectList(db.Countries, "countryid", "countrydesc", venue.countryid);
            return View(venue);
        }

        // POST: Venues/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "venueid,venuename,venuecity,countryid")] Venue venue)
        {
            if (ModelState.IsValid)
            {
                venue.lastupdated = DateTime.Now;
                db.Entry(venue).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.countryid = new SelectList(db.Countries, "countryid", "countrydesc", venue.countryid);
            return View(venue);
        }

        // GET: Venues/Delete/5
        public async Task<ActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Venue venue = await db.Venues.FindAsync(id);
            if (venue == null)
            {
                return HttpNotFound();
            }
            return View(venue);
        }

        // POST: Venues/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(Guid id)
        {
            Venue venue = await db.Venues.FindAsync(id);
            db.Venues.Remove(venue);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
