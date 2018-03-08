using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace TagAlize.Util
{
    public class Util
    {
        public static List<TagAlise> CreateTagAlise(String text)
        {
            List<TagAlise> list = new List<TagAlise>();
            if (!String.IsNullOrEmpty(text))
            {
                var textNormalize = text.Normalize(NormalizationForm.FormD);
                StringBuilder sb = new StringBuilder();
                foreach (var item in textNormalize)
                {
                    if (CharUnicodeInfo.GetUnicodeCategory(item) != UnicodeCategory.NonSpacingMark)
                    {
                        sb.Append(item);
                    }
                }

                list.Add(new TagAlise() { Tag = sb.ToString().Trim(), Normalized = sb.ToString().ToUpper().Trim() });

                var arraySplit = sb.ToString().Split(' ');
                foreach (var item in arraySplit)
                {
                    list.Add(new TagAlise() { Tag = item.Trim(), Normalized = item.ToUpper().Trim() });
                }
            }
            return list;
        }
    }

    public class TagAlise
    {
        public String Tag { get; set; }
        public String Normalized { get; set; }
    }
}