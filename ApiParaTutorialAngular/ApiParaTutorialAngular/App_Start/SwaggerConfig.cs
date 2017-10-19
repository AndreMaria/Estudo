using System.Web.Http;
using WebActivatorEx;
using ApiParaTutorialAngular;
using Swashbuckle.Application;
using System;

namespace ApiParaTutorialAngular
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            //bool outEnableSwagger;
            //if (!bool.TryParse("", out outEnableSwagger) || !outEnableSwagger) { return; }

            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration.EnableSwagger(c => {
                c.SingleApiVersion("Tutorial", "Turotial Projeto Cubo");
                c.IncludeXmlComments($@"{AppDomain.CurrentDomain.BaseDirectory}\bin\ApiParaTutorialAngular.XML");
                c.UseFullTypeNameInSchemaIds();
                c.DescribeAllEnumsAsStrings();
            }).EnableSwaggerUi(c => {
                c.DisableValidator();

            });
        }
    }
}
