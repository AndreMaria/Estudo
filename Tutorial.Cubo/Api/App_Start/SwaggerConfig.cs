using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Swashbuckle.Application;

namespace Api.App_Start
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
                c.IncludeXmlComments($@"{AppDomain.CurrentDomain.BaseDirectory}\bin\Api.XML");
                c.IncludeXmlComments($@"{AppDomain.CurrentDomain.BaseDirectory}\bin\Domain.XML");
                c.UseFullTypeNameInSchemaIds();
                c.DescribeAllEnumsAsStrings();
            }).EnableSwaggerUi(c=> {
                c.DisableValidator();

            });
        }
    }
}