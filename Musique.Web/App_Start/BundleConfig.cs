using System.Web;
using System.Web.Optimization;

namespace Musique.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/bootstrap/css").Include(
             "~/Content/bootstrap.min.css", new CssRewriteUrlTransform()));

            bundles.Add(new StyleBundle("~/bundles/style/css").Include(
          "~/Content/style.css", new CssRewriteUrlTransform()));

            bundles.Add(new ScriptBundle("~/bundles/jquery/js").Include(
          "~/Scripts/jquery-3.4.1.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap/js").Include(
          "~/Scripts/bootstrap.min.js"));

            // Material Icon
            bundles.Add(new StyleBundle("~/bundles/materialdesignicons/css").Include(
         "~/Content/materialdesignicons.min.css", new CssRewriteUrlTransform()));

            // pe-icon-7 Icon
            bundles.Add(new StyleBundle("~/bundles/pe-icon-7-stroke/css").Include(
       "~/Content/pe-icon-7-stroke.css", new CssRewriteUrlTransform()));

            bundles.Add(new ScriptBundle("~/bundles/bootstrapbundle/js").Include(
         "~/Scripts/bootstrap.bundle.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryeasing/js").Include(
          "~/Scripts/jquery.easing.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/app/js").Include(
         "~/Scripts/app.js"));

            bundles.Add(new StyleBundle("~/bundles/icons/css").Include(
             "~/Content/icons.min.css", new CssRewriteUrlTransform()));

            bundles.Add(new StyleBundle("~/bundles/app/css").Include(
             "~/Content/app.min.css", new CssRewriteUrlTransform()));

            bundles.Add(new ScriptBundle("~/bundles/vendor/js").Include(
          "~/Scripts/vendor.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/appmin/js").Include(
          "~/Scripts/app.min.js"));

            // Unobtrusive           
            bundles.Add(new ScriptBundle("~/bundles/unobtrusive/js").Include(
                      "~/Scripts/jquery.unobtrusive-ajax.min.js"));
            //sweet alert
            bundles.Add(new ScriptBundle("~/bundles/sweetalert2/js").Include(
                     "~/Scripts/sweetalert2.min.js"));
            bundles.Add(new StyleBundle("~/bundles/sweetalert2/css").Include(
             "~/Content/sweetalert2.min.css", new CssRewriteUrlTransform()));
            bundles.Add(new ScriptBundle("~/bundles/sweet_alerts/js").Include(
                     "~/Scripts/sweet-alerts.init.js"));
            // jQuery Validation
            bundles.Add(new ScriptBundle("~/bundles/validation/js").Include(
                "~/Scripts/jquery.validate.min.js"));
        }
    }
}
