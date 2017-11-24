using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Core
{
    public interface IRepository<T>
    {
        T Add(T entity);

        T Update(T entity);

        void Delete(T entity);

        T FirstOrDefault(Expression<Func<T, bool>> expression);

        List<T> Find(Expression<Func<T, bool>> expression);
    }
}
