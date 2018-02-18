using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace SearchByTag.Core.Repository
{
    public interface IRepositoryBase<T>
    {
        long Add(T entity);
        T Update(T entity);
        void Delete(T entity);
        List<T> Find(Expression<Func<T, bool>> filter);
        List<T> FindAll();
    }
}
