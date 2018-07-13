using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.DTOs
{
    public class StewardessDTO : EntityDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
