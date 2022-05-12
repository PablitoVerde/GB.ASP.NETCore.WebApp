using Lesson3.Models;
using Lesson3.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;

namespace Lesson3.Controllers
{
    [ApiController]
    [Route("api")]
    public class PersonController : Controller
    {
        private readonly PersonRepository personRepository;

        public PersonController()
        {
            personRepository = new PersonRepository();
        }

        [HttpGet("persons/{id})")]
        public async Task<ActionResult<Person>> GetById([FromRoute] int id)
        {
            return Ok(personRepository.GetById(id));
        }

        [HttpGet("persons/search?searchTerm={term}")]
        public async Task<ActionResult<List<Person>>> GetByName([FromRoute] string term)
        {
            return Ok(personRepository.GetByName(term));
        }

        [HttpGet("persons/?skip={skip}&take={take}")]
        public async Task<ActionResult<List<Person>>> GetPaginationList([FromRoute] int skip, [FromRoute] int take)
        {
            return Ok(personRepository.GetAllPagination(skip, take));
        }

        [HttpPost("persons/")]
        public async Task<ActionResult<Person>> Add([FromBody] string item)
        {
            Person p = JsonSerializer.Deserialize<Person>(item);
            return Ok(personRepository.Create(p));
        }

        [HttpPut("persons/")]
        public async Task<ActionResult<Person>> Update([FromBody] string item)
        {
            Person p = JsonSerializer.Deserialize<Person>(item);
            return Ok(personRepository.Update(p));
        }

        [HttpDelete("persons/{id}")]
        public async Task<ActionResult<Person>> Delete([FromRoute] int id)
        {
            return Ok(personRepository.Delete(id));
        }
    }
}