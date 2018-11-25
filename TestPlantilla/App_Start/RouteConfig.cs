using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TestPlantilla
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "HojaRuta",
                url: "HojaRuta",
                defaults: new
                { controller = "Home",action = "hojaRuta" }
            );
            routes.MapRoute(
                name: "HojaRutaDetalle",
                url: "HojaRutaDetalle",
                defaults: new { controller = "Home", action = "HojaRutaDetalle" }
            );
            routes.MapRoute(
               name: "Colaborador",
               url: "Colaborador",
               defaults: new { controller = "Home", action = "Colaborador" }
           );
            routes.MapRoute(
              name: "Vehiculos",
              url: "Vehiculos",
              defaults: new { controller = "Home", action = "Vehiculos" }
          );
            routes.MapRoute(
             name: "Guia",
             url: "Guia",
             defaults: new { controller = "Home", action = "Guia" }
         );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
