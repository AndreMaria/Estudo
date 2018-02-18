using System;
using System.Collections.Generic;
using System.Web.Http;
using SearchByTag.Core.Model;
using SearchByTag.Core.Repository;

namespace SearchByTag.Controllers
{
    public class LabelController : ApiController
    {
        private LabelRepository repository;
        public LabelController()
        {
            repository = new LabelRepository();
        }

        [HttpGet]
        public Label Get(long id)
        {
            return repository.FirstOrDefault(id);
        }

        [HttpGet]
        public List<Label> Get(String serach)
        {
            return repository.FindByText(serach);
        }

        [HttpPost]
        public Label Save(Label item)
        {
            return repository.Save(item);
        }
    }
}
