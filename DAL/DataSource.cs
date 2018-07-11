using System;
using System.Collections.Generic;
using System.Text;
using DAL.Model;
using System.Linq;

namespace DAL
{
    public class DataSource
    {
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

        private static List<Flight> flights = new List<Flight>()
        {
            new Flight(2408, "Toronto-YYZ", new DateTime(2018, 07, 15, 16, 34, 00), new DateTime(2018, 07, 15, 16, 35, 00), "Paris-CDG", new DateTime(2018, 07, 16, 08, 24, 00), new DateTime(2018, 07, 16, 08, 24, 00), new List<Ticket>(){ tickets[0], tickets[3], tickets[6] }),
            new Flight(1233, "New York-JFK", new DateTime(2018, 07, 15, 16, 34, 00), new DateTime(2018, 07, 15, 16, 35, 00), "Miami-MIA", new DateTime(2018, 07, 16, 08, 24, 00), new DateTime(2018, 07, 16, 08, 24, 00), new List<Ticket>(){ tickets[2], tickets[5], tickets[8] }),
            new Flight(3501, "Paris-CDG", new DateTime(2018, 07, 15, 16, 34, 00), new DateTime(2018, 07, 15, 16, 35, 00), "Amsterdam-AMS", new DateTime(2018, 07, 16, 08, 24, 00), new DateTime(2018, 07, 16, 08, 24, 00), new List<Ticket>(){ tickets[1], tickets[4], tickets[7] })
        };
    }
}
