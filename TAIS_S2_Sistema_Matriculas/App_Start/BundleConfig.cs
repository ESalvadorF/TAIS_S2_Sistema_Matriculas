using System.Web;
using System.Web.Optimization;

namespace TAIS_S2_Sistema_Matriculas
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

            bundles.Add(new ScriptBundle("~/Content/js").Include(
                      "~/assets/js/jquery.min.js",
                      "~/assets/js/popper.min.js",
                      "~/assets/js/bootstrap.min.js",
                      "~/assets/js/main.js",
                      "~/assets/js/Chart.bundle.min.js",
                      "~/assets/js/dashboard.js",
                      "~/assets/js/widgets.js",
                      "~/assets/js/jquery.vmap.min.js",
                      "~/assets/js/jquery.vmap.sampledata.js",
                      "~/assets/js/jquery.vmap.world.js"
                      ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/assets/css/bootstrap.min.css",
                      "~/assets/css/font-awesome.min.css",
                      "~/assets/css/themify-icons.css",
                      "~/assets/css/flag-icon.min.css",
                      "~/assets/css/cs-skin-elastic.css",
                      "~/assets/css/jqvmap.min.css",
                      "~/assets/css/style.css"
                      ));
        }
    }
}
