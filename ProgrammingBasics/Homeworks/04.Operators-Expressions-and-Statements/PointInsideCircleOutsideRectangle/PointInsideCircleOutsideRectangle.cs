/*Write an expression that checks for given point (x, y)
 * if it is within the circle K({1, 1}, 1.5) and out of the
 * rectangle R(top=1, left=-1, width=6, height=2).*/

using System;
using System.Globalization;
using System.Threading;

namespace PointInsideCircleOutsideRectangle
{
    internal class PointInsideCircleOutsideRectangle
    {
        private static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            double x = decPointEdit();
            double y = decPointEdit();
            double radius = 1.5;
            Console.WriteLine(check(x, y, radius) && checkRect(x, y) ? "Yes" : "No");
        }

        //Change ',' with '.' in case user input uses ',' as a decimal point to avoid problems
        private static double decPointEdit()
        {
            double x = double.Parse(Console.ReadLine().Replace(',', '.'));
            return x;
        }

        private static bool check(double x, double y, double r)
        {
            double math = Math.Pow(x - 1, 2) + Math.Pow(y - 1, 2);
            double radius = Math.Pow(r, 2);
            return math <= radius;
        }

        private static bool checkRect(double x, double y)
        {
            return (x < -1 || x > 5) || (y < -1 || y > 1) ? true : false;
        }
    }
}