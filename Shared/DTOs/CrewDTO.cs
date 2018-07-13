using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.DTOs
{
    public class CrewDTO : EntityDTO
    {
        public PilotDTO Pilot { get; set; }
        public List<StewardessDTO> Stewardesses { get; set; }
    }
}
