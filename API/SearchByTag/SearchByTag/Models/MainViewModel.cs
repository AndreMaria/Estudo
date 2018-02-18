using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SearchByTag.Models
{
    public class MainViewModel
    {
        public string text { get; set; }
        public List<LabelViewModel> labels { get; set; }
        public List<TagViewModel> tags { get; set; }
    }

    public class LabelViewModel
    {
        public string text { get; set; }
        public string category { get; set; }
    }

    public class TagViewModel
    {
        public string item { get; set; }
        public string normalized { get; set; }
    }
}