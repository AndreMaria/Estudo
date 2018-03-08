using System;
using System.Collections.Generic;

namespace TagAlize.Models
{
    public class SubjectMatterViewModel
    {
        public String Content { get; set; }
        public String Label { get; set; }
        public List<String> Tags { get; set; }
    }
}