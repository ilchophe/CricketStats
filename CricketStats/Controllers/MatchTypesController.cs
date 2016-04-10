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
    public class MatchTypesController : Controller
    {
        private Entities db = new Entities();

        // GET: MatchTypes
        public async Task<ActionResult> Index()
        {
            return View(await db.MatchTypes.ToListAsync());
        }

        // GET: MatchTypes/Details/5
        public async Task<ActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MatchType matchType = await db.MatchTypes.FindAsync(id);
            if (matchType == null)
            {
                return HttpNotFound();
            }
            return View(matchType);
        }

        // GET: MatchTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MatchTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "matchtypeid,matchtypename,lastupdated")] MatchType matchType)
        {
            if (ModelState.IsValid)
            {
                matchType.matchtypeid = Guid.NewGuid();
                db.MatchTypes.Add(matchType);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(matchType);
        }

        // GET: MatchTypes/Edit/5
        public async Task<ActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MatchType matchType = await db.MatchTypes.FindAsync(id);
            if (matchType == null)
            {
                return HttpNotFound();
            }
            return View(matchType);
        }

        // POST: MatchTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "matchtypeid,matchtypename,lastupdated")] MatchType matchType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(matchType).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(matchType);
        }

        // GET: MatchTypes/Delete/5
        public async Task<ActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MatchType matchType = await db.MatchTypes.FindAsync(id);
            if (matchType == null)
            {
                return HttpNotFound();
            }
            return View(matchType);
        }

        // POST: MatchTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(Guid id)
        {
            MatchType matchType = await db.MatchTypes.FindAsync(id);
            db.MatchTypes.Remove(matchType);
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
