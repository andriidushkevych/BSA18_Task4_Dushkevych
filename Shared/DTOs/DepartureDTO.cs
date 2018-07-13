using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.DTOs
{
    public class DepartureDTO : EntityDTO
    {
        public int FlightNumber { get; set; }
        public DateTime DepartTimeAssigned { get; set; }
        public DateTime DepartTimeActual { get; set; }
        public CrewDTO Crew { get; set; }
        public PlaneDTO Plane { get; set; }
    }
}
