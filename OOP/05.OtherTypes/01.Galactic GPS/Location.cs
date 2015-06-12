using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Galactic_GPS
{
    struct Location
    {
        public Location(double latitude, double longitude, Planet planet)
        {
            this.Planet = planet;
            this.Latitude = latitude;
            this.Longitude = longitude;
        }

        public Planet Planet { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public override string ToString()
        {
            return string.Format("{0}, {1} - {2}", Latitude, Longitude, Planet);
        }
    }

    
    
}
