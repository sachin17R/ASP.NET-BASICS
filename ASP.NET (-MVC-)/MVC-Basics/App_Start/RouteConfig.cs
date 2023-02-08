using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCframework
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               name: "MathOperation",
               url: "{controller}/{action}/{v1}/{v2}",
               defaults: new { controller = "Home", action = "GetNumber" }
           );

            routes.MapRoute(
                name: "String",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "GetString" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Cacli", action = "Index", id = UrlParameter.Optional }
            );


        }
    }
}
