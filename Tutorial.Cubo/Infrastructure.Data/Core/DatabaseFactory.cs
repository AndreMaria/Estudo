using Infrastructure.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Core
{
    public class DatabaseFactory<U> : IDatabaseFactory
    {
        private TutorialContext _dataContext;

        public void Dispose()
        {
            if (null != this._dataContext)
            {
                _dataContext.Dispose();
            }
        }

        public TutorialContext GetContext()
        {
            return this._dataContext ?? (_dataContext = new TutorialContext());
        }
    }
}
