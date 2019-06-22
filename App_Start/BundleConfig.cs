using System.Web;
using System.Web.Optimization;

namespace A.H.M.O._2018
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                       "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap-datetimepicker.min.css",
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/fullScreen").Include(
                    "~/Content/SiteFullScreen.css"));

            bundles.Add(new StyleBundle("~/Content/menu").Include(
                    "~/Content/SiteMenu.css"));

            bundles.Add(new StyleBundle("~/Content/bootstrap").Include(
                  "~/Content/bootstrap.css",
                   "~/Content/bootstrap-datepicker.min.css"));

            bundles.Add(new StyleBundle("~/Content/createRegistroUsuario").Include(
                   "~/Content/SiteCreateRegistroUsuario.css"));

            bundles.Add(new StyleBundle("~/Content/fullcalendar").Include(
                    "~/Content/fullcalendar.min.css"));

            bundles.Add(new ScriptBundle("~/bundles/fullcalendar").Include(
                        "~/Scripts/moment.min.js",
                         "~/Scripts/fullcalendar.min.js",
                         "~/Scripts/bootstrap-datetimepicker.min.js",
                          "~/Scripts/locale-all.js"));


        }
    } 
    
}
