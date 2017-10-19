using System.Web.Http;

namespace ApiParaTutorialAngular.App_Start
{
    public class TutorialWebApiConfig
    {
        public static void Register(HttpConfiguration config, string application)
        {

            ConfigApiJsonFormatter.Configure(config);

            //config.Services.Replace(typeof(IHttpControllerSelector), new ApiVersioningSelector(config));
        }
    }
}