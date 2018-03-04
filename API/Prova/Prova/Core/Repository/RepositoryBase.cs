using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Linq.Expressions;

namespace Prova.Core.Repository
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected IDbSet<T> _dbSet;
        protected TagAlizeContext _context;

        public RepositoryBase()
        {
            _context = new TagAlizeContext();
            _dbSet = _context.Set<T>();
        }

        public long Add(T entity)
        {
            _dbSet.Add(entity);
            return _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
            _context.SaveChanges();
        }

        public List<T> Find(Expression<Func<T, bool>> filter)
        {
            return _dbSet.Where(filter).ToList();
        }

        public void Update(T entity)
        {
            _dbSet.Attach(entity);
            _context.SaveChanges();
        }
    }
}