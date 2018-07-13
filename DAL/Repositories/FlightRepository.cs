using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DAL.Model;

namespace DAL.Repositories
{
    public class FlightRepository : Repository<Flight>
    {
        public override void Update(Guid id, Flight entity)
        {
            Flight flightToUpdate = data.Where(p => p.Id.Equals(id)).First();
            flightToUpdate.Number = entity.Number;
            flightToUpdate.Origin = entity.Origin;
            flightToUpdate.Destination = entity.Destination;
            flightToUpdate.Tickets = entity.Tickets;
            flightToUpdate.DepartTimeAssigned = entity.DepartTimeAssigned;
            flightToUpdate.DepartTimeActual = entity.DepartTimeActual;
            flightToUpdate.ArrivalTimeActual = entity.ArrivalTimeActual;
            flightToUpdate.ArrivalTimeActual = entity.ArrivalTimeActual;
        }
    }
}
