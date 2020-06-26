using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace LocadoraAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{metodo}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            // Utilizar JSON
            config.Formatters.Remove(config.Formatters.XmlFormatter);
            // Formatar
            config.Formatters.JsonFormatter.Indent = true;
        }
    }
}
