using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prova.Core.Model
{
    public class Content
    {
        public long Id { get; set; }
        public String Text { get; set; }
        public bool Status { get; set; }
        public virtual ICollection<Label> Labels { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
    }
}