using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ARMvc
{
    public class RouteConfig
    {
        public static string culture
        {
            get
            {
                if (System.Threading.Thread.CurrentThread.CurrentCulture.Name.Contains("ar"))
                {
                    return "ar";
                }
                return "en";
            }
        }
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{culture}/{controller}/{action}/{id}",
                defaults: new { culture = culture, controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
