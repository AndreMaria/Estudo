using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProvaApi.Core.Model
{
    public class Tag
    {
        public long Id { get; set; }
        public String SimpleText { get; set; }
        public String Normalized { get; set; }
        public long IdSubjectMatter { get; set; }
        public SubjectMatter SubjectMatter { get; set; }
    }
}