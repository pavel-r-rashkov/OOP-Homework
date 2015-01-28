using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01_Point3D
{
    public class Point3D
    {
        private double x;
        private double y;
        private double z;

        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        private static readonly Point3D startingPoint = new Point3D(0, 0, 0);
        public static Point3D StartingPoint 
        {
            get { return startingPoint; }
        }

        public Point3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public override string ToString()
        {
            return String.Format("{{{0} | {1} | {2}}}", this.X, this.Y, this.Z);
        }
    }
}
