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
    [Route("api/Flight")]
    public class FlightController : Controller
    {
        private IRepository<Flight> repository;

        public FlightController(IRepository<Flight> FlightsRepo)
        {
            this.repository = FlightsRepo;
        }
        //GET: api/Flight/
        [HttpGet]
        public IActionResult GetAll()
        {
            return Json(repository.FetchAll());
        }
        //GET: api/Flight/:id
        [HttpGet("{id})")]
        public IActionResult GetById(Guid id)
        {
            return Json(repository.Get(id));
        }

        //POST: api/Flight/
        [HttpPost]
        public IActionResult Create([FromBody] Flight entity)
        {
            repository.Create(entity);
            return Ok();
        }

        //PUT: api/Flight/:id
        [HttpPut("{id})")]
        public IActionResult Update(Guid id, [FromBody] Flight entity)
        {
            repository.Update(id, entity);
            return Ok();
        }

        //DELETE: api/Flight/:id
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            repository.Delete(id);
            return Ok();
        }
    }
}