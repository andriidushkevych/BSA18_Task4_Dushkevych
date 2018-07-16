using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model
{
    public class Flight : Entity
    {
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
