using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIGeo.Model
{
    public class Tag
    {
        public long Id { get; set; }
        public String TagTexto { get; set; }
        public String TagNormalized { get; set; }
        public long IdPrincipal { get; set; }
        public virtual Principal Principal { get; set; }
    }
}
