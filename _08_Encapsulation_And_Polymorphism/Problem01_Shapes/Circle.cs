﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01_Shapes
{
    class Circle : IShape
    {
        private double radius;

        public double Radius
        {
            get
            {
                return this.radius;
            }
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentException("Radius can't be negative or 0");
                }
                else
                {
                    this.radius = value;
                }
            }
        }

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double CalculateSurface()
        {
            return Math.PI * Math.Pow(this.Radius, 2);
        }

        public double CalculatePerimeter()
        {
            return 2 * Math.PI * this.Radius;
        }
    }
}
