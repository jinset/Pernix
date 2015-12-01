using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OlympusWeb.Models;

namespace OlympusWeb.Controllers
{
    public class AgenteInsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: AgenteIns
        public ActionResult Index()
        {
            return View(db.AgenteIns.ToList());
        }

        // GET: AgenteIns/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AgenteIns agenteIns = db.AgenteIns.Find(id);
            if (agenteIns == null)
            {
                return HttpNotFound();
            }
            return View(agenteIns);
        }

        // GET: AgenteIns/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AgenteIns/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AgenteIns agenteIns)
        {
            if (ModelState.IsValid)
            {

                db.AgenteIns.Add(agenteIns);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(agenteIns);
        }

        // GET: AgenteIns/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AgenteIns agenteIns = db.AgenteIns.Find(id);
            if (agenteIns == null)
            {
                return HttpNotFound();
            }
            return View(agenteIns);
        }

        // POST: AgenteIns/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AgenteInsId")] AgenteIns agenteIns)
        {
            if (ModelState.IsValid)
            {
                db.Entry(agenteIns).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(agenteIns);
        }

        // GET: AgenteIns/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AgenteIns agenteIns = db.AgenteIns.Find(id);
            if (agenteIns == null)
            {
                return HttpNotFound();
            }
            return View(agenteIns);
        }

        // POST: AgenteIns/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AgenteIns agenteIns = db.AgenteIns.Find(id);
            db.AgenteIns.Remove(agenteIns);
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
