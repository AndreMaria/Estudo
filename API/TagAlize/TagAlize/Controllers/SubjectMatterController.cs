using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web.Http;
using TagAlize.Core.Model;
using TagAlize.Core.Service;
using TagAlize.Models;
using TagAlize.Util;

namespace TagAlize.Controllers
{
    public class SubjectMatterController : ApiController
    {
        private SubjectMatterService subjectMatterService;

        public SubjectMatterController()
        {
            subjectMatterService = new SubjectMatterService();
        }

        [HttpPost]
        public Response<SubjectMatter> CreateSubjectMatter(SubjectMatterViewModel entity)
        {
            Response<SubjectMatter> response = new Response<SubjectMatter>();
            try
            {
                if (null != entity)
                {
                    SubjectMatter sm = new SubjectMatter();
                    List<TagAlise> listTagAlize = null;

                    sm.Content = entity.Content;
                    sm.Labels = new List<Label>();
                    sm.Labels.Add(new Label() { Title = entity.Label });

                    listTagAlize = Util.Util.CreateTagAlise(entity.Label);
                    if (null != listTagAlize)
                    {
                        if (null != entity.Tags && entity.Tags.Count > 0)
                        {
                            foreach (var item in entity.Tags)
                            {
                                listTagAlize.AddRange(Util.Util.CreateTagAlise(item));
                            }
                        }
                    }
                    else
                    {
                        if (null != entity.Tags && entity.Tags.Count > 0)
                        {
                            foreach (var item in entity.Tags)
                            {
                                listTagAlize = Util.Util.CreateTagAlise(item);
                            }
                        }
                    }

                    if (null != listTagAlize && listTagAlize.Count > 0)
                    {
                        sm.Tags = new List<Tag>();
                        foreach (var item in listTagAlize)
                        {
                            sm.Tags.Add(new Tag() { SimpleText = item.Tag, Normalized = item.Normalized });
                        }
                    }
                    subjectMatterService.Save(sm);
                    response.Message = "Processo realizado com sucesso!";
                }
                else
                {
                    response.Message = "SubjectMatter está nulo";
                }
            }
            catch (Exception ex)
            {
                response.Message = String.Format("[Error]:{0};[Method]:{1};[Data]:{2}", ex.Message, "CreateSubjectMatter", DateTime.Now);
            }
            return response;
        }

        [HttpGet]
        public Response<SubjectMatter> GetSubjectMatter(long id)
        {
            Response<SubjectMatter> response = new Response<SubjectMatter>();
            try
            {
                if (id > 0)
                {
                    response.Item = subjectMatterService.FirstOrDefault(id);
                    response.Message = "Processo realizado com sucesso!";
                }
                else
                {
                    response.Message = "O Id está nulo";
                }
            }
            catch (Exception ex)
            {
                response.Message = String.Format("[Error]:{0};[Method]:{1};[Data]:{2}", ex.Message, "GetSubjectMatter", DateTime.Now);
            }
            return response;
        }

        [HttpPut]
        public Response<SubjectMatter> UpdateSubjectMatter(SubjectMatter entity)
        {
            Response<SubjectMatter> response = new Response<SubjectMatter>();
            try
            {
                if (null != entity)
                {
                    subjectMatterService.Save(entity);
                    response.Message = "Processo realizado com sucesso!";
                }
                else
                {
                    response.Message = "SubjectMatter está nulo";
                }
            }
            catch (Exception ex)
            {
                response.Message = String.Format("[Error]:{0};[Method]:{1};[Data]:{2}", ex.Message, "GetSubjectMatter", DateTime.Now);
            }
            return response;
        }

        [HttpDelete]
        public Response<SubjectMatter> RemoveSubjectMatter(long id)
        {
            Response<SubjectMatter> response = new Response<SubjectMatter>();
            Expression<Func<SubjectMatter, bool>> filter = x => x.Id == 1;
            try
            {
                if (id > 0)
                {
                    subjectMatterService.Remove(id);
                    response.Message = "Processo realizado com sucesso!";
                }
                else
                {
                    response.Message = "O Id está nulo";
                }
            }
            catch (Exception ex)
            {
                response.Message = String.Format("[Error]:{0};[Method]:{1};[Data]:{2}", ex.Message, "GetSubjectMatter", DateTime.Now);
            }
            return response;
        }
    }
}
