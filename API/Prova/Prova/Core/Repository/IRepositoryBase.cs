using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Linq.Expressions;

namespace Prova.Core.Repository
{
    public interface IRepositoryBase<T>
    {
        long Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> Find(Expression<Func<T, Boolean>> filter);
    }
}