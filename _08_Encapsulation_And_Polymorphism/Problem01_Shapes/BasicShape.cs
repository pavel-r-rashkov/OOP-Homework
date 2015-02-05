using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01_Shapes
{
    abstract class BasicShape : IShape
    {
        protected double width;
        protected double height;

        public double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentException("Width can't be negative or 0");
                }
                else
                {
                    this.width = value;
                }
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height can't be negative or 0");
                }
                else
                {
                    this.height = value;
                }
            }
        }

        public BasicShape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public abstract double CalculateSurface();
        public abstract double CalculatePerimeter();
    }
}
