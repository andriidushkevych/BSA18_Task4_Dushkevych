using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DAL.Repositories;
using DAL.Model;

namespace aspnet_core_hw4_project_structure_Dushkev.Controllers
{
    [Produces("application/json")]
    [Route("api/Departure")]
    public class DepartureController : Controller
    {
        private IRepository<Departure> repository;

        public DepartureController(IRepository<Departure> DeparturesRepo)
        {
            this.repository = DeparturesRepo;
        }
        //GET: api/Departure/
        [HttpGet]
        public IActionResult GetAll()
        {
            return Json(repository.FetchAll());
        }
        //GET: api/Departure/:id
        [HttpGet("{id})")]
        public IActionResult GetById(Guid id)
        {
            return Json(repository.Get(id));
        }

        //POST: api/Departure/
        [HttpPost]
        public IActionResult Create([FromBody] Departure entity)
        {
            repository.Create(entity);
            return Ok();
        }

        //PUT: api/Departure/:id
        [HttpPut("{id})")]
        public IActionResult Update(Guid id, [FromBody] Departure entity)
        {
            repository.Update(id, entity);
            return Ok();
        }

        //DELETE: api/Departure/:id
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            repository.Delete(id);
            return Ok();
        }
    }
}