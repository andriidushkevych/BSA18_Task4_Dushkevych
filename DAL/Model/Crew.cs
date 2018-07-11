using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model
{
    public class Crew : Entity
    {
        public Pilot Pilot { get; set; }
        public List<Stewardess> Stewardesses { get; set; }
    }
}
