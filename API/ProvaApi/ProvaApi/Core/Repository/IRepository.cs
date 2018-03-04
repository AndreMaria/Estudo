using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ProvaApi.Core.Repository
{
    interface IRepository<T>
    {
        long Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> Find(Expression<Func<T, Boolean>> filter);
    }
}
