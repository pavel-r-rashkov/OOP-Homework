using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01_Shapes
{
    class Triangle : BasicShape
    {
        private double angle;

        public double Angle
        {
            get
            {
                return this.angle;
            }
            set
            {
                if(value <= 0 || value >= 180)
                {
                    throw new ArgumentException("angle must be between 0 and 180 degrees");
                }
                else
                {
                    this.angle = value;
                }
            }
        }

        public Triangle(double width, double height, double angle)
            :base(width, height)
        {
            this.Angle = angle;
        }

        public override double CalculateSurface()
        {
            return (this.Width * this.Height) / 2;
        }

        public override double CalculatePerimeter()
        {
            double b = this.Height / Math.Sin(this.Angle);
            double c = Math.Sqrt(Math.Pow(this.Width, 2) + Math.Pow(b, 2) - 2 * this.Width * b * Math.Cos(this.Angle));
            return this.Width + b + c;
        }
    }
}
