using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01_Persons
{
    class PersonsTest
    {
        static void Main(string[] args)
        {
            Person gosho = new Person("Gosho", 12, "A@");
            Person pesho = new Person("Pesho", 14);

            Console.WriteLine(gosho.ToString());
            Console.WriteLine(pesho.ToString());
        }
    }
}
