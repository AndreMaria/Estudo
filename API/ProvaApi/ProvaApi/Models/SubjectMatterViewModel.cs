using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProvaApi.Models
{
    public class SubjectMatterViewModel
    {
        public String Content { get; set; }
        public String Label { get; set; }
        public List<String> Tags { get; set; }
    }
}