using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Sinema.Model;

namespace Sinema.Repository
{
    public class Repo<T> : IRepo<T> where T : class
    {
        private readonly ModelSinema _context;
        private readonly DbSet<T> _dbSet;
        public Repo()
        {
            _context = new ModelSinema();
            _dbSet = _context.Set<T>();
        }
        public bool DeleteEntity(int id)
        {
            _dbSet.Remove(GetEntityById(id));

            if (_context.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }
        public void Dispose()
        {
            _context.Dispose();
        }

        public IQueryable<T> GetAllEntities()
        {
            return _dbSet;
        }
        public T GetEntityById(int id)
        {
            return _dbSet.Find(id);
        }
        public bool InsertEntity(T entity)
        {
            _dbSet.Add(entity);
            if (_context.SaveChanges()>0)
            {
                return true;
            }
            return false;
            
        }
        public bool UpdateEntity(T entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            if (_context.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }
    }
}