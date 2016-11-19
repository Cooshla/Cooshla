using System.Web;
using System.Web.Optimization;

namespace AgencySite
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/js/jquery-scrolltofixed.js",
                        "~/js/jquery.easing.1.3.js",
                        "~/js/jquery.isotope.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/js/bootstrap.js",
                      "~/js/wow.js",
                      "~/js/classie.js",
                      "~/js/fanoe.js",
                      "~/js/custom.js"));
            

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/css/bootstrap.min.css",
                      "~/css/fanoe.css",
                      "~/css/style.css",
                      "~/css/font-awesome.css",
                      "~/css/responsive.css",
                      "~/css/animate.css"));
            

        }
    }
}
