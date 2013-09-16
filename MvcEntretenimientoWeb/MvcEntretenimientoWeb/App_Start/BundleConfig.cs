using System.Web;
using System.Web.Optimization;

namespace MvcEntretenimientoWeb
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-1.8.2.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-1.8.24.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));


            bundles.Add(new ScriptBundle("~/bundles/kendo").Include(
                        "~/Scripts/kendo.web.2013.1.319.js"));

            bundles.Add(new ScriptBundle("~/bundles/boot").Include(
                        "~/Scripts/boot-business.js"));
            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            //bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/boot-business.css"));
            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/bootstrap.css"));
            bundles.Add(new StyleBundle("~/Content/kendo").Include("~/Content/kendo.common.css"));
            bundles.Add(new StyleBundle("~/Content/kendo1").Include("~/Content/kendo.blueopal.css"));
            
            
         
            
        }
    }
}