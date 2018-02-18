using System;

namespace SearchByTag.Core.Model
{
    public class Tag
    {
        public long Id { get; set; }
        public String Item { get; set; }
        public String Normalized { get; set; }
        public long IdMain { get; set; }
        public Main Main { get; set; }
    }
}