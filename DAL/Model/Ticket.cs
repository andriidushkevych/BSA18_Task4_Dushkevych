using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model
{
    public class Ticket : Entity
    {
        public Ticket(decimal price, int flightNumber)
        {
            Price = price;
            FlightNumber = flightNumber;
        }

        public decimal Price { get; set; }
        public int FlightNumber { get; set; }
    }
}
