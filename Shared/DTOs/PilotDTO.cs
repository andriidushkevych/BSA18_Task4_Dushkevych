using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.DTOs
{
    public class PilotDTO : EntityDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int FullYearsExperience { get; set; }
    }
}
