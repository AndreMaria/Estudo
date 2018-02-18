using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIGeo.Model
{
    public class SearchResult
    {
        public int Id { get; set; }
        public int ExactRelevance { get; set; }
        public int EqualRelevance { get; set; }
        public int LikeRelevance { get; set; }
        public String Text { get; set; }
        public String Category { get; set; }
    }
}
