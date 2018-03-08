using System;

namespace TagAlize.Core.Model
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