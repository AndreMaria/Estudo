using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace SearchByTag.Core.Repository
{
    public class TagRepository : RepositoryBase<Model.Tag>
    {
        public Model.Tag Save(Model.Tag item)
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

        public Model.Tag FirstOrDefault(long id)
        {
            Expression<Func<Model.Tag, bool>> filter = x => x.Id == id;
            var result = this.Find(filter);
            return (null != result && result.Count > 0) ? result.FirstOrDefault() : null;
        }

        public List<Model.Tag> FindByText(String text)
        {
            Expression<Func<Model.Tag, bool>> filter = x => x.Item.ToUpper().Contains(text.ToUpper());
            var result = this.Find(filter);
            return (null != result && result.Count > 0) ? result : null;
        }
    }
}