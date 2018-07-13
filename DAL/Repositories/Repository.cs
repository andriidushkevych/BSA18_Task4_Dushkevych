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
            entity.Id = Guid.NewGuid();
            data.Add(entity);
        }

        public T Get(Guid id)
        {
            return data.Find(d => d.Id == id);
        }

        public void Delete(Guid id)
        {
            T itemToDelete = Get(id);
            if (itemToDelete != null)
            {
                data.Remove(itemToDelete);
            }
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
