using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DAL.Model;

namespace DAL.DB
{
    public class DataSeeder
    {
        public static void SeedAirportData(AirportContext context)
        {
            List<Pilot> pilots = new List<Pilot>
                {
                    new Pilot{ FirstName = "Andrew", LastName = "Stones", FullYearsExperience = 3 },
                    new Pilot{ FirstName = "Bill", LastName = "Bobbeys", FullYearsExperience = 8 },
                    new Pilot{ FirstName = "John", LastName = "Hunter", FullYearsExperience = 1 }
                };

            List<Stewardess> stewardesses = new List<Stewardess>
                {
                    new Stewardess { FirstName = "Sandra", LastName = "Gillmore" },
                    new Stewardess { FirstName = "Kathy", LastName = "Rose" },
                    new Stewardess { FirstName = "Madeline", LastName = "Clarke" },
                    new Stewardess { FirstName = "Carrie", LastName = "Hunter" },
                    new Stewardess { FirstName = "Leigha", LastName = "Coughlan" },
                    new Stewardess { FirstName = "Alex", LastName = "Harrison" }
                };

            List<Crew> crews = new List<Crew>()
            {
                new Crew{Pilot = pilots[0], Stewardesses = new List<Stewardess>() { stewardesses[0], stewardesses[1] } },
                new Crew{Pilot = pilots[1], Stewardesses = new List<Stewardess>() { stewardesses[2], stewardesses[3] } },
                new Crew{Pilot = pilots[2], Stewardesses = new List<Stewardess>() { stewardesses[4], stewardesses[5] } }
            };

            List<PlaneType> planeTypes = new List<PlaneType>()
            {
                new PlaneType { Model =  "SSJ-95LR",  Capacity = 98,  CargoKg = 12250 },
                new PlaneType { Model = "Boeing-747", Capacity = 425, CargoKg = 20000 },
                new PlaneType { Model = "Boeing-777", Capacity = 235, CargoKg = 20000 }
            };

            List<Plane> planes = new List<Plane>()
            {
                new Plane { Name = "SSJ-95LR-AirCanada", PlaneType =  planeTypes[0], ManufactureDate = new DateTime(2002, 10, 31), LifeTimeDate = new DateTime(2022, 10, 31) },
                new Plane { Name = "Boeing-747-Delta", PlaneType = planeTypes[1], ManufactureDate = new DateTime(2008, 11, 14), LifeTimeDate = new DateTime(2028, 11, 14) },
                new Plane { Name = "Boeing-777-AirFrance", PlaneType = planeTypes[2], ManufactureDate = new DateTime(2014, 01, 01), LifeTimeDate = new DateTime(2034, 01, 01) }
            };

            List<Ticket> tickets = new List<Ticket>()
            {
                new Ticket { Price = 222.2m,    FlightNumber = 2408 },
                new Ticket { Price = 505m,      FlightNumber = 3501 },
                new Ticket { Price = 108.38m,   FlightNumber = 1233 },
                new Ticket { Price = 204m,      FlightNumber = 2408 },
                new Ticket { Price = 518.6m,    FlightNumber = 3501 },
                new Ticket { Price = 120m,      FlightNumber = 1233 },
                new Ticket { Price = 224.5m,    FlightNumber = 2408 },
                new Ticket { Price = 508.2m,    FlightNumber = 3501 },
                new Ticket { Price = 110.1m,    FlightNumber = 1233 }
            };

            List<Departure> departures = new List<Departure>()
            {
                new Departure { FlightNumber = 2408, DepartTimeAssigned = new DateTime(2018, 07, 15, 16, 34, 00), DepartTimeActual = new DateTime(2018, 07, 15, 16, 35, 00), Crew = crews[0], Plane = planes[0] },
                new Departure { FlightNumber = 1233, DepartTimeAssigned = new DateTime(2018, 07, 16, 20, 05, 00), DepartTimeActual = new DateTime(2018, 07, 16, 20, 05, 00), Crew = crews[1], Plane = planes[1] },
                new Departure { FlightNumber = 3501, DepartTimeAssigned = new DateTime(2018, 07, 15, 17, 00, 00), DepartTimeActual = new DateTime(2018, 07, 15, 17, 30, 00), Crew = crews[2], Plane = planes[2] }
            };

            List<Flight> flights = new List<Flight>()
            {
                new Flight { Number = 2408, Origin = "Toronto-YYZ",  DepartTimeAssigned = departures.Where(d=>d.FlightNumber == 2408).Single().DepartTimeAssigned, DepartTimeActual = departures.Where(d=>d.FlightNumber == 2408).Single().DepartTimeActual, Destination = "Paris-CDG",     ArrivalTimeAssigned = new DateTime(2018, 07, 16, 08, 24, 00), ArrivalTimeActual = new DateTime(2018, 07, 16, 08, 55, 00), Tickets = tickets.Where(t => t.FlightNumber == 2408).ToList() },
                new Flight { Number = 1233, Origin = "New York-JFK", DepartTimeAssigned = departures.Where(d=>d.FlightNumber == 1233).Single().DepartTimeAssigned, DepartTimeActual = departures.Where(d=>d.FlightNumber == 1233).Single().DepartTimeActual, Destination = "Miami-MIA",     ArrivalTimeAssigned = new DateTime(2018, 07, 16, 23, 15, 00), ArrivalTimeActual = new DateTime(2018, 07, 16, 23, 15, 00), Tickets = new List<Ticket>(){ tickets[2], tickets[5], tickets[8] } },
                new Flight { Number = 3501, Origin = "Paris-CDG",    DepartTimeAssigned = departures.Where(d=>d.FlightNumber == 3501).Single().DepartTimeAssigned, DepartTimeActual = departures.Where(d=>d.FlightNumber == 3501).Single().DepartTimeActual, Destination = "Amsterdam-AMS", ArrivalTimeAssigned = new DateTime(2018, 07, 15, 19, 20, 00), ArrivalTimeActual = new DateTime(2018, 07, 15, 19, 20, 00), Tickets = new List<Ticket>(){ tickets[1], tickets[4], tickets[7] } }
            };

            if (!context.Pilot.Any())
            {
                context.AddRange(pilots);
                context.SaveChanges();
            }
            if (!context.Stewardess.Any())
            {
                context.AddRange(stewardesses);
                context.SaveChanges();
            }
            if (!context.Crew.Any())
            {
                context.AddRange(crews);
                context.SaveChanges();
            }
            if (!context.PlaneType.Any())
            {
                context.AddRange(planeTypes);
                context.SaveChanges();
            }
            if (!context.Plane.Any())
            {
                context.AddRange(planes);
                context.SaveChanges();
            }
            if (!context.Ticket.Any())
            {
                context.AddRange(tickets);
                context.SaveChanges();
            }
            if (!context.Departure.Any())
            {
                context.AddRange(departures);
                context.SaveChanges();
            }
            if (!context.Flight.Any())
            {
                context.AddRange(flights);
                context.SaveChanges();
            }
        }
    }
}
