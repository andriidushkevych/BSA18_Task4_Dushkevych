using System;
using System.Collections.Generic;
using System.Text;
using DAL.Model;
using System.Linq;

namespace DAL
{
    public class DataSource
    {
        public Dictionary<Type, IEnumerable<Entity>> Data { get; set; }

        public DataSource()
        {
            Data.Add(typeof(Departure), departures);
            Data.Add(typeof(Flight), flights);
            Data.Add(typeof(Ticket), tickets);
            Data.Add(typeof(Crew), crews);
            Data.Add(typeof(Pilot), pilots);
            Data.Add(typeof(Stewardess), stewardesses);
            Data.Add(typeof(Plane), planes);
            Data.Add(typeof(PlaneType), planeTypes);
        }

        private static List<Pilot> pilots = new List<Pilot>()
        {
            new Pilot("Andrew", "Stones", 3),
            new Pilot("Bill", "Moore", 15),
            new Pilot("David", "Patch", 8)
        };

        private static List<Stewardess> stewardesses = new List<Stewardess>()
        {
            new Stewardess("Sandra", "Gillmore"),
            new Stewardess("Kathy", "Rose"),
            new Stewardess("Madeline", "Clarke"),
            new Stewardess("Carrie", "Hunter"),
            new Stewardess("Leigha", "Coughlan"),
            new Stewardess("Alex", "Harrison")
        };

        private static List<Crew> crews = new List<Crew>()
        {
            new Crew(pilots[0], new List<Stewardess>() { stewardesses[0], stewardesses[1] }),
            new Crew(pilots[1], new List<Stewardess>() { stewardesses[2], stewardesses[3] }),
            new Crew(pilots[2], new List<Stewardess>() { stewardesses[4], stewardesses[5] })
        };

        private static List<PlaneType> planeTypes = new List<PlaneType>()
        {
            new PlaneType("SSJ-95LR", 98, 12250),
            new PlaneType("Boeing-747", 425, 20000),
            new PlaneType("Boeing-777", 235, 20000)
        };

        private static List<Plane> planes = new List<Plane>()
        {
            new Plane("SSJ-95LR-AirCanada", planeTypes[0], new DateTime(2002, 10, 31), new DateTime(2022, 10, 31)),
            new Plane("Boeing-747-Delta", planeTypes[1], new DateTime(2008, 11, 14), new DateTime(2028, 11, 14)),
            new Plane("Boeing-777-AirFrance", planeTypes[2], new DateTime(2014, 01, 01), new DateTime(2034, 01, 01))
        };

        private static List<Ticket> tickets = new List<Ticket>()
        {
            new Ticket(222.2m, 2408),
            new Ticket(505m, 3501),
            new Ticket(108.38m, 1233),
            new Ticket(204m, 2408),
            new Ticket(518.6m, 3501),
            new Ticket(120m, 1233),
            new Ticket(224.5m, 2408),
            new Ticket(508.2m, 3501),
            new Ticket(110.1m, 1233)
        };

        private static List<Departure> departures = new List<Departure>()
        {
            new Departure(2408, new DateTime(2018, 07, 15, 16, 34, 00), new DateTime(2018, 07, 15, 16, 35, 00), crews[0], planes[0]),
            new Departure(1233, new DateTime(2018, 07, 16, 20, 05, 00), new DateTime(2018, 07, 16, 20, 05, 00), crews[1], planes[1]),
            new Departure(3501, new DateTime(2018, 07, 15, 17, 00, 00), new DateTime(2018, 07, 15, 17, 30, 00), crews[2], planes[2])
        };

        private static List<Flight> flights = new List<Flight>()
        {
            new Flight(2408, "Toronto-YYZ", departures.Where(d=>d.FlightNumber == 2408).Single().DepartTimeAssigned, departures.Where(d=>d.FlightNumber == 2408).Single().DepartTimeActual, "Paris-CDG", new DateTime(2018, 07, 16, 08, 24, 00), new DateTime(2018, 07, 16, 08, 55, 00), tickets.Where(t => t.FlightNumber == 2408).ToList()),
            new Flight(1233, "New York-JFK", departures.Where(d=>d.FlightNumber == 1233).Single().DepartTimeAssigned, departures.Where(d=>d.FlightNumber == 1233).Single().DepartTimeActual, "Miami-MIA", new DateTime(2018, 07, 16, 23, 15, 00), new DateTime(2018, 07, 16, 23, 15, 00), new List<Ticket>(){ tickets[2], tickets[5], tickets[8] }),
            new Flight(3501, "Paris-CDG", departures.Where(d=>d.FlightNumber == 3501).Single().DepartTimeAssigned, departures.Where(d=>d.FlightNumber == 3501).Single().DepartTimeActual, "Amsterdam-AMS", new DateTime(2018, 07, 15, 19, 20, 00), new DateTime(2018, 07, 15, 19, 20, 00), new List<Ticket>(){ tickets[1], tickets[4], tickets[7] })
        };

        public List<Flight> GetFlights() { return flights; }
        public List<Departure> GetDepartures() { return departures; }
        public List<Ticket> GetTickets() { return tickets; }
        public List<Crew> GetCrews() { return crews; }
        public List<Pilot> GetPilots() { return pilots; }
        public List<Stewardess> GetStewardesses() { return stewardesses; }
        public List<Plane> GetPlanes() { return planes; }
        public List<PlaneType> GetPlaneTypes() { return planeTypes; }
    }
}
