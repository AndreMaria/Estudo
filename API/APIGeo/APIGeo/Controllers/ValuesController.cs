using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Netbiis.Lib.TagAlize.Model;
using Netbiis.Lib.TagAlize.TagAlize;
using Netbiis.Lib.TagAlize.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;

namespace APIGeo.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("AllowAll")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{texto}")]
        [DisableCors]
        public List<StandardTags> Get(string texto)
        {
            TagAlize ta = new TagAlize();
            var list = ta.PrepareSearchStringList(texto, enLanguage.Portuguese);
            return list;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
