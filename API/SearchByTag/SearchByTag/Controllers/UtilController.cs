using SearchByTag.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SearchByTag.Controllers
{
    public class UtilController : ApiController
    {
        [HttpGet]
        public List<TagAlize> GetNewTags(String words)
        {
            return Util.Util.CreateTags(words);
        }
    }
}
