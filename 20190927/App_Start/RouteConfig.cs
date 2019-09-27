using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace _20190927
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            /*
            routes.MapRoute(
                name: "FilmekMegjelenesSzerint",
                url: "filmek/megjelenes/{ev}/{honap}",
                defaults: new { controller = "Film", action = "Megjelenes" } , // anoním object
                new { ev = @"\d{4}", honap = @"\d{2}" } //Ha rossz helyre akarna menni az urn-ben
                );
*/
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

        }
    }
}
