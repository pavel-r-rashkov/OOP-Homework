using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01_Galactic_GPS
{
    class GalacticGPSTest
    {
        static void Main(string[] args)
        {
            Location loc = new Location(12.2, 16.74, Planet.Earth);
            Console.WriteLine(loc);
        }
    }
}
