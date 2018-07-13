using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model
{
    public class Stewardess : CrewMember
    {
        public Stewardess(string fName, string lName)
        {
            FirstName = fName;
            LastName = lName;
        }
    }
}
