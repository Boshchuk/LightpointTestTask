using System.Web.Optimization;

namespace LightpointTestTask
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            const string kendoVersion = "2014.1.318";

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/DataTables").Include("~/Scripts/DataTables/jquery.dataTables.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/kendoScripts").Include(string.Format("~/Scripts/kendo/{0}/kendo.web.min.js", kendoVersion)));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/KendoStyle").Include(
                string.Format("~/Content/kendo/{0}/kendo.default.min.css", kendoVersion),
                
                string.Format("~/Content/kendo/{0}/kendo.common.min.css", kendoVersion)));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            BundleTable.EnableOptimizations = true;
        }
    }
}