using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIGeo.Model
{
    public class Principal
    {
        public long Id { get; set; }
        public String Texto { get; set; }
        public virtual ICollection<Label> Labels { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
    }
}
