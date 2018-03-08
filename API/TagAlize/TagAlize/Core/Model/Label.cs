using System;

namespace TagAlize.Core.Model
{
    public class Label
    {
        public long Id { get; set; }
        public String Title { get; set; }
        public long IdSubjectMatter { get; set; }
        public SubjectMatter SubjectMatter { get; set; }
    }
}