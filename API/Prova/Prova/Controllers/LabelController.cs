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
    public class LabelController : ApiController
    {
        private LabelRepository labelRepository = null;

        public LabelController()
        {
            labelRepository = new LabelRepository();
        }

        [HttpGet]
        public List<Label> ListLabelByID(long idContent)
        {
            return this.labelRepository.Find(x => x.IdContent == idContent);
        }

    }
}
