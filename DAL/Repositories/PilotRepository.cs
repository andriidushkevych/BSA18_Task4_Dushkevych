using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DAL.Model;

namespace DAL.Repositories
{
    public class PilotRepository : Repository<Pilot>
    {        
        public override void Update(Guid id, Pilot entity)
        {
            Pilot pilotToUpdate = data.Where(p => p.Id.Equals(id)).First();
            pilotToUpdate.FirstName = entity.FirstName;
            pilotToUpdate.LastName = entity.LastName;
            pilotToUpdate.FullYearsExperience = entity.FullYearsExperience;
            pilotToUpdate.BirthDate = entity.BirthDate;            
        }
    }
}
