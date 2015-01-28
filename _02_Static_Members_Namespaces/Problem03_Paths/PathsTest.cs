using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem01_Point3D;

namespace Problem03_Paths
{
    class PathsTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter file path"); // e.g C:\Users\ASUS\Desktop\WritePath.txt
            string filePath = Console.ReadLine();

            Path3D savePath = new Path3D(new Point3D(1, 2, 3), new Point3D(4, 5, 2), new Point3D(7, 5, 6));
            Storage.SavePath(savePath, filePath);

            Path3D loadPath = Storage.LoadPath(filePath);
            
            foreach(var point in loadPath.Points)
            {
                Console.WriteLine(point);
            }
        }
    }
}
