using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading;

namespace OlympusWeb.Controllers
{
    public class LanguageController : Controller
    {
        // GET: Language
        public ActionResult SetLanguage(string name)
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(name);
            Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;

            HttpCookie cultureCookie = new HttpCookie("_culture");
            cultureCookie.Value = name;
            cultureCookie.Expires = DateTime.UtcNow.AddYears(1);

            Response.Cookies.Remove("_culture");
            Response.SetCookie(cultureCookie);


            return RedirectToAction("Index","Home");
        }
    }
}