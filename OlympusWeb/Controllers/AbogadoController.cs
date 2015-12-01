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
    public class AbogadoController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Abogado
        public ActionResult Index()
        {
            return View(db.Abogado.ToList());
        }

        // GET: Abogado/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Abogado abogado = db.Abogado.Find(id);
            if (abogado == null)
            {
                return HttpNotFound();
            }
            return View(abogado);
        }

        // GET: Abogado/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Abogado/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Abogado abogado)
        {
            if (ModelState.IsValid)
            {
                db.Abogado.Add(abogado);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(abogado);
        }

        // GET: Abogado/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Abogado abogado = db.Abogado.Find(id);
            if (abogado == null)
            {
                return HttpNotFound();
            }
            return View(abogado);
        }

        // POST: Abogado/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AbogadoId")] Abogado abogado)
        {
            if (ModelState.IsValid)
            {
                db.Entry(abogado).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(abogado);
        }

        // GET: Abogado/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Abogado abogado = db.Abogado.Find(id);
            if (abogado == null)
            {
                return HttpNotFound();
            }
            return View(abogado);
        }

        // POST: Abogado/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Abogado abogado = db.Abogado.Find(id);
            db.Abogado.Remove(abogado);
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
