﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DAL.Model;

namespace DAL.Repositories
{
    public class PlaneTypeRepository : Repository
    {
        public virtual void Update(Guid id, PlaneType entity)
        {
            PlaneType planeTypeToUpdate = (PlaneType)data.Where(p => p.Id.Equals(id)).First();
            planeTypeToUpdate.Model = entity.Model;
            planeTypeToUpdate.Capacity = entity.Capacity;
            planeTypeToUpdate.CargoKg = entity.CargoKg;
        }
    }
}