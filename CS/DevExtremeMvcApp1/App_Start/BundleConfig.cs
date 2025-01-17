using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Optimization;

namespace DevExtremeMvcApp1
{

    public class BundleConfig {

        public static void RegisterBundles(BundleCollection bundles) {

            var scriptBundle = new ScriptBundle("~/Scripts/bundle");
            var styleBundle = new StyleBundle("~/Content/bundle");

            // jQuery
            scriptBundle
                .Include("~/Scripts/jquery-2.2.3.js");

            // Bootstrap
            scriptBundle
                .Include("~/Scripts/bootstrap.js");

            //Script for a custom popup window
            scriptBundle
                .Include("~/Scripts/customPopup/customPopup.js");

            // Bootstrap
            styleBundle
                .Include("~/Content/bootstrap.css");

            // Custom site styles
            styleBundle
                .Include("~/Content/Site.css");

            bundles.Add(scriptBundle);
            bundles.Add(styleBundle);

#if !DEBUG
            BundleTable.EnableOptimizations = true;
#endif
        }
    }
}