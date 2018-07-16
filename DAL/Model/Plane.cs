using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model
{
    public class Plane : Entity
    {
        //public Plane(string name, PlaneType planeType, DateTime manufactureDate, DateTime lifeTimeDate)
        //{
        //    Name = name;
        //    PlaneType = planeType;
        //    ManufactureDate = manufactureDate;
        //    LifeTimeDate = lifeTimeDate;
        //    Timespan = lifeTimeDate.Subtract(manufactureDate);
        //}

        public string Name { get; set; }
        public PlaneType PlaneType { get; set; }
        public DateTime ManufactureDate { get; set; }
        public DateTime LifeTimeDate { get; set; }
        public TimeSpan Timespan { get; set; }
    }
}
