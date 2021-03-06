﻿using System.Web;
using System.Web.Optimization;

namespace ShopWeb
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

            bundles.Add(new ScriptBundle("~/Content/js").Include(
                      "~/Content/js/bootstrap.min.js",
                      "~/Content/js/jquery.slicknav.js",
                      "~/Content/js/jquery-3.3.1.min.js",
                      "~/Content/js/main.js",
                      "~/Content/js/slick-custom.js",
                       "~/Content/js/slick-custom.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/css/bootstrap.min.css",
                      "~/Content/css/font-awesome.min.css",
                      "~/Content/css/main.css",
                      "~/Content/css/main.min.css",
                      "~/Content/css/util.min.css",
                      "~/Content/css/util.css"
                      ));
        }
    }
}
