using System;
using System.Collections.Generic;
using System.Web.Http;
using SearchByTag.Core.Model;
using SearchByTag.Core.Repository;
using SearchByTag.Models;

namespace SearchByTag.Controllers
{
    public class MainController : ApiController
    {
        private MainRepository repository;
        public MainController()
        {
            repository = new MainRepository();
        }

        [HttpGet]
        public Main Get(long id)
        {
            return repository.FirstOrDefault(id);
        }

        [HttpGet]
        public List<Main> Get(String serach)
        {
            return repository.FindByText(serach);
        }

        [HttpPost]
        [Route("api/main/save")]
        public Main Save(Main item)
        {
            return repository.Save(item);
        }

    }
}
