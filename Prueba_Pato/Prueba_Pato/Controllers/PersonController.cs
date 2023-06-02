using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Prueba_Pato.Models;
using Prueba_Pato.Services;

namespace Prueba_Pato.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : Controller
    {
        private readonly IPersonService _personService;
        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpGet]
        public ActionResult<List<Person>> AllPersons()
        {
            var persons =  _personService.GetPersons();
            return Ok(persons);
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<Person> OnePerson([FromRoute] int id)
        {
            var personSearched = _personService.GetOnePerson(id);
            return Ok(personSearched);
        }

        [HttpPost]
        public ActionResult<Person> CreatePerson([FromBody] Person newPerson)
        {
            var personCreated = _personService.CreatePerson(newPerson);
            return Ok(personCreated);
        } 

    }
}
