using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIGeo.Model
{
    public class Label
    {
        public long Id { get; set; }
        public String Texto { get; set; }
        public String Category { get; set; }
        public long IdPrincipal { get; set; }
        public virtual Principal Principal { get; set; }
    }
}
