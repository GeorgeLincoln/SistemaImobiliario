using System;
using System.Linq;
using SistemaImobiliario.Data.Context;
using SistemaImobiliario.Models;

namespace SistemaImobiliario.Repositories
{
         public class RepositoryBase<T> where T : class
    {
        private readonly DataContext _context;
        public RepositoryBase(DataContext context)
        {
            this._context = context;
        }
        public virtual T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }
        public virtual IQueryable<T> GetAll()
        {
            return _context.Set<T>();
        }
        public virtual T Create(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
            return entity;
        }
        public virtual void Delete(int id)
        {
            var entity = GetById(id);
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }
        public virtual void Update(T entity, int id)
        {
            var exist = _context.Set<T>().Find(id);
            _context.Entry(exist).CurrentValues.SetValues(entity);
            _context.SaveChanges();
        }



        
    }
    
}