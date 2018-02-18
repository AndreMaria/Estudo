using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIGeo.Model;
using APIGeo.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIGeo.Controllers
{
    [Produces("application/json")]
    [Route("api/Tag")]
    public class TagController : Controller
    {
        private TagRepository repository;

        public TagController()
        {
            repository = new TagRepository();
        }

        [HttpGet]
        public IEnumerable<Tag> Get()
        {
            return repository.All();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Tag Get(int id)
        {
            return repository.Find(x => x.Id == id).FirstOrDefault();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Tag value)
        {
            repository.Save(value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Tag value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var item = repository.Find(x => x.Id == id).FirstOrDefault();
            if (null != item)
            {
                repository.Delete(item);
            }
        }
    }
}