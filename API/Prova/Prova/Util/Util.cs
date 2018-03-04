using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using Prova.Models;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Prova.Util
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