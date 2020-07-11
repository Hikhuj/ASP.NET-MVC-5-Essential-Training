using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace HPlus.EcommerceLinkedIn
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            /* 
            * Hay muchos tipos de Application-Level Events que se pueden crear
            * en este archivo o parte del software
            * ejemplo: Application_Start(), Application_Error(), Application_Init(),
            * Application_EndRequest entre otros
            */


            // Otra forma de relacion de otros metodos. Busca otras areas y las registra para nosotros
            AreaRegistration.RegisterAllAreas();
            // Filtros que quiero hacer Global
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            // Configuracion de la tabla de rutas para cuando se ingresa
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            // Recursos estaticos como JS o CSS en una sola descarga para mejora de 
            // desempenio (performance)
            // Cuando estos se definen se obtiene un Path para ello.
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
