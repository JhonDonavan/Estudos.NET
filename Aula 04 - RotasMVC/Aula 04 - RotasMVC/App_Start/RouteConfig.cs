using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Aula_04___RotasMVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute
                (
                name: "Todas as noticias",
                url: "Noticias/",
                defaults: new {controller = "Home", action = "todasnoticias"}
                );

            routes.MapRoute(
                name: "Categoria Especifica",
                url: "Noticias/{categoria}",
                defaults: new {controller = "Home", action = "MostraCategoria"}
                );

            routes.MapRoute(
                name: "Mostra Noticia",
                url: "noticias/{categoria}/{Titulo}-{noticiaId}",
                defaults: new { controller = "Home", action = "MostrarNoticia" }
                ); 

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}