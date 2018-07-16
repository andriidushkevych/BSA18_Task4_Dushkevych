using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using DAL.DB;
using DAL.Model;

namespace DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private AirportContext _ctx;

        private IRepository<Plane> _planeRepository;
        private IRepository<PlaneType> _planeTypeRepository;
        private IRepository<Crew> _crewRepository;
        private IRepository<Departure> _deaprtureRepository;
        private IRepository<Flight> _flightRepository;
        private IRepository<Pilot> _pilotRepository;
        private IRepository<Stewardess> _stewardessRepository;
        private IRepository<Ticket> _ticketRepository;

        public UnitOfWork(AirportContext context)
        {
            _ctx = context;
        }

        public IRepository<Plane> Planes
        {
            get
            {
                if (_planeRepository == null)
                    _planeRepository = new PlaneRepository(_ctx);
                return _planeRepository;
            }
        }

        public IRepository<Pilot> Pilots
        {
            get
            {
                if (_pilotRepository == null)
                    _pilotRepository = new PilotRepository(_ctx);
                return _pilotRepository;
            }
        }

        public IRepository<Stewardess> Stewardesses
        {
            get
            {
                if (_stewardessRepository == null)
                    _stewardessRepository = new StewardessRepository(_ctx);
                return _stewardessRepository;
            }
        }

        public IRepository<Ticket> Tickets
        {
            get
            {
                if (_ticketRepository == null)
                    _ticketRepository = new TicketRepository(_ctx);
                return _ticketRepository;
            }
        }

        public IRepository<Crew> Crews
        {
            get
            {
                if (_crewRepository == null)
                    _crewRepository = new CrewRepository(_ctx);
                return _crewRepository;
            }
        }

        public IRepository<Flight> Flights
        {
            get
            {
                if (_flightRepository == null)
                    _flightRepository = new FlightRepository(_ctx);
                return _flightRepository;
            }
        }

        public IRepository<Departure> Departures
        {
            get
            {
                if (_deaprtureRepository == null)
                    _deaprtureRepository = new DepartureRepository(_ctx);
                return _deaprtureRepository;
            }
        }

        public IRepository<PlaneType> PlaneTypes
        {
            get
            {
                if (_planeTypeRepository == null)
                    _planeTypeRepository = new PlaneTypeRepository(_ctx);
                return _planeTypeRepository;
            }
        }

        public void Commit()
        {
            _ctx.SaveChanges();
        }

        public void Dispose()
        {
            _ctx.Dispose();

        }
    }
}
