using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DAL.Model;

namespace DAL.Repositories
{
    public class StewardessRepository : Repository
    {
        public virtual void Update(Guid id, Stewardess entity)
        {
            Stewardess stewardessToUpdate = (Stewardess)data.Where(s => s.Id.Equals(id)).First();
            stewardessToUpdate.FirstName = entity.FirstName;
            stewardessToUpdate.LastName = entity.LastName;
            stewardessToUpdate.BirthDate = entity.BirthDate;
        }
    }
}
