using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DAL.Model;

namespace DAL.Repositories
{
    public class Repository : IRepository
    {
        DataSource ds;
        public List<Entity> data;

        public Repository()
        {
            ds = new DataSource();
            data = (List<Entity>)ds.Data[typeof(Entity)];
        }

        public void Create(Entity entity)
        {
            data.Add(entity);
        }

        public void Delete(Guid id)
        {
            data.Remove(data.Where(d => d.Id == id).First());
        }

        public List<Entity> FetchAll()
        {
            return data;
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public virtual void Update(Guid entityId, Entity newEntity)
        {
            throw new NotImplementedException();
        }
    }
}
