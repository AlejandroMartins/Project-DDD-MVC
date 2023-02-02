using System.Web;
using System.Web.Optimization;

namespace ProjetoModeloDDD
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/fontawesome").Include(
                    "~/Scripts/fontawesome/v4-shims.min.js",
                    "~/Scripts/fontawesome/all.js",
                    "~/Scripts/fontawesome/all.min.js",
                    "~/Scripts/fontawesome/brands.js",
                    "~/Scripts/fontawesome/brands.min.js",
                    "~/Scripts/fontawesome/conflict-detection.js",
                    "~/Scripts/fontawesome/conflict-detection.min.js",
                    "~/Scripts/fontawesome/fontawesome.js",
                    "~/Scripts/fontawesome/fontawesome.min.js",
                    "~/Scripts/fontawesome/regular.js",
                    "~/Scripts/fontawesome/regular.min.js",
                    "~/Scripts/fontawesome/solid.js",
                    "~/Scripts/fontawesome/solid.min.js",
                    "~/Scripts/fontawesome/v4-shims.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/fontawesome.css",
                      "~/Scripts/highcharts/7.1.2/css/highcharts.css"));

       
        }
    }
}
