using System;
using System.Web.Http;
using ProvaApi.Core.Model;
using ProvaApi.Core.Service;
using ProvaApi.Models;

namespace ProvaApi.Controllers
{
    public class LabelController : ApiController
    {
        private LabelService labelService;

        public LabelController()
        {
            labelService = new LabelService();
        }

        [HttpPost]
        public Response<Label> CreateLabel(Label entity)
        {
            Response<Label> response = new Response<Label>();
            try
            {
                if (null != entity)
                {
                    labelService.Save(entity);
                    response.Message = "Processo realizado com sucesso!";
                }
                else
                {
                    response.Message = "Label está nulo";
                }
            }
            catch (Exception ex)
            {
                response.Message = String.Format("[Error]:{0};[Method]:{1};[Data]:{2}", ex.Message, "CreateLabel", DateTime.Now);
            }
            return response;
        }

        [HttpGet]
        public Response<Label> GetLabel(long id)
        {
            Response<Label> response = new Response<Label>();
            try
            {
                if (id > 0)
                {
                    response.Item = labelService.FirstOrDefault(id);
                    response.Message = "Processo realizado com sucesso!";
                }
                else
                {
                    response.Message = "O Id está nulo";
                }
            }
            catch (Exception ex)
            {
                response.Message = String.Format("[Error]:{0};[Method]:{1};[Data]:{2}", ex.Message, "GetLabel", DateTime.Now);
            }
            return response;
        }

        [HttpPut]
        public Response<Label> UpdateLabel(Label entity)
        {
            Response<Label> response = new Response<Label>();
            try
            {
                if (null != entity)
                {
                    labelService.Save(entity);
                    response.Message = "Processo realizado com sucesso!";
                }
                else
                {
                    response.Message = "Label está nulo";
                }
            }
            catch (Exception ex)
            {
                response.Message = String.Format("[Error]:{0};[Method]:{1};[Data]:{2}", ex.Message, "GetLabel", DateTime.Now);
            }
            return response;
        }

        [HttpDelete]
        public Response<Label> RemoveLabel(long id)
        {
            Response<Label> response = new Response<Label>();
            try
            {
                if (id > 0)
                {
                    labelService.Remove(id);
                    response.Message = "Processo realizado com sucesso!";
                }
                else
                {
                    response.Message = "O Id está nulo";
                }
            }
            catch (Exception ex)
            {
                response.Message = String.Format("[Error]:{0};[Method]:{1};[Data]:{2}", ex.Message, "GetLabel", DateTime.Now);
            }
            return response;
        }
    }
}
