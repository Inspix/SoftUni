/*Write an expression that calculates trapezoid's area by given sides a and b and height h. */

using System;
using System.Globalization;
using System.Threading;

namespace Trapezoids
{
    internal class Trapezoids
    {
        private static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            double a = decPointEdit();
            double b = decPointEdit();
            double h = decPointEdit();
            Console.WriteLine(trapezoidArea(a, b, h));
        }

        //Change ',' with '.' in case user input uses ',' as a decimal point to avoid problems
        private static double decPointEdit()
        {
            double x = double.Parse(Console.ReadLine().Replace(',', '.'));
            return x;
        }

        private static double trapezoidArea(double a, double b, double h)
        {
            double result = h * ((a + b) / (double)2);
            return result;
        }
    }
}