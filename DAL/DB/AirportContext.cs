using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using DAL.Model;
using System.Linq;

namespace DAL.DB
{
    public class AirportContext : DbContext
    {
        public AirportContext() : base()
        {
            Database.Migrate();
            Database.EnsureCreated();
        }

        public DbSet<Plane> Plane { get; set; }
        public DbSet<PlaneType> PlaneType { get; set; }
        public DbSet<Crew> Crew { get; set; }
        public DbSet<Departure> Departure { get; set; }
        public DbSet<Flight> Flight { get; set; }
        public DbSet<Pilot> Pilot { get; set; }
        public DbSet<Stewardess> Stewardess { get; set; }
        public DbSet<Ticket> Ticket { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=AirportDB;Trusted_Connection=True;Integrated Security=True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
