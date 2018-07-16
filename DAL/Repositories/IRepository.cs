using System;
using System.Collections.Generic;
using System.Text;
using DAL.Model;

namespace DAL.Repositories
{
    public interface IRepository<T> where T : Entity
    {
        List<T> FetchAll();
        T GetById(Guid id);
        void Create(T entity);
        void Update(T entity);
        void Delete(Guid id);
        void SaveChanges();
    }
}
