using System;
using System.Collections.Generic;
using System.Text;
using DAL.Model;

namespace DAL.Repositories
{
    public interface IRepository
    {
        List<Entity> FetchAll();
        void Create(Entity entity);
        void Update(Guid entityId, Entity newEntity);
        void Delete(Guid id);
        void Save();
    }
}
