using System;
using System.Data.Entity;

namespace Common
{
    public class DatabaseFactory<U> : IDatabaseFactory<U>
    {
        private Context<U> _dataContext;

        public void Dispose()
        {
            if (null != this._dataContext) {
                _dataContext.Dispose();
            }
        }

        public Context<U> GetContext()
        {
            return this._dataContext ?? (_dataContext = new Context<U>());
        }
    }
}
