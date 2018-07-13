using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DAL.Model;


namespace DAL.Repositories
{
    public class Repository<T> : IRepository<T> where T :Entity
    {
        DataSource ds;
        public List<T> data;
        
        public Repository()
        {
            ds = new DataSource();
            data = (List<T>)ds.Data[typeof(T)];
        }

        public void Create(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            data.Add(entity);
        }

        public T Get(Guid id)
        {
            return data.Where(d => d.Id == id).First();
        }

        public void Delete(Guid id)
        {
            data.Remove(data.Where(d => d.Id == id).First());
        }

        public List<T> FetchAll()
        {
            return data;
        }

        public virtual void Update(Guid entityId, T newEntity)
        {
            throw new NotImplementedException();
        }
    }
}
