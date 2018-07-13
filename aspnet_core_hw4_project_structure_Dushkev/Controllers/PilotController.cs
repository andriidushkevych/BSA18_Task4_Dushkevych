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
    [Route("api/Pilot")]
    public class PilotController : Controller
    {
        private IRepository<Pilot> repository;

        public PilotController(IRepository<Pilot> PilotsRepo)
        {
            this.repository = PilotsRepo;
        }
        //GET: api/Pilot/
        [HttpGet]
        public IActionResult GetAll()
        {
            return Json(repository.FetchAll());
        }
        //GET: api/Pilot/:id
        [HttpGet("{id})")]
        public IActionResult GetById(Guid id)
        {
            return Json(repository.Get(id));
        }

        //POST: api/Pilot/
        [HttpPost]
        public IActionResult Create([FromBody] Pilot entity)
        {
            repository.Create(entity);
            return Ok();
        }

        //PUT: api/Pilot/:id
        [HttpPut("{id})")]
        public IActionResult Update(Guid id, [FromBody] Pilot entity)
        {
            repository.Update(id, entity);
            return Ok();
        }

        //DELETE: api/Pilot/:id
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            repository.Delete(id);
            return Ok();
        }
    }
}