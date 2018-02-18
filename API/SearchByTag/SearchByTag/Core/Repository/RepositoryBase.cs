using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SearchByTag.Core.Repository
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private readonly IDbSet<T> _dbSet;
        private SearchByTagContext dataContext;

        public RepositoryBase()
        {
            dataContext = new SearchByTagContext();
            _dbSet = dataContext.Set<T>();
        }

        public long Add(T entity)
        {
            _dbSet.Add(entity);
            return dataContext.SaveChanges();
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
            dataContext.SaveChanges();
        }

        public List<T> Find(System.Linq.Expressions.Expression<Func<T, bool>> filter)
        {
            return _dbSet.Where(filter).ToList();
        }

        public List<T> FindAll()
        {
            return _dbSet.ToList();
        }

        public T Update(T entity)
        {
            _dbSet.Attach(entity);
            dataContext.SaveChanges();
            return entity;
        }
    }
}