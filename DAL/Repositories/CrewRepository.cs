using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DAL.Model;

namespace DAL.Repositories
{
    public class CrewRepository : Repository<Crew>
    {
        public override void Update(Guid id, Crew entity)
        {
            Crew crewToUpdate = data.Where(t => t.Id.Equals(id)).First();
            crewToUpdate.Pilot = entity.Pilot;
            crewToUpdate.Stewardesses = entity.Stewardesses;
        }
    }
}