using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIGeo.Model;

namespace APIGeo.Repository
{
    public class TagRepository : Base<Tag>
    {
        public Tag Save(Tag tag)
        {
            if (tag.Id == 0)
                tag.Id = this.Add(tag);
            else
                this.Update(tag);
            return tag;
        }
    }
}
