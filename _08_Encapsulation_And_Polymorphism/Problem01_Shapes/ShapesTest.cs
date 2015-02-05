using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01_Shapes
{
    class ShapesTest
    {
        static void Main(string[] args)
        {
            List<IShape> shapes = new List<IShape>{
                new Rectangle(7, 4),
                new Triangle(7, 4, 30),
                new Circle(3)
            };

            foreach(var shape in shapes)
            {
                Console.WriteLine("========");
                Console.WriteLine(shape.CalculateSurface() + "\n" + shape.CalculatePerimeter());
                Console.WriteLine("========");
            }
        }
    }
}
