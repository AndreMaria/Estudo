using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prova.Core.Model
{
    public class Tag
    {
        public long Id { get; set; }
        public String Common { get; set; }
        public String Normalized { get; set; }
        public long IdContent { get; set; }
        public Content Content { get; set; }
    }
}