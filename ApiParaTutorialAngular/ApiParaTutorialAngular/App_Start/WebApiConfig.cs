﻿using ApiParaTutorialAngular.App_Start;

using System.Web.Http;
using System.Web.Http.Cors;


namespace ApiParaTutorialAngular
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

            SwaggerConfig.Register();
        }
    }
}
