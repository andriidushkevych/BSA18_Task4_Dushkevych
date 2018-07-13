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
    [Route("api/PlaneType")]
    public class PlaneTypeController : Controller
    {
        private IRepository<PlaneType> repository;

        public PlaneTypeController(IRepository<PlaneType> planeTypesRepo)
        {
            this.repository = planeTypesRepo;
        }
        //GET: api/planetype/
        [HttpGet]
        public IActionResult GetAll()
        {
            return Json(repository.FetchAll());
        }
        //GET: api/planetype/:id
        [HttpGet("{id})")]
        public IActionResult GetById(Guid id)
        {
            return Json(repository.Get(id));
        }

        //POST: api/planetype/
        [HttpPost]
        public IActionResult Create([FromBody] PlaneType entity)
        {
            repository.Create(entity);
            return Ok();
        }

        //PUT: api/planetype/:id
        [HttpPut("{id})")]
        public IActionResult Update(Guid id, [FromBody] PlaneType entity)
        {
            repository.Update(id, entity);
            return Ok();
        }

        //DELETE: api/planetype/:id
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            repository.Delete(id);
            return Ok();
        }
    }
}