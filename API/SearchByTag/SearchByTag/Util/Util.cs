using SearchByTag.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace SearchByTag.Util
{
    public class Util
    {
        public static List<TagAlize> CreateTags(String input)
        {
            List<TagAlize> result = new List<TagAlize>();
            var stringNormalized = input.Normalize(NormalizationForm.FormD);
            StringBuilder sb = new StringBuilder();

            foreach (var item in stringNormalized)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(item) != UnicodeCategory.NonSpacingMark)
                    sb.Append(item);
            }

            input = sb.ToString();
            input = Regex.Replace(input, @"[^\w\s]", " ");

            result.Add(new TagAlize() { Tag = input, Normalized = input.ToUpper() });

            List<String> items = input.Split(' ').ToList();
            foreach (var item in items)
            {
                result.Add(new TagAlize() { Tag = item, Normalized = item.ToUpper() });
            }

            return result;
        }
    }
}