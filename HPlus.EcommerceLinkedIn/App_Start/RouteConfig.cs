using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace HPlus.EcommerceLinkedIn
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // Rutas que se manejan por el request que se realice.
            routes.MapRoute(
                // Nombre de la ruta
                name: "Default",
                // Parametrizacion de la ruta
                url: "{controller}/{action}/{id}",
                // Definicion del objeto ruta
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
