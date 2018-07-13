using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model
{
    public class Pilot : CrewMember
    {
        public int FullYearsExperience { get; set; }

        public Pilot(string fName, string lName, int exp)
        {
            FirstName = fName;
            LastName = lName;
            FullYearsExperience = exp;
        }
    }
}
