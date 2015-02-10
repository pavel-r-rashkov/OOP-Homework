using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01_Galactic_GPS
{
    struct Location
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public Planet Planet { get; set; }

        public Location(double latitude, double longitude, Planet planet)
            :this()
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Planet = planet;
        }

        public override string ToString()
        {
            return String.Format("{0}, {1} - {2}", this.Latitude, this.Longitude, this.Planet);
        }
    }
}
