using System.Web.Http;
using System.Web.Http.Dispatcher;

namespace Api.App_Start
{
    public static class TutorialWebApiConfig
    {
        public static void Register(HttpConfiguration config, string application)
        {

            ConfigApiJsonFormatter.Configure(config);

            //config.Services.Replace(typeof(IHttpControllerSelector), new ApiVersioningSelector(config));
        }
    }
}