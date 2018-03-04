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
    public class TagAlizeController : ApiController
    {
        private ContentRepository contentRepository = null;

        public TagAlizeController()
        {
            contentRepository = new ContentRepository();
        }

        [HttpPost]
        public long AddNewContent(Content entity)
        {
            return contentRepository.Save(entity);
        }

        [HttpGet]
        public List<Content> ListContentByID(long idContent)
        {
            return this.contentRepository.Find(x => x.Id == idContent);
        }

    }
}
