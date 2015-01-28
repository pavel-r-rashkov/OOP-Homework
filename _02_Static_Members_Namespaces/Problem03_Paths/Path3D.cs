using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem01_Point3D;

namespace Problem03_Paths
{
    class Path3D
    {
        private List<Point3D> points;
        public List<Point3D> Points { get; set; }

        public Path3D(params Point3D[] path)
        {
            this.Points = new List<Point3D>();
            foreach(var point in path)
            {
                this.Points.Add(point);
            }
        }

    }
}
