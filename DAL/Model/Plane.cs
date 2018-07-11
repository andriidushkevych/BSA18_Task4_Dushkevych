using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model
{
    public class Plane : Entity
    {
        public string Name { get; set; }
        public PlaneType PlaneType { get; set; }
        public DateTime ManufactureDate { get; set; }
        public DateTime LifeTimeDate { get; set; }
        public DateTime TimeSpan { get; set; }
    }
}
