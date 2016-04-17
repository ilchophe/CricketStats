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
    public class BattingInnsController : Controller
    {
        private Entities db = new Entities();

        // GET: BattingInns
        public ActionResult Index()
        {
            var battingInns = db.BattingInns.Include(b => b.Dismissal).Include(b => b.Country).Include(b => b.Match).Include(b => b.Player).Include(b => b.PlayerBowler).Include(b => b.PlayerFielder);
            return View(battingInns.ToList());
        }

        // GET: BattingInns/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BattingInn battingInn = db.BattingInns.Find(id);
            if (battingInn == null)
            {
                return HttpNotFound();
            }
            return View(battingInn);
        }

        // GET: BattingInns/Create
        public ActionResult Create()
        {
            ViewBag.dismissalid = new SelectList(db.Dismissals, "dismissalid", "dismissalcode");
            ViewBag.countryid = new SelectList(db.Countries, "countryid", "countrycode");
            ViewBag.matchid = new SelectList(db.Matches, "matchid", "matchid");
            ViewBag.playerid = new SelectList(db.Players, "playerid", "playername");
            ViewBag.bowler_playerid = new SelectList(db.Players, "playerid", "playername");
            ViewBag.fielder_playerid = new SelectList(db.Players, "playerid", "playername");
            return View();
        }

        // POST: BattingInns/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BatInnsid,matchid,BatInnsNumber,countryid,playerid,runs,ballsfaced,fours,sixes,bowler_playerid,fielder_playerid,dismissalid,lastupdated")] BattingInn battingInn)
        {
            if (ModelState.IsValid)
            {
                battingInn.BatInnsid = Guid.NewGuid();
                db.BattingInns.Add(battingInn);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.dismissalid = new SelectList(db.Dismissals, "dismissalid", "dismissalcode", battingInn.dismissalid);
            ViewBag.countryid = new SelectList(db.Countries, "countryid", "countrycode", battingInn.countryid);
            ViewBag.matchid = new SelectList(db.Matches, "matchid", "matchid", battingInn.matchid);
            ViewBag.playerid = new SelectList(db.Players, "playerid", "playername", battingInn.playerid);
            ViewBag.bowler_playerid = new SelectList(db.Players, "playerid", "playername", battingInn.bowler_playerid);
            ViewBag.fielder_playerid = new SelectList(db.Players, "playerid", "playername", battingInn.fielder_playerid);
            return View(battingInn);
        }

        // GET: BattingInns/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BattingInn battingInn = db.BattingInns.Find(id);
            if (battingInn == null)
            {
                return HttpNotFound();
            }
            ViewBag.dismissalid = new SelectList(db.Dismissals, "dismissalid", "dismissalcode", battingInn.dismissalid);
            ViewBag.countryid = new SelectList(db.Countries, "countryid", "countrycode", battingInn.countryid);
            ViewBag.matchid = new SelectList(db.Matches, "matchid", "matchid", battingInn.matchid);
            ViewBag.playerid = new SelectList(db.Players, "playerid", "playername", battingInn.playerid);
            ViewBag.bowler_playerid = new SelectList(db.Players, "playerid", "playername", battingInn.bowler_playerid);
            ViewBag.fielder_playerid = new SelectList(db.Players, "playerid", "playername", battingInn.fielder_playerid);
            return View(battingInn);
        }

        // POST: BattingInns/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BatInnsid,matchid,BatInnsNumber,countryid,playerid,runs,ballsfaced,fours,sixes,bowler_playerid,fielder_playerid,dismissalid,lastupdated")] BattingInn battingInn)
        {
            if (ModelState.IsValid)
            {
                db.Entry(battingInn).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.dismissalid = new SelectList(db.Dismissals, "dismissalid", "dismissalcode", battingInn.dismissalid);
            ViewBag.countryid = new SelectList(db.Countries, "countryid", "countrycode", battingInn.countryid);
            ViewBag.matchid = new SelectList(db.Matches, "matchid", "matchid", battingInn.matchid);
            ViewBag.playerid = new SelectList(db.Players, "playerid", "playername", battingInn.playerid);
            ViewBag.bowler_playerid = new SelectList(db.Players, "playerid", "playername", battingInn.bowler_playerid);
            ViewBag.fielder_playerid = new SelectList(db.Players, "playerid", "playername", battingInn.fielder_playerid);
            return View(battingInn);
        }

        // GET: BattingInns/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BattingInn battingInn = db.BattingInns.Find(id);
            if (battingInn == null)
            {
                return HttpNotFound();
            }
            return View(battingInn);
        }

        // POST: BattingInns/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            BattingInn battingInn = db.BattingInns.Find(id);
            db.BattingInns.Remove(battingInn);
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
