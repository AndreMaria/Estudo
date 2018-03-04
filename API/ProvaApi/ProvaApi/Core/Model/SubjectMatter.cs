using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProvaApi.Core.Model
{
    public class SubjectMatter
    {
        public long Id { get; set; }
        public String Content { get; set; }
        public Boolean Status { get; set; }
        public virtual ICollection<Label> Labels { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
    }
}