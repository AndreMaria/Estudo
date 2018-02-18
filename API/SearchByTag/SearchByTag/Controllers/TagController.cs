using System;
using System.Collections.Generic;
using System.Web.Http;
using SearchByTag.Core.Model;
using SearchByTag.Core.Repository;


namespace SearchByTag.Controllers
{
    public class TagController : ApiController
    {
        private TagRepository repository;
        public TagController()
        {
            repository = new TagRepository();
        }

        [HttpGet]
        public Tag Get(long id)
        {
            return repository.FirstOrDefault(id);
        }

        [HttpGet]
        public List<Tag> Get(String serach)
        {
            return repository.FindByText(serach);
        }

        [HttpPost]
        public Tag Save(Tag item)
        {
            return repository.Save(item);
        }

    }
}
