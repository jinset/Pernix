using System.Web;
using System.Web.Optimization;

namespace OlympusWeb
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery.knob.js",
                        "~/Scripts/jquery.ui.widget.js",
                        "~/Scripts/jquery.iframe-transport.min.js",
                        "~/Scripts/jquery.fileupload.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // preparado para la producción y podrá utilizar la herramienta de compilación disponible en http://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/carousel").Include(
                  "~/Scripts/carousel.js"));

            bundles.Add(new ScriptBundle("~/bundles/main").Include(
                 "~/Scripts/script.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/animaciones.css",
                      "~/Content/owlcarousel.css",
                      "~/Content/owltheme.css",
                      "~/Content/layout.css",
                      "~/Content/index.css",
                      "~/Content/style.css",
                      "~/Content/site.css"));
        }
    }
}
