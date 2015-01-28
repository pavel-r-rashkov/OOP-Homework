using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01_Point3D
{
    class Point3DTest
    {
        static void Main(string[] args)
        {
            Point3D first = new Point3D(1, 2, 3);
            Console.WriteLine(first);
            Console.WriteLine(Point3D.StartingPoint);
        }
    }
}
