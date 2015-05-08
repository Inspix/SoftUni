using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Disks
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int r = int.Parse(Console.ReadLine());
        int center = n / 2;

        for (int x = 0; x < n; x++)
        {
            for (int y = 0; y < n; y++)
            {
                if (Math.Sqrt((x - center)*(x-center) + (y-center)*(y-center)) <= r)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }

            }
            Console.WriteLine();
        }
    }
}
