using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model
{
    public class Crew : Entity
    {
        public Crew(Pilot pilot, List<Stewardess> stewardesses)
        {
            Pilot = pilot;
            Stewardesses = stewardesses;
        }

        public Pilot Pilot { get; set; }
        public List<Stewardess> Stewardesses { get; set; }
    }
}
