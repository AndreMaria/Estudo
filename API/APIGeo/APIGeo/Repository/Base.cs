using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Data.SqlClient;

namespace APIGeo.Repository
{
    public class Base<T> : IBase<T> where T : class
    {
        private readonly IDbSet<T> _dbSet;
        private GeoContext _dataContext;

        public Base()
        {
            _dataContext = new GeoContext();
            _dbSet = _dataContext.Set<T>();
        }

        public long Add(T entity)
        {
            _dbSet.Add(entity);
            return _dataContext.SaveChanges();
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public List<T> Find(Expression<Func<T, bool>> expression)
        {
            return _dbSet.Where(expression).ToList();
        }


        public List<T> All()
        {
            return _dbSet.ToList();
        }

        public T Update(T entity)
        {
            _dbSet.Attach(entity);
            _dataContext.Entry(entity).State = EntityState.Modified;
            return entity;
        }

        public IEnumerable<T> ExecProcedure(string queryProc,Dictionary<string,string> param)
        {
            IEnumerable<T> list = null;
            using (var context = new GeoContext())
            {
                List<SqlParameter> listPar = new List<SqlParameter>();
                foreach (var item in param)
                {
                    listPar.Add(new SqlParameter(item.Key, item.Value));
                }

                list = context.Database.SqlQuery<T>(queryProc, listPar.ToArray()).ToList();
            }
            return list;
        }

        public void Dispose()
        {
            if (_dataContext != null)
                _dataContext.Dispose();
        }
    }
}
