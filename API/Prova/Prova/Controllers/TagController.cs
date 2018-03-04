using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Prova.Core.Model;
using Prova.Core.Repository;

namespace Prova.Controllers
{
    public class TagController : ApiController
    {
        private TagRepository tagRepository = null;
        public TagController()
        {
            tagRepository = new TagRepository();
        }

        [HttpPost]
        public void AddNewTag(String text, long idContent)
        {
            var items = Util.Util.CreateTags(text);

            foreach (var item in items)
            {
                tagRepository.Save(new Tag() { Common = item.Tag, Normalized = item.Normalized, IdContent = idContent });
            }
        }

        [HttpGet]
        public List<Tag> ListTagByID(long idContent)
        {
            return this.tagRepository.Find(x => x.IdContent == idContent);
        }
    }
}
