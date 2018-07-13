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
    [Route("api/Plane")]
    public class PlaneController : Controller
    {
        private IRepository<Plane> repository;

        public PlaneController(IRepository<Plane> PlanesRepo)
        {
            this.repository = PlanesRepo;
        }
        //GET: api/Plane/
        [HttpGet]
        public IActionResult GetAll()
        {
            return Json(repository.FetchAll());
        }
        //GET: api/Plane/:id
        [HttpGet("{id})")]
        public IActionResult GetById(Guid id)
        {
            return Json(repository.Get(id));
        }

        //POST: api/Plane/
        [HttpPost]
        public IActionResult Create([FromBody] Plane entity)
        {
            repository.Create(entity);
            return Ok();
        }

        //PUT: api/Plane/:id
        [HttpPut("{id})")]
        public IActionResult Update(Guid id, [FromBody] Plane entity)
        {
            repository.Update(id, entity);
            return Ok();
        }

        //DELETE: api/Plane/:id
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            repository.Delete(id);
            return Ok();
        }
    }
}