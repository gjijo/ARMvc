using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ARTheamF
{
    public class RouteConfig
    {
        public static string culture
        {
            get
            {
                if (System.Threading.Thread.CurrentThread.CurrentCulture.Name.Contains("en"))
                {
                    return "en";
                }
                return "ar";
            }
        }
        public static void RegisterRoutes(RouteCollection routes)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("ar-SA");
            Thread.CurrentThread.CurrentCulture = new CultureInfo("ar-SA");

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{culture}/{controller}/{action}/{id}",
                defaults: new { culture = culture, controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
