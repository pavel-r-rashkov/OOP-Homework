using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01_StringBuilder_Extensions
{
    public static class MyExtensionMethods
    {
        public static string Substring(this StringBuilder str, int startIndex, int length)
        {
            if(startIndex < 0 || startIndex >= str.Length || startIndex + length > str.Length)
            {
                throw new IndexOutOfRangeException("Index out of range!");
            }
            else
            {
                return str.ToString().Substring(startIndex, length);
            }
        }

        public static StringBuilder RemoveText(this StringBuilder str, string text)
        {
            str.Replace(text, "");
            return str;
        }

        public static string AppendAll<T>(this IEnumerable<T> items)
        {
            StringBuilder result = new StringBuilder();
            foreach(T item in items)
            {
                result.Append(item.ToString());
            }
            return result.ToString();
        }
    }
}
