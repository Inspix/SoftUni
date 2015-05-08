/*Write an expression that calculates rectangle’s perimeter and area by given width and height.*/

using System;
using System.Globalization;
using System.Threading;

namespace Rectangles
{
    internal class Rectangles
    {
        private static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            double w = decPointEdit();
            double h = decPointEdit();

            Console.WriteLine("The perimeter of rectangle with width {0} and height {1} is {2}", w, h, w * 2 + h * 2);
            Console.WriteLine("The area of rectangle with width {0} and height {1} is {2}", w, h, w * h);
        }

        //Change ',' with '.' in case user input uses ',' as a decimal point to avoid problems
        private static double decPointEdit()
        {
            double x = double.Parse(Console.ReadLine().Replace(',', '.'));
            return x;
        }
    }
}