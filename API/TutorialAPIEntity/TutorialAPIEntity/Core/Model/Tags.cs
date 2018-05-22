using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TutorialAPIEntity.Core.Model
{
    public class Tags
    {
        public long Id { get; set; }
        public String SimpleText { get; set; }
        public String Normalized { get; set; }
        public  long  IdSubjectMatter { get; set; }
        public SubjectMatters SubjectMatter { get; set; }
    }
}