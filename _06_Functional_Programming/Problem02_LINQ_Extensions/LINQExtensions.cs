using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem02_LINQ_Extensions
{
    static class LINQExtensions
    {
        public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Func<T, bool> predicate) 
        {
            return collection.Where(item => !predicate(item));
        }
 
        public static void RemoveText(this StringBuilder stringBuilder, string text)
        {
            string replacedString = Regex.Replace(stringBuilder.ToString(), text, "", RegexOptions.IgnoreCase);
            stringBuilder.Replace(stringBuilder.ToString(), replacedString); 
        }

        public static IEnumerable<string> WhereEndsWith(this IEnumerable<string> collection, IEnumerable<string> suffixes) 
        {
            return collection.Where(item => suffixes.Any(suffix => item.EndsWith(suffix, StringComparison.InvariantCultureIgnoreCase)));
        }
    }
}
