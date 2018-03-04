using Prova.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace Prova.Core.Repository
{
    public class ContentRepository: RepositoryBase<Content>
    {
        public long Save(Content entity)
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

        public Content FirstOrDefault(long id)
        {
            Expression<Func<Content, Boolean>> filter = e => e.Id == id;
            var itens = this.Find(filter);
            return null != itens && itens.Count > 0 ? itens.FirstOrDefault() : null;
        }
    }
}