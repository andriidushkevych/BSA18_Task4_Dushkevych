using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model
{
    public class Departure : Entity
    {
        public int FlightNumber { get; set; }
        public DateTime DepartTimeAssigned { get; set; }
        public DateTime DepartTimeActual { get; set; }
        public List<CrewMember> Crew { get; set; }
        public Plane Plane { get; set; }
    }
}
