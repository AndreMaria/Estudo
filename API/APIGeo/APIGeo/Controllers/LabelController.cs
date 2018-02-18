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
    [Route("api/Label")]
    public class LabelController : Controller
    {
        private LabelRepository repository;

        public LabelController()
        {
            repository = new LabelRepository();
        }

        [HttpGet]
        public IEnumerable<Label> Get()
        {
            return repository.All();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Label Get(int id)
        {
            return repository.Find(x => x.Id == id).FirstOrDefault();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Label value)
        {
            repository.Save(value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Label value)
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