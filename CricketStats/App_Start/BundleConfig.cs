using System.Web;
using System.Web.Optimization;

namespace CricketStats
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/themes/superhero.bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                      "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new StyleBundle("~/Content/jqueryui").Include(
                      "~/Content/themes/base/all.css"));

            bundles.Add(new StyleBundle("~/Content/dataTables").Include(
                     "~/Content/DataTables/css/dataTables.bootstrap.css",
                     "~/Content/DataTables/css/autoFill.bootstrap.css",
                     "~/Content/DataTables/css/buttons.bootstrap.css",
                     "~/Content/DataTables/css/colReorder.bootstrap.css",
                     "~/Content/DataTables/css/fixedColumns.bootstrap.css",
                     "~/Content/DataTables/css/select.bootstrap.css",
                     "~/Content/DataTables/css/scroller.bootstrap.css",
                     "~/Content/DataTables/css/rowReorder.bootstrap.css",
                     "~/Content/DataTables/css/responsive.bootstrap.css",
                     "~/Content/DataTables/css/keyTable.bootstrap.css",
                     "~/Content/DataTables/css/fixedHeader.bootstrap.css"

                ));

            bundles.Add(new ScriptBundle("~/bundles/dataTables").Include(
                      "~/Scripts/DataTables/jquery.dataTables.js", 
                      "~/Scripts/DataTables/dataTables.bootstrap.js"
                      //,
                      //"~/Scripts/DataTables/buttons.bootstrap.js"
                      
                ));


        }
    }
}
