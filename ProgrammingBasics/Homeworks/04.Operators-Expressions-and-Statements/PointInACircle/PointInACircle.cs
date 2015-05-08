/*Write an expression that checks if given point (x,  y) is inside a circle K({0, 0}, 2).*/

using System;

namespace PointInACircle
{
    internal class PointInACircle
    {
        private static void Main(string[] args)
        {
            Console.Write("Enter a point on x axis:");
            string sx = Console.ReadLine().Replace('.', ',');
            Console.Write("Enter a point on y axis:");
            string sy = Console.ReadLine().Replace('.', ',');
            int radius = 2;
            double x = double.Parse(sx);
            double y = double.Parse(sy);

            Console.WriteLine("Is the point x {0} y {1} in the circle: {2}", x, y, check(x, y, radius));
        }

        private static bool check(double x, double y, double r)
        {
            double math = Math.Pow(x, 2) + Math.Pow(y, 2);
            double radius = Math.Pow(r, 2);
            return math < radius;
        }
    }
}