using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProvaApi.Core.Model
{
    public class Label
    {
        public long Id { get; set; }
        public String Title { get; set; }
        public long IdSubjectMatter { get; set; }
        public SubjectMatter SubjectMatter { get; set; }
    }
}