using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OlympusWeb.Models;
using System.Net.Mail;


namespace OlympusWeb.Controllers
{
    public class ColaboradoresController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Colaboradores
        public ActionResult Index()
        {

            ViewBag.Abogado = db.Abogado.ToList();
            ViewBag.Perito = db.Perito.ToList();
            ViewBag.Agente = db.Agente.ToList();
            ViewBag.AgenteIns = db.AgenteIns.ToList();
            ViewBag.Hipoteca = db.Hipoteca.ToList();
            ViewBag.Inversionista = db.Users.ToList();
            return View();
        }
        public ActionResult Alta(int id, string tipo)
        {
            if (tipo.Equals("Agente"))
            {
                Agente agente = db.Agente.Find(id);
                agente.Estado = (Estado)Enum.Parse(typeof(Estado), "Aceptado");
                db.SaveChanges();
                enviarCorreo(id);
            }

            if (tipo.Equals("Abogado"))
            {
                Abogado abogado = db.Abogado.Find(id);
                abogado.Estado = (Estado)Enum.Parse(typeof(Estado), "Aceptado");
                db.SaveChanges();
               // enviarCorreo(id);
            }

            if (tipo.Equals("Perito"))
            {
                Perito perito = db.Perito.Find(id);
                perito.Estado = (Estado)Enum.Parse(typeof(Estado), "Aceptado");
                db.SaveChanges();
              // enviarCorreo(id);
            }

            if (tipo.Equals("AgenteIns"))
            {
                AgenteIns agenteIns = db.AgenteIns.Find(id);
                agenteIns.Estado = (Estado)Enum.Parse(typeof(Estado), "Aceptado");
                db.SaveChanges();
               // enviarCorreo(id);
            }

            if (tipo.Equals("Hipoteca"))
            {
                Hipoteca hipoteca = db.Hipoteca.Find(id);
                hipoteca.Estado = (Estado)Enum.Parse(typeof(Estado), "Aceptado");
                db.SaveChanges();
             //enviarCorreo(id);
            }
            return RedirectToAction("Index");
        }

        public ActionResult Baja(int id, string tipo)
        {
            if (tipo.Equals("Agente"))
            {
                Agente agente = db.Agente.Find(id);
                agente.Estado = (Estado)Enum.Parse(typeof(Estado), "Cancelado");
                db.SaveChanges();     
            }

            if (tipo.Equals("Abogado"))
            {
                Abogado abogado = db.Abogado.Find(id);
                abogado.Estado = (Estado)Enum.Parse(typeof(Estado), "Cancelado");
                db.SaveChanges();
            }

            if (tipo.Equals("Perito"))
            {
                Perito perito = db.Perito.Find(id);
                perito.Estado = (Estado)Enum.Parse(typeof(Estado), "Cancelado");
                db.SaveChanges();
            }

            if (tipo.Equals("AgenteIns"))
            {
                AgenteIns agenteIns = db.AgenteIns.Find(id);
                agenteIns.Estado = (Estado)Enum.Parse(typeof(Estado), "Cancelado");
                db.SaveChanges();
            }

            if (tipo.Equals("Hipoteca"))
            {
                Hipoteca hipoteca = db.Hipoteca.Find(id);
                hipoteca.Estado = (Estado)Enum.Parse(typeof(Estado), "Cancelado");
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }
        public void enviarCorreo(int id)
        {
            Persona persona = db.Persona.Find(id);
            MailMessage correo = new MailMessage();
            correo.From = new MailAddress("mariocr1611@gmail.com");

            correo.To.Add(persona.Email);
            correo.Subject = "se envio";
            correo.Body = "hola";
            correo.IsBodyHtml = false;
            correo.Priority = MailPriority.Normal;

            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new NetworkCredential("mariocr1611@gmail.com", "mario1611");

            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;

            try
            {
                smtp.Send(correo); 
            }
            catch
            {

            }
            correo.Dispose();
        }
    }
}