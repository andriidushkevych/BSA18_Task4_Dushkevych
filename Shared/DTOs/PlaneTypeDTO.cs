using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.DTOs
{
    public class PlaneTypeDTO : EntityDTO
    {
        public string Model { get; set; }
        public int Capacity { get; set; }
        public int CargoKg { get; set; }
    }
}
