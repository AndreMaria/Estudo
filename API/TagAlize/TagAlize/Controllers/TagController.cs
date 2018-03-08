using System;
using System.Linq;
using System.Web.Http;
using TagAlize.Core.Model;
using TagAlize.Core.Service;
using TagAlize.Models;

namespace TagAlize.Controllers
{
    public class TagController : ApiController
    {
        private TagService TagService;

        public TagController()
        {
            TagService = new TagService();
        }

        [HttpPost]
        public Response<Tag> CreateTag(Tag entity)
        {
            Response<Tag> response = new Response<Tag>();
            try
            {
                if (null != entity)
                {
                    TagService.Save(entity);
                    response.Message = "Processo realizado com sucesso!";
                }
                else
                {
                    response.Message = "Tag está nulo";
                }
            }
            catch (Exception ex)
            {
                response.Message = String.Format("[Error]:{0};[Method]:{1};[Data]:{2}", ex.Message, "CreateTag", DateTime.Now);
            }
            return response;
        }

        [HttpGet]
        public Response<Tag> GetTag(long id)
        {
            Response<Tag> response = new Response<Tag>();
            try
            {
                if (id > 0)
                {
                    response.Item = TagService.FirstOrDefault(id);
                    response.Message = "Processo realizado com sucesso!";
                }
                else
                {
                    response.Message = "O Id está nulo";
                }
            }
            catch (Exception ex)
            {
                response.Message = String.Format("[Error]:{0};[Method]:{1};[Data]:{2}", ex.Message, "GetTag", DateTime.Now);
            }
            return response;
        }

        [HttpPut]
        public Response<Tag> UpdateTag(Tag entity)
        {
            Response<Tag> response = new Response<Tag>();
            try
            {
                if (null != entity)
                {
                    TagService.Save(entity);
                    response.Message = "Processo realizado com sucesso!";
                }
                else
                {
                    response.Message = "Tag está nulo";
                }
            }
            catch (Exception ex)
            {
                response.Message = String.Format("[Error]:{0};[Method]:{1};[Data]:{2}", ex.Message, "GetTag", DateTime.Now);
            }
            return response;
        }

        [HttpDelete]
        public Response<Tag> RemoveTag(long id)
        {
            Response<Tag> response = new Response<Tag>();
            try
            {
                if (id > 0)
                {
                    TagService.Remove(id);
                    response.Message = "Processo realizado com sucesso!";
                }
                else
                {
                    response.Message = "O Id está nulo";
                }
            }
            catch (Exception ex)
            {
                response.Message = String.Format("[Error]:{0};[Method]:{1};[Data]:{2}", ex.Message, "GetTag", DateTime.Now);
            }
            return response;
        }
    }
}
