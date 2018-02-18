using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace SearchByTag.Core.Repository
{
    public class MainRepository: RepositoryBase<Model.Main>
    {
        public Model.Main Save(Model.Main item)
        {
            if (item.Id > 0)
            {
                this.Update(item);
            }
            else
            {
                var id = this.Add(item);
                item.Id = id;
            }
            return item;
        }

        public Model.Main FirstOrDefault(long id)
        {
            Expression<Func<Model.Main, bool>> filter = x => x.Id == id;
            var result = this.Find(filter);
            return (null != result && result.Count > 0) ? result.FirstOrDefault() : null;
        }

        public List<Model.Main> FindByText(String text)
        {
            Expression<Func<Model.Main, bool>> filter = x => x.Text.ToUpper().Contains(text.ToUpper());
            var result = this.Find(filter);
            return (null != result && result.Count > 0) ? result : null;
        }
    }
}