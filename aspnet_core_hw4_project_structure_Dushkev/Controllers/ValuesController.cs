﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DAL.Model;
using DAL.DB;

namespace aspnet_core_hw4_project_structure_Dushkev.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly AirportContext _context;
        public ValuesController(AirportContext context)
        {
            _context = context;
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            Ticket ticket = new Ticket() { Id = Guid.NewGuid(), Price = 22, FlightNumber = 55 };
            _context.Ticket.Add(ticket);
            _context.SaveChanges();
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
