using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01_Shapes
{
    class Rectangle : BasicShape
    {
        public Rectangle(double width, double height)
            :base(width, height)
        {
        }

        public override double CalculateSurface()
        {
            return this.Width * this.Height;
        }

        public override double CalculatePerimeter()
        {
            return 2 * (this.Width + this.Height);
        }
    }
}
