using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02_Fraction_Calculator
{
    class FractionTest
    {
        static void Main(string[] args)
        {
            Fraction a = new Fraction(22, 7);
            Fraction b = new Fraction(40, 4);
            Fraction result = a + b;
            Console.WriteLine(result);
        }
    }
}
