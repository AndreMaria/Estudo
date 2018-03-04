using System;
using System.Collections.Generic;
using System.Linq;
using ProvaApi.Core.Repository;
using ProvaApi.Core.Model;

namespace ProvaApi.Core.Service
{
    public class SubjectMatterService: RepositoryBase<SubjectMatter>
    {
        private LabelService labelService;
        private TagService tagService;

        public long Save(SubjectMatter entity)
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
                if (null != item.Labels && item.Labels.Count > 0)
                {
                    labelService = new LabelService();
                    foreach (var label in item.Labels)
                    {
                        labelService.Remove(label);
                    }
                }

                if (null != item.Tags && item.Tags.Count > 0)
                {
                    tagService = new TagService();
                    foreach (var tag in item.Tags)
                    {
                        tagService.Remove(tag);
                    }
                }

                this.Delete(item);
            }
        }

        public SubjectMatter FirstOrDefault(long id)
        {
            SubjectMatter item = null;
            var itens = Find(x => x.Id == id);
            if (null != itens && itens.Count > 0)
            {
                item = itens.FirstOrDefault();
            }
            return item;
        }

        public List<SubjectMatter> FindByText(String text)
        {
            return Find(x => x.Content.ToUpper().Contains(text.ToUpper()));
        }
    }
}