using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace SearchByTag.Core.Repository
{
    public class LabelRepository : RepositoryBase<Model.Label>
    {
        public Model.Label Save(Model.Label item)
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

        public Model.Label FirstOrDefault(long id)
        {
            Expression<Func<Model.Label, bool>> filter = x => x.Id == id;
            var result = this.Find(filter);
            return (null != result && result.Count > 0) ? result.FirstOrDefault() : null;
        }

        public List<Model.Label> FindByText(String text)
        {
            Expression<Func<Model.Label, bool>> filter = x => x.Text.ToUpper().Contains(text.ToUpper()) || x.Category.ToUpper().Contains(text.ToUpper());
            var result = this.Find(filter);
            return (null != result && result.Count > 0) ? result : null;
        }
    }
}