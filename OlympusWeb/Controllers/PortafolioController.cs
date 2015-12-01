using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OlympusWeb.Models;
using System.Net;
using Microsoft.AspNet.Identity;


namespace OlympusWeb.Controllers
{
    public class PortafolioController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Portafolio
        public ActionResult Index()
        {

            return View(db.Hipoteca.ToList());// ponerle un where
        }

        // GET: Portafolio/Details/5
        public ActionResult Details(int id)
        {
 
            Hipoteca hipoteca = db.Hipoteca.Find(id);
            if (hipoteca == null)
            {
                return HttpNotFound();
            }
            return View(hipoteca);
        }
        public ActionResult Invertir(int id)
        {
            string currentUserId = User.Identity.GetUserId();

            Contrato nuevoContrato = new Contrato();
            Hipoteca hipoteca = db.Hipoteca.Find(id);
            nuevoContrato.Hipoteca = hipoteca;
            nuevoContrato.ApplicationUserId = currentUserId;
            ApplicationUser currentUser = db.Users.FirstOrDefault(x => x.Id == currentUserId);
            return RedirectToAction("Index");
        }

        // GET: Portafolio/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Portafolio/Create
        [HttpPost]
        public ActionResult Create(ViewHipoteca hipoteca)
        {
            if (ModelState.IsValid)
            {
                Hipoteca nuevaHipoteca = new Hipoteca();
                nuevaHipoteca.Persona = new Persona();

                nuevaHipoteca.Persona.Nombre = hipoteca.Nombre;
                nuevaHipoteca.Persona.Apellido = hipoteca.Apellido;
                nuevaHipoteca.Persona.Identificacion = hipoteca.Identificacion;
                nuevaHipoteca.Persona.Email = hipoteca.Email;
                nuevaHipoteca.Persona.Telefono = hipoteca.Telefono;
                nuevaHipoteca.NumeroPlano = hipoteca.NumeroPlano;
                nuevaHipoteca.Provincia = hipoteca.Provincia;
                nuevaHipoteca.Distrito = hipoteca.Distrito;
                nuevaHipoteca.Canton = hipoteca.Canton;
                nuevaHipoteca.GravamenesAnotaciones = hipoteca.GravamenesAnotaciones;
                nuevaHipoteca.TipoPropiedad = hipoteca.TipoPropiedad;
                nuevaHipoteca.Estado = (Estado)Enum.Parse(typeof(Estado), "Pendiente"); 

                FotosPropiedad FotosModel = new FotosPropiedad();
                FotosModel.hipoteca = nuevaHipoteca;

                //agregar el plano
                
                byte[] uploadFile = new byte[hipoteca.Plano.InputStream.Length];
                hipoteca.Plano.InputStream.Read(uploadFile, 0, uploadFile.Length);

                FotosModel.FileName = hipoteca.Plano.FileName;
                FotosModel.File = uploadFile;

                db.FotosPropiedad.Add(FotosModel);
                db.SaveChanges();
                
                //agregar varias fotos
                foreach (var item in hipoteca.Fotos)
                {
                    uploadFile = new byte[item.InputStream.Length];
                    item.InputStream.Read(uploadFile, 0, uploadFile.Length);

                    FotosModel.FileName = item.FileName;
                    FotosModel.File = uploadFile;

                    db.FotosPropiedad.Add(FotosModel);
                    db.SaveChanges();
                }
                //nuevaHipoteca.FotosPropiedad = null;
                //db.Hipoteca.Add(nuevaHipoteca);
                db.SaveChanges();
                RedirectToAction("Index", "Home");
            }

            return View(hipoteca);
        }

        // GET: Portafolio/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Portafolio/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Portafolio/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Portafolio/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //cargar la imagen de la db
        public ActionResult obtenerPlano(int id)
        {
            Hipoteca hipoteca = db.Hipoteca.FirstOrDefault(p => p.HipotecaId == id);
            FotosPropiedad plano = hipoteca.FotosPropiedad.FirstOrDefault(p => p.Tipo == 0);
            return File(plano.File, plano.FileName);
        
        }

        public ActionResult obtenerFoto(int id)
        {
            Hipoteca hipoteca = db.Hipoteca.FirstOrDefault(p => p.HipotecaId == id);
            FotosPropiedad plano = hipoteca.FotosPropiedad.FirstOrDefault(p => p.Tipo == 1);
            return File(plano.File, plano.FileName);
        }
    }
}
