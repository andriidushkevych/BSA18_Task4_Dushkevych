using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model
{
    public class Departure : Entity
    {
        public Departure(int flightNumber, DateTime departTimeAssigned, DateTime departTimeActual, List<CrewMember> crew, Plane plane)
        {
            FlightNumber = flightNumber;
            DepartTimeAssigned = departTimeAssigned;
            DepartTimeActual = departTimeActual;
            Crew = crew;
            Plane = plane;
        }

        public int FlightNumber { get; set; }
        public DateTime DepartTimeAssigned { get; set; }
        public DateTime DepartTimeActual { get; set; }
        public List<CrewMember> Crew { get; set; }
        public Plane Plane { get; set; }
    }
}
