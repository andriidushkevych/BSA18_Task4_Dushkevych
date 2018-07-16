using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using DAL.DB;
using DAL.Model;

namespace DAL.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<PlaneType> PlaneTypes { get; }
        IRepository<Plane> Planes { get; }
        IRepository<Crew> Crews { get; }
        IRepository<Departure> Departures { get; }
        IRepository<Flight> Flights { get; }
        IRepository<Pilot> Pilots { get; }
        IRepository<Stewardess> Stewardesses { get; }
        IRepository<Ticket> Tickets { get; }

        void Commit();
    }
}
