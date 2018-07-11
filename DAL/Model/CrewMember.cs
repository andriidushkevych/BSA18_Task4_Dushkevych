using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model
{
    public class CrewMember : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
