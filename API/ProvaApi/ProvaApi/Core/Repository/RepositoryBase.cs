using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Entity;

namespace ProvaApi.Core.Repository
{
    public class RepositoryBase<T> : IRepository<T> where T : class
    {
        protected DbSet<T> _dbSet;
        protected TagAlizeContext context;

        public RepositoryBase()
        {
            context = new TagAlizeContext();
            _dbSet = context.Set<T>();
        }

        public long Add(T entity)
        {
            _dbSet.Add(entity);
            return context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
            context.SaveChanges();
        }

        public List<T> Find(Expression<Func<T, bool>> filter)
        {
            var itens = _dbSet.Where(filter);
            return (null != itens) ? itens.ToList() : null;

        }

        public void Update(T entity)
        {
            _dbSet.Attach(entity);
            context.SaveChanges();
        }
    }
}