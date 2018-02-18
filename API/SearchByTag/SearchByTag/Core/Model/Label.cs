using System;

namespace SearchByTag.Core.Model
{
    public class Label
    {
        public long Id { get; set; }
        public String Text { get; set; }
        public String Category { get; set; }
        public long IdMain { get; set; }
        public virtual Main Main { get; set; }
    }
}