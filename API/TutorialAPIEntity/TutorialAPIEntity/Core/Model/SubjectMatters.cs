using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TutorialAPIEntity.Core.Model
{
    public class SubjectMatters
    {
        public long Id { get; set; }
        public String Content { get; set; }
        public bool Status { get; set; }
        public virtual ICollection<Labels> Labels { get; set; }
        public virtual ICollection<Tags> Tags { get; set; }
    }
}