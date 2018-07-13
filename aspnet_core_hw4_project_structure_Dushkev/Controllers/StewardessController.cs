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
    [Route("api/Stewardess")]
    public class StewardessController : Controller
    {
        private IRepository<Stewardess> repository;

        public StewardessController(IRepository<Stewardess> StewardesssRepo)
        {
            this.repository = StewardesssRepo;
        }
        //GET: api/Stewardess/
        [HttpGet]
        public IActionResult GetAll()
        {
            return Json(repository.FetchAll());
        }
        //GET: api/Stewardess/:id
        [HttpGet("{id})")]
        public IActionResult GetById(Guid id)
        {
            return Json(repository.Get(id));
        }

        //POST: api/Stewardess/
        [HttpPost]
        public IActionResult Create([FromBody] Stewardess entity)
        {
            repository.Create(entity);
            return Ok();
        }

        //PUT: api/Stewardess/:id
        [HttpPut("{id})")]
        public IActionResult Update(Guid id, [FromBody] Stewardess entity)
        {
            repository.Update(id, entity);
            return Ok();
        }

        //DELETE: api/Stewardess/:id
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            repository.Delete(id);
            return Ok();
        }
    }
}