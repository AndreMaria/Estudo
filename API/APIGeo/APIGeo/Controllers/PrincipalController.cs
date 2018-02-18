using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using APIGeo.Model;
using APIGeo.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace APIGeo.Controllers
{
    [Produces("application/json")]
    [Route("api/Principal")]
    public class PrincipalController : Controller
    {
        private PrincipalRepository repository;

        public PrincipalController()
        {
            repository = new PrincipalRepository();
        }

        [HttpGet]
        public IEnumerable<Principal> Get()
        {
            return repository.All();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Principal Get(int id)
        {
            return repository.Find(x => x.Id == id).FirstOrDefault();
        }

        // GET api/values/5
        [HttpGet("{texto}")]
        public List<Principal> Get(string texto)
        {
            return repository.FindByText(texto);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Principal value)
        {
            repository.Save(value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Principal value)
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