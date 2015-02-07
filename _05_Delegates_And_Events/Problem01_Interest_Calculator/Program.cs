using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01_Interest_Calculator
{
    public class Program
    {
        public static void Main()
        {
            InterestCalculator test = new InterestCalculator(1000M, 0.07M, 5, InterestCalculator.GetSimpleInterest);
            Console.WriteLine(test.Calculate());
        }
    }

}
