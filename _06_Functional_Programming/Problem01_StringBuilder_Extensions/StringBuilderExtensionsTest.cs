using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Problem01_StringBuilder_Extensions
{
    class StringBuilderExtensionsTest
    {
        static void Main(string[] args)
        {
            StringBuilder a = new StringBuilder("abcde");
            Console.WriteLine(a.Substring(1, 2));

            a.RemoveText("d");
            Console.WriteLine(a);

            int[] b = new int[] {1, 2, 3, 4, 5};
            Console.WriteLine(b.AppendAll());
        }
    }
}
