using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace APIGeo.Repository
{
    public interface IBase<T>
    {
        long Add(T entity);

        T Update(T entity);

        void Delete(T entity);

        List<T> Find(Expression<Func<T, bool>> expression);

        List<T> All();

        void Dispose();
    }
}
