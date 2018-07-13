using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.DTOs
{
    public class FlightDTO : EntityDTO
    {
        public int Number { get; set; }
        public string Origin { get; set; }
        public DateTime DepartTimeAssigned { get; set; }
        public DateTime DepartTimeActual { get; set; }
        public string Destination { get; set; }
        public DateTime ArrivalTimeAssigned { get; set; }
        public DateTime ArrivalTimeActual { get; set; }
        public List<TicketDTO> Tickets { get; set; }
    }
}
