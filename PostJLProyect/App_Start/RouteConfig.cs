using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PostJLProyect
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Users", action = "Index", id = UrlParameter.Optional }
            );


            routes.MapRoute(
                name: "GetGanador",
                url: "Users/GetGanador",
                defaults: new { controller = "Users", action = "GetGanador" }
            );

            routes.MapRoute(
               name: "Div",
               url: "Users/Div",
               defaults: new { controller = "Users", action = "Div" }
           );
        }
    }
}
