using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prova.Core.Model
{
    public class Label
    {
        public long Id { get; set; }
        public String Text { get; set; }
        public bool Status { get; set; }
        public long IdContent { get; set; }
    }
}