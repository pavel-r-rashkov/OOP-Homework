using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02_LINQ_Extensions
{
    class LINQExtensionsTest
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 2, 6, 3, 10, 2, 7 };
            var numbersWhereNot = numbers.WhereNot(x => x == 2);
            Console.WriteLine(String.Join(", ", numbersWhereNot));
            Console.WriteLine("===============================");

            StringBuilder testBuilder = new StringBuilder("asdf jdipeshow djiqpeshowqij jdiq jipeshodqw");
            testBuilder.RemoveText("peSho");
            Console.WriteLine(testBuilder);
            Console.WriteLine("===============================");

            List<string> words = new List<string>() { "pesho", "gosho", "sasho", "ivan", "petkan"};
            List<string> suffixes = new List<string>() { "an" };
            var filteredWords = words.WhereEndsWith(suffixes);
            Console.WriteLine(String.Join(", ", filteredWords));
            Console.WriteLine("===============================");
        }
    }
}
