using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DAL.Repositories;
using DAL.Model;

namespace aspnet_core_hw4_project_structure_Dushkev.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class TicketsController : Controller
    {
        private IRepository<Ticket> repository;

        public TicketsController(IRepository<Ticket> ticketsRepo)
        {
            this.repository = ticketsRepo;
        }
        //GET: api/tickets/
        [HttpGet]
        public IActionResult GetAll()
        {
            return Json(repository.FetchAll());
        }
        //GET: api/tickets/:id
        [HttpGet("{id})")]
        public IActionResult GetById(Guid id)
        {
            return Json(repository.Get(id));
        }

        //POST: api/tickets/
        [HttpPost]
        public IActionResult Create([FromBody] Ticket ticket)
        {
            repository.Create(ticket);
            return Ok();
        }

        //PUT: api/tickets/:id
        [HttpPut("{id})")]
        public IActionResult Update(Guid id, [FromBody] Ticket ticket)
        {
            repository.Update(id, ticket);
            return Ok();
        }

        //DELETE: api/tickets/:id
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            repository.Delete(id);
            return Ok();
        }
    }
}