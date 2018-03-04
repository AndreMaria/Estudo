using Prova.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace Prova.Core.Repository
{
    public class LabelRepository : RepositoryBase<Label>
    {
        public long Save(Label entity)
        {
            if (entity.Id == 0)
            {
                return this.Add(entity);
            }
            else
            {
                this.Update(entity);
                return entity.Id;
            }
        }

        public Label FirstOrDefault(long id)
        {
            Expression<Func<Label, Boolean>> filter = e => e.Id == id;
            var itens = this.Find(filter);
            return null != itens && itens.Count > 0 ? itens.FirstOrDefault() : null;
        }
    }
}