using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem01_Point3D;

namespace Problem02_Distance_Calculator
{
    static class DistanceCalculator
    {
        public static double CalculateDistance(Point3D startPoint, Point3D endPoint)
        {
            return Math.Sqrt(Math.Pow(endPoint.X - startPoint.X, 2) + Math.Pow(endPoint.Y - startPoint.Y, 2)
                + Math.Pow(endPoint.Z - startPoint.Z, 2));
        }
    }
}
