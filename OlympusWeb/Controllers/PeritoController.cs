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
    public class PeritoController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Perito
        public ActionResult Index()
        {
            return View(db.Perito.ToList());
        }

        // GET: Perito/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Perito perito = db.Perito.Find(id);
            if (perito == null)
            {
                return HttpNotFound();
            }
            return View(perito);
        }

        // GET: Perito/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Perito/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Perito perito)
        {
            if (ModelState.IsValid)
            {
                db.Perito.Add(perito);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(perito);
        }

        // GET: Perito/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Perito perito = db.Perito.Find(id);
            if (perito == null)
            {
                return HttpNotFound();
            }
            return View(perito);
        }

        // POST: Perito/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PeritoId")] Perito perito)
        {
            if (ModelState.IsValid)
            {
                db.Entry(perito).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(perito);
        }

        // GET: Perito/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Perito perito = db.Perito.Find(id);
            if (perito == null)
            {
                return HttpNotFound();
            }
            return View(perito);
        }

        // POST: Perito/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Perito perito = db.Perito.Find(id);
            db.Perito.Remove(perito);
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
