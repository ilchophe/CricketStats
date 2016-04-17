using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CricketStats.Models;

namespace CricketStats.Controllers
{
    public class BowlingInnsController : Controller
    {
        private Entities db = new Entities();

        // GET: BowlingInns
        public ActionResult Index()
        {
            var bowlingInns = db.BowlingInns.Include(b => b.BowlingInns1).Include(b => b.BowlingInn1).Include(b => b.Country).Include(b => b.Match).Include(b => b.Player);
            return View(bowlingInns.ToList());
        }

        // GET: BowlingInns/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BowlingInn bowlingInn = db.BowlingInns.Find(id);
            if (bowlingInn == null)
            {
                return HttpNotFound();
            }
            return View(bowlingInn);
        }

        // GET: BowlingInns/Create
        public ActionResult Create()
        {
            ViewBag.bowlingInnsid = new SelectList(db.BowlingInns, "bowlingInnsid", "bowlingInnsid");
            ViewBag.bowlingInnsid = new SelectList(db.BowlingInns, "bowlingInnsid", "bowlingInnsid");
            ViewBag.countryid = new SelectList(db.Countries, "countryid", "countrycode");
            ViewBag.matchid = new SelectList(db.Matches, "matchid", "matchid");
            ViewBag.playerid = new SelectList(db.Players, "playerid", "playername");
            return View();
        }

        // POST: BowlingInns/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "bowlingInnsid,matchid,bowlingInnsnumber,countryid,playerid,runs,wickets,maidens,overs,extras,lastupdated")] BowlingInn bowlingInn)
        {
            if (ModelState.IsValid)
            {
                bowlingInn.bowlingInnsid = Guid.NewGuid();
                db.BowlingInns.Add(bowlingInn);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.bowlingInnsid = new SelectList(db.BowlingInns, "bowlingInnsid", "bowlingInnsid", bowlingInn.bowlingInnsid);
            ViewBag.bowlingInnsid = new SelectList(db.BowlingInns, "bowlingInnsid", "bowlingInnsid", bowlingInn.bowlingInnsid);
            ViewBag.countryid = new SelectList(db.Countries, "countryid", "countrycode", bowlingInn.countryid);
            ViewBag.matchid = new SelectList(db.Matches, "matchid", "matchid", bowlingInn.matchid);
            ViewBag.playerid = new SelectList(db.Players, "playerid", "playername", bowlingInn.playerid);
            return View(bowlingInn);
        }

        // GET: BowlingInns/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BowlingInn bowlingInn = db.BowlingInns.Find(id);
            if (bowlingInn == null)
            {
                return HttpNotFound();
            }
            ViewBag.bowlingInnsid = new SelectList(db.BowlingInns, "bowlingInnsid", "bowlingInnsid", bowlingInn.bowlingInnsid);
            ViewBag.bowlingInnsid = new SelectList(db.BowlingInns, "bowlingInnsid", "bowlingInnsid", bowlingInn.bowlingInnsid);
            ViewBag.countryid = new SelectList(db.Countries, "countryid", "countrycode", bowlingInn.countryid);
            ViewBag.matchid = new SelectList(db.Matches, "matchid", "matchid", bowlingInn.matchid);
            ViewBag.playerid = new SelectList(db.Players, "playerid", "playername", bowlingInn.playerid);
            return View(bowlingInn);
        }

        // POST: BowlingInns/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "bowlingInnsid,matchid,bowlingInnsnumber,countryid,playerid,runs,wickets,maidens,overs,extras,lastupdated")] BowlingInn bowlingInn)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bowlingInn).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.bowlingInnsid = new SelectList(db.BowlingInns, "bowlingInnsid", "bowlingInnsid", bowlingInn.bowlingInnsid);
            ViewBag.bowlingInnsid = new SelectList(db.BowlingInns, "bowlingInnsid", "bowlingInnsid", bowlingInn.bowlingInnsid);
            ViewBag.countryid = new SelectList(db.Countries, "countryid", "countrycode", bowlingInn.countryid);
            ViewBag.matchid = new SelectList(db.Matches, "matchid", "matchid", bowlingInn.matchid);
            ViewBag.playerid = new SelectList(db.Players, "playerid", "playername", bowlingInn.playerid);
            return View(bowlingInn);
        }

        // GET: BowlingInns/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BowlingInn bowlingInn = db.BowlingInns.Find(id);
            if (bowlingInn == null)
            {
                return HttpNotFound();
            }
            return View(bowlingInn);
        }

        // POST: BowlingInns/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            BowlingInn bowlingInn = db.BowlingInns.Find(id);
            db.BowlingInns.Remove(bowlingInn);
            db.SaveChanges();
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
