﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DAL.Model;

namespace DAL.Repositories
{
    public class PlaneRepository : Repository
    {
        public virtual void Update(Guid id, Plane entity)
        {
            Plane planeToUpdate = (Plane)data.Where(p => p.Id.Equals(id)).First();
            planeToUpdate.Name = entity.Name;
            planeToUpdate.PlaneType = entity.PlaneType;
            planeToUpdate.ManufactureDate = entity.ManufactureDate;
            planeToUpdate.LifeTimeDate = entity.LifeTimeDate;
            planeToUpdate.Timespan = entity.Timespan;
        }
    }
}