using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.DTOs
{
    public class PlaneDTO : EntityDTO
    {
        public string Name { get; set; }
        public PlaneTypeDTO PlaneType { get; set; }
        public DateTime ManufactureDate { get; set; }
        public DateTime LifeTimeDate { get; set; }
        public TimeSpan Timespan { get; set; }
    }
}
