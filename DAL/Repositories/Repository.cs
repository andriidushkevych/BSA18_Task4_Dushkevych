using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DAL.Model;
using Microsoft.EntityFrameworkCore;
using DAL.DB;


namespace DAL.Repositories
{
    public class Repository<T> : IRepository<T> where T :Entity
    {
        private readonly AirportContext _ctx;
        private DbSet<T> _dbSet;

        public Repository(AirportContext ctx)
        {
            _ctx = ctx;
            _dbSet = _ctx.Set<T>();
        }

        public void Create(T entity)
        {
            _dbSet.Add(entity);
        }

        public void Delete(Guid id)
        {
            T existing = GetById(id);
            if (existing != null) _dbSet.Remove(existing);
        }

        public List<T> FetchAll()
        {
            return _dbSet.ToList();
        }

        public T GetById(Guid id)
        {
            return _dbSet.SingleOrDefault(entity => entity.Id == id);
        }

        public void Update(T entity)
        {
            _ctx.Entry(entity).State = EntityState.Modified;
            _dbSet.Attach(entity);
        }

        public void SaveChanges()
        {
            _ctx.SaveChanges();
        }
    }
}
