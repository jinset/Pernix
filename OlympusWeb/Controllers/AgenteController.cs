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
    public class AgenteController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Agente
        public ActionResult Index()
        {
            return View(db.Agente.ToList());
        }

        // GET: Agente/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Agente agente = db.Agente.Find(id);
            if (agente == null)
            {
                return HttpNotFound();
            }
            return View(agente);
        }

        // GET: Agente/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Agente/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Agente agente)
        {
            if (ModelState.IsValid)
            {
                db.Agente.Add(agente);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(agente);
        }

        // GET: Agente/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Agente agente = db.Agente.Find(id);
            if (agente == null)
            {
                return HttpNotFound();
            }
            return View(agente);
        }

        // POST: Agente/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AgenteId,CodigoAgente")] Agente agente)
        {
            if (ModelState.IsValid)
            {
                db.Entry(agente).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(agente);
        }

        // GET: Agente/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Agente agente = db.Agente.Find(id);
            if (agente == null)
            {
                return HttpNotFound();
            }
            return View(agente);
        }

        // POST: Agente/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Agente agente = db.Agente.Find(id);
            db.Agente.Remove(agente);
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
