using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.DTOs
{
    public class TicketDTO : EntityDTO
    {
        public decimal Price { get; set; }
        public int FlightNumber { get; set; }
    }
}
