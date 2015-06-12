using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Galactic_GPS
{
    class Program
    {
        static void Main(string[] args)
        {
            Location x = new Location(3,4,Planet.Earth);
            Console.WriteLine(x);
        }
    }
}
