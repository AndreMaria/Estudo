using Api.App_Start;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Web.Http;
using System.Web.Http.Cors;
using Startup;

namespace Api
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
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            var en = new EnableCorsAttribute("*", "*", "*");

            config.EnableCors(en);

            var container = new UnityContainer();
            UnityDependencyResolver.RegisterDependencies(container);
            config.DependencyResolver = new UnityResolver(container);

            SwaggerConfig.Register();
        }
    }
}
