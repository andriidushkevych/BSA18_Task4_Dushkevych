using System;
using System.Collections.Generic;
using System.Text;
using DAL.Model;

namespace DAL.Repositories
{
    public interface IRepository<T> where T : Entity
    {
        List<T> FetchAll();
        T Get(Guid id);
        void Create(T entity);
        void Update(Guid entityId, T newEntity);
        void Delete(Guid id);
    }
}
