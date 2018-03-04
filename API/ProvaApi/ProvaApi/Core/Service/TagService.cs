using System;
using System.Collections.Generic;
using System.Linq;
using ProvaApi.Core.Repository;
using ProvaApi.Core.Model;


namespace ProvaApi.Core.Service
{
    public class TagService : RepositoryBase<Tag>
    {
        public long Save(Tag entity)
        {
            long id = 0;
            if (entity.Id == 0)
            {
                id = this.Add(entity);
            }
            else
            {
                this.Update(entity);
                id = entity.Id;
            }

            return id;
        }

        public void Remove(long id)
        {
            var item = FirstOrDefault(id);
            if (null != item)
            {
                this.Delete(item);
            }
        }

        public void Remove(Tag entity)
        {
            this.Delete(entity);
        }

        public Tag FirstOrDefault(long id)
        {
            Tag item = null;
            var itens = Find(x => x.Id == id);
            if (null != itens && itens.Count > 0)
            {
                item = itens.FirstOrDefault();
            }
            return item;
        }

        public List<Tag> FindByText(String text)
        {
            return Find(x => x.Normalized.Contains(text.ToUpper()));
        }
    }
}