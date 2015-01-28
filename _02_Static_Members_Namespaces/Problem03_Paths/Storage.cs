using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem01_Point3D;

namespace Problem03_Paths
{
    static class Storage
    {
        public static void SavePath(Path3D path, string filePath)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(filePath))
            {
                foreach (var point in path.Points)
                {
                    file.WriteLine(point.ToString());
                }
            }
        }

        public static Path3D LoadPath(string path)
        {
            List<Point3D> points = new List<Point3D>();
            string[] lines = System.IO.File.ReadAllLines(path);
            foreach(string line in lines)
            {
                string[] tokens = line.Split(new string[] {"|", " ", "{", "}"}, StringSplitOptions.RemoveEmptyEntries);
                points.Add(new Point3D(int.Parse(tokens[0]), int.Parse(tokens[1]), int.Parse(tokens[2])));
            }

            return new Path3D(points.ToArray());
        }
    }
}
