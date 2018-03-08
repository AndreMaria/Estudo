using System;
using System.Collections.Generic;

namespace TagAlize.Models
{
    public class Response<T>
    {
        public String Message { get; set; }
        public T Item { get; set; }
        public List<T> Items { get; set; }
    }
}