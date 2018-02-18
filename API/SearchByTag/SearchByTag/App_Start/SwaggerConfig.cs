using System.Web.Http;
using WebActivatorEx;
using SearchByTag;
using Swashbuckle.Application;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace SearchByTag
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
                .EnableSwagger(c =>
                    {

                        c.SingleApiVersion("v1", "SearchByTag");
                        c.IncludeXmlComments(string.Format(@"{0}\bin\SearchByTag.XML",
                           System.AppDomain.CurrentDomain.BaseDirectory));
                    })
                .EnableSwaggerUi(c => {  });
        }
    }
}
