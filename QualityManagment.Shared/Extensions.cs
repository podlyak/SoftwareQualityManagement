using System;
using System.Collections.Generic;
using System.Text;

namespace QualityManagement.Shared
{
    public static class Extensions
    {
        public static string ToSimpleText<K, V>(this IDictionary<K, V> dict)
        {
            var res = new StringBuilder();
            foreach (var pair in dict)
            {
                res.AppendLine($"{pair.Key};{pair.Value}");
            }

            return res.ToString();
        }
    }
}
