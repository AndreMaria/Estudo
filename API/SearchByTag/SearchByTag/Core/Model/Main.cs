using System;
using System.Collections.Generic;

namespace SearchByTag.Core.Model
{
    public class Main
    {
        public long Id { get; set; }
        public String Text { get; set; }
        public virtual ICollection<Label> Labels { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
    }
}