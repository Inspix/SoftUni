using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BitArray
{
    class Program
    {
        static void Main(string[] args)
        {
            BitArray ba = new BitArray(100000);
            ba[0] = 1;
            ba[3] = 1;
            ba[99999] = 1;

            Console.WriteLine(ba);
        }
    }
}
