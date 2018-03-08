using System;
using System.Web.Http;
using TagAlize.Models;
using TagAlize.Util;

namespace TagAlize.Controllers
{
    public class UtilController : ApiController
    {
        [HttpGet]
        public Response<TagAlise> GetTagAlize(String text)
        {
            Response<TagAlise> response = new Response<TagAlise>();
            try
            {
                response.Items = Util.Util.CreateTagAlise(text);
            }
            catch (Exception ex)
            {
                response.Message = String.Format("[Error]:{0};[Method]:{1};[Data]:{2}", ex.Message, "GetTagAlize", DateTime.Now);
            }
            return response;
        }
    }
}
