using ApiParaTutorialAngular.Models;
using Swashbuckle.Swagger.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Swashbuckle.Swagger.Annotations;

namespace ApiParaTutorialAngular.Controllers
{
    [RoutePrefix("api")]
    public class TutorialController : ApiController
    {
        [SwaggerResponse(400, "BadRequest")]
        [SwaggerResponse(404, "NotFound")]
        [SwaggerResponse(200, "Ok", typeof(AutocompleteModel))]
        [HttpGet]
        [Route("tutorial/GetAll")]
        public IHttpActionResult GetAll()
        {
            List<AutocompleteModel> list = new List<AutocompleteModel>();
            list.Add(new AutocompleteModel() { Id = 1, Nome = "Albania"});
            list.Add(new AutocompleteModel() { Id = 2, Nome = "Andorra"});
            list.Add(new AutocompleteModel() { Id = 3, Nome = "Armenia"});
            list.Add(new AutocompleteModel() { Id = 4, Nome = "Austria"});
            list.Add(new AutocompleteModel() { Id = 5, Nome = "Azerbaijan"});
            list.Add(new AutocompleteModel() { Id = 6, Nome = "Belarus"});
            list.Add(new AutocompleteModel() { Id = 7, Nome = "Belgium"});
            list.Add(new AutocompleteModel() { Id = 8, Nome = "Bosnia & Herzegovina"});
            list.Add(new AutocompleteModel() { Id = 9, Nome = "Bulgaria"});
            list.Add(new AutocompleteModel() { Id = 10, Nome = "Croatia"});
            list.Add(new AutocompleteModel() { Id = 11, Nome = "Cyprus"});
            list.Add(new AutocompleteModel() { Id = 12, Nome = "Czech Republic"});
            list.Add(new AutocompleteModel() { Id = 13, Nome = "Denmark"});
            list.Add(new AutocompleteModel() { Id = 14, Nome = "Estonia"});
            list.Add(new AutocompleteModel() { Id = 15, Nome = "Finland"});
            list.Add(new AutocompleteModel() { Id = 16, Nome = "France"});
            list.Add(new AutocompleteModel() { Id = 17, Nome = "Georgia"});
            list.Add(new AutocompleteModel() { Id = 18, Nome = "Germany"});
            list.Add(new AutocompleteModel() { Id = 19, Nome = "Greece"});
            list.Add(new AutocompleteModel() { Id = 20, Nome = "Hungary"});
            list.Add(new AutocompleteModel() { Id = 21, Nome = "Iceland"});
            list.Add(new AutocompleteModel() { Id = 22, Nome = "Ireland"});
            list.Add(new AutocompleteModel() { Id = 23, Nome = "Italy"});
            list.Add(new AutocompleteModel() { Id = 24, Nome = "Kosovo"});
            list.Add(new AutocompleteModel() { Id = 25, Nome = "Latvia"});
            list.Add(new AutocompleteModel() { Id = 26, Nome = "Liechtenstein"});
            list.Add(new AutocompleteModel() { Id = 27, Nome = "Lithuania"});
            list.Add(new AutocompleteModel() { Id = 28, Nome = "Luxembourg"});
            list.Add(new AutocompleteModel() { Id = 29, Nome = "Macedonia"});
            list.Add(new AutocompleteModel() { Id = 30, Nome = "Malta"});
            list.Add(new AutocompleteModel() { Id = 31, Nome = "Moldova"});
            list.Add(new AutocompleteModel() { Id = 32, Nome = "Monaco"});
            list.Add(new AutocompleteModel() { Id = 33, Nome = "Montenegro"});
            list.Add(new AutocompleteModel() { Id = 34, Nome = "Netherlands"});
            list.Add(new AutocompleteModel() { Id = 35, Nome = "Norway"});
            list.Add(new AutocompleteModel() { Id = 36, Nome = "Poland"});
            list.Add(new AutocompleteModel() { Id = 37, Nome = "Portugal"});
            list.Add(new AutocompleteModel() { Id = 38, Nome = "Romania"});
            list.Add(new AutocompleteModel() { Id = 39, Nome = "Russia"});
            list.Add(new AutocompleteModel() { Id = 40, Nome = "San Marino"});
            list.Add(new AutocompleteModel() { Id = 41, Nome = "Serbia"});
            list.Add(new AutocompleteModel() { Id = 42, Nome = "Slovakia"});
            list.Add(new AutocompleteModel() { Id = 43, Nome = "Slovenia"});
            list.Add(new AutocompleteModel() { Id = 44, Nome = "Spain"});
            list.Add(new AutocompleteModel() { Id = 45, Nome = "Sweden"});
            list.Add(new AutocompleteModel() { Id = 46, Nome = "Switzerland"});
            list.Add(new AutocompleteModel() { Id = 47, Nome = "Turkey"});
            list.Add(new AutocompleteModel() { Id = 48, Nome = "Ukraine"});
            list.Add(new AutocompleteModel() { Id = 49, Nome = "United Kingdom"});
            list.Add(new AutocompleteModel() { Id = 50, Nome = "Vatican City" });
            return Ok(list);
        }


        [SwaggerResponse(400, "BadRequest")]
        [SwaggerResponse(404, "NotFound")]
        [SwaggerResponse(200, "Ok", typeof(AutocompleteModel))]
        [HttpGet]
        [Route("tutorial/GetAllBeer")]
        public IHttpActionResult GetAllBeer()
        {
            List<AutocompleteModel> list = new List<AutocompleteModel>();
            list.Add(new AutocompleteModel() { Id = 10, Nome = "Kriek" });
            list.Add(new AutocompleteModel() { Id = 9, Nome = "Gueuze" });
            list.Add(new AutocompleteModel() { Id = 8, Nome = "De Koninck" });
            list.Add(new AutocompleteModel() { Id = 7, Nome = "Delirium Tremens" });
            list.Add(new AutocompleteModel() { Id = 6, Nome = "Gouden Carolus" });
            list.Add(new AutocompleteModel() { Id = 5, Nome = "Corsendonk Pater Noster" });
            list.Add(new AutocompleteModel() { Id = 4, Nome = "La Chouffe" });
            list.Add(new AutocompleteModel() { Id = 3, Nome = "Chimay" });
            list.Add(new AutocompleteModel() { Id = 2, Nome = "Brugse Straffe Hendrik" });
            list.Add(new AutocompleteModel() { Id = 1, Nome = "Bush Beer" });
            return Ok(list);
        }
    }
}
