using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model
{
    public class Flight : Entity
    {

        public Flight(int number, string origin, DateTime departTimeAssigned, DateTime departTimeActual, string destination, DateTime arrivalTimeAssigned, DateTime arrivalTimeActual, List<Ticket> tickets)
        {
            Id = Guid.NewGuid();
            Number = number;
            Origin = origin;
            DepartTimeAssigned = departTimeAssigned;
            DepartTimeActual = departTimeActual;
            Destination = destination;
            ArrivalTimeAssigned = arrivalTimeAssigned;
            ArrivalTimeActual = arrivalTimeActual;
            Tickets = tickets;
        }

        public int Number { get; set; }
        public string Origin { get; set; }
        public DateTime DepartTimeAssigned { get; set; }
        public DateTime DepartTimeActual { get; set; }
        public string Destination { get; set; }
        public DateTime ArrivalTimeAssigned { get; set; }
        public DateTime ArrivalTimeActual { get; set; }
        public List<Ticket> Tickets { get; set; }        
    }
}
