using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DAL.Model;

namespace DAL.Repositories
{
    public class DepartureRepository : Repository
    {
        public virtual void Update(Guid id, Departure entity)
        {
            Departure departureToUpdate = (Departure)data.Where(t => t.Id.Equals(id)).First();
            departureToUpdate.FlightNumber = entity.FlightNumber;
            departureToUpdate.Plane = entity.Plane;
            departureToUpdate.DepartTimeAssigned = entity.DepartTimeAssigned;
            departureToUpdate.DepartTimeActual = entity.DepartTimeActual;
            departureToUpdate.Crew = entity.Crew;
        }
    }
}