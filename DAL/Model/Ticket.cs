using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model
{
    public class Ticket : Entity
    {
        public decimal Price { get; set; }
        public int FlightNumber { get; set; }
    }
}
