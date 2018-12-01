﻿using System.Web;
using System.Web.Optimization;

namespace Concessionaria
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery.min.js",
                        "~/Scripts/jquery-{version}.slim.min.js",
                        "~/Script/bootstrap.min.js",
                        "~/Scripts/popper.min.js"));

            bundles.Add(new ScriptBundle("~/Scripts/MyScript").Include(
                        "~/Scripts/MyScript/script.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap-darkly.css",
                      "~/Content/font-awesome.css",
                      "~/Content/Site.css",
                      "~/Content/MyStyle/style.css"));
        }
    }
}
