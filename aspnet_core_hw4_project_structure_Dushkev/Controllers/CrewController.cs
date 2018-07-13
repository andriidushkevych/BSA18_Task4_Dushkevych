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
    [Route("api/Crew")]
    public class CrewController : Controller
    {
        private IRepository<Crew> repository;

        public CrewController(IRepository<Crew> CrewsRepo)
        {
            this.repository = CrewsRepo;
        }
        //GET: api/Crew/
        [HttpGet]
        public IActionResult GetAll()
        {
            return Json(repository.FetchAll());
        }
        //GET: api/Crew/:id
        [HttpGet("{id})")]
        public IActionResult GetById(Guid id)
        {
            return Json(repository.Get(id));
        }

        //POST: api/Crew/
        [HttpPost]
        public IActionResult Create([FromBody] Crew entity)
        {
            repository.Create(entity);
            return Ok();
        }

        //PUT: api/Crew/:id
        [HttpPut("{id})")]
        public IActionResult Update(Guid id, [FromBody] Crew entity)
        {
            repository.Update(id, entity);
            return Ok();
        }

        //DELETE: api/Crew/:id
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            repository.Delete(id);
            return Ok();
        }
    }
}