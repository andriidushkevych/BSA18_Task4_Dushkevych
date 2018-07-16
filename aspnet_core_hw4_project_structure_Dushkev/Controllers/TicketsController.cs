using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DAL.Repositories;
using DAL.Model;
using Shared.DTOs;
using BLL.Services;

namespace aspnet_core_hw4_project_structure_Dushkev.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class TicketsController : Controller
    {
        private IService<TicketDTO> service;

        public TicketsController(IService<TicketDTO> ticketService)
        {
            service = ticketService;
        }
        //GET: api/tickets/
        [HttpGet]
        public IActionResult GetAll()
        {
            return Json(service.FetchAll());
        }
        //GET: api/tickets/:id
        [HttpGet("{id})")]
        public IActionResult GetById(Guid id)
        {
            return Json(service.GetById(id));
        }

        //POST: api/tickets/
        [HttpPost]
        public IActionResult Create([FromBody] TicketDTO ticket)
        {
            service.Create(ticket);
            return Ok();
        }

        //PUT: api/tickets/
        [HttpPut]
        public IActionResult Update([FromBody] TicketDTO ticket)
        {
            service.Update(ticket);
            return Ok();
        }

        //DELETE: api/tickets/:id
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            service.Delete(id);
            return Ok();
        }
    }
}