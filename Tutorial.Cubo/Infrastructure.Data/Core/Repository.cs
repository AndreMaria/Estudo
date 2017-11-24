using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq.Expressions;
using Infrastructure.Data.Contexts;

namespace Infrastructure.Data.Core
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly IDbSet<T> _dbset;
        public Repository()
        {

            this.DataBaseFactory = new TutorialContext();
            this._dbset = DataBaseFactory.Set<T>();
        }

        protected TutorialContext DataBaseFactory
        {
            get;
            private set;
        }

        public T Add(T entity)
        {
            try
            {
                var item = this._dbset.Add(entity);
                DataBaseFactory.SaveChanges();
                return item;
            }
            catch (DbEntityValidationException erros)
            {
                foreach (var erro in erros.EntityValidationErrors)
                {
                    foreach (var itemErro in erro.ValidationErrors)
                    {

                    }
                }
                throw;
            }
        }

        public T Update(T entity)
        {
            try
            {
                var item = this._dbset.Attach(entity);
                DataBaseFactory.SaveChanges();
                return item;
            }
            catch (DbEntityValidationException erros)
            {
                foreach (var erro in erros.EntityValidationErrors)
                {
                    foreach (var itemErro in erro.ValidationErrors)
                    {

                    }
                }
                throw;
            }
        }

        public void Delete(T entity)
        {
            try
            {
                var item = this._dbset.Remove(entity);
                DataBaseFactory.SaveChanges();
            }
            catch (DbEntityValidationException erros)
            {
                foreach (var erro in erros.EntityValidationErrors)
                {
                    foreach (var itemErro in erro.ValidationErrors)
                    {

                    }
                }
                throw;
            }
        }

        public T FirstOrDefault(Expression<Func<T, bool>> expression)
        {
            try
            {
                return this._dbset.Where(expression).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public List<T> Find(Expression<Func<T, bool>> expression)
        {
            return this._dbset.Where(expression).ToList();
        }

        public List<T> FindAll()
        {
            return _dbset.ToList();
        }
    }
}
