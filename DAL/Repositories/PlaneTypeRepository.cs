using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DAL.Model;

namespace DAL.Repositories
{
    public class PlaneTypeRepository : Repository<PlaneType>
    {
        public override void Update(Guid id, PlaneType entity)
        {
            PlaneType planeTypeToUpdate = Get(id);
            planeTypeToUpdate.Model = entity.Model;
            planeTypeToUpdate.Capacity = entity.Capacity;
            planeTypeToUpdate.CargoKg = entity.CargoKg;
        }
    }
}
