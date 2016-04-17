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
    public class DismissalsController : Controller
    {
        private Entities db = new Entities();

        // GET: Dismissals
        public ActionResult Index()
        {
            return View(db.Dismissals.ToList());
        }

        // GET: Dismissals/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dismissal dismissal = db.Dismissals.Find(id);
            if (dismissal == null)
            {
                return HttpNotFound();
            }
            return View(dismissal);
        }

        // GET: Dismissals/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Dismissals/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "dismissalid,dismissalcode,dismissaldesc,lastupdated")] Dismissal dismissal)
        {
            if (ModelState.IsValid)
            {
                dismissal.dismissalid = Guid.NewGuid();
                db.Dismissals.Add(dismissal);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dismissal);
        }

        // GET: Dismissals/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dismissal dismissal = db.Dismissals.Find(id);
            if (dismissal == null)
            {
                return HttpNotFound();
            }
            return View(dismissal);
        }

        // POST: Dismissals/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "dismissalid,dismissalcode,dismissaldesc,lastupdated")] Dismissal dismissal)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dismissal).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dismissal);
        }

        // GET: Dismissals/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dismissal dismissal = db.Dismissals.Find(id);
            if (dismissal == null)
            {
                return HttpNotFound();
            }
            return View(dismissal);
        }

        // POST: Dismissals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            Dismissal dismissal = db.Dismissals.Find(id);
            db.Dismissals.Remove(dismissal);
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
