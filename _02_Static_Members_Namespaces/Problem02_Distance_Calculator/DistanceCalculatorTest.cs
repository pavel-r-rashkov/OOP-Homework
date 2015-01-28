using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem01_Point3D;

namespace Problem02_Distance_Calculator
{
    class DistanceCalculatorTest
    {
        static void Main(string[] args)
        {
            Point3D a = new Point3D(1, 2, 3);
            Point3D b = new Point3D(4, 5, 3.5);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(DistanceCalculator.CalculateDistance(a, b));
        }
    }
}
