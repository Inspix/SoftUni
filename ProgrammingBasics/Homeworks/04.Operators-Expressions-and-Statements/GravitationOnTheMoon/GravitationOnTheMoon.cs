/* The gravitational field of the Moon is approximately 17% of that on the Earth.
 * Write a program that calculates the weight of a man on the moon by a given weight
 * on the Earth.*/

using System;
using System.Globalization;
using System.Threading;

namespace GravitationOnTheMoon
{
    internal class GravitationOnTheMoon
    {
        private static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            double weight = decPointEdit() * 0.17;
            Console.WriteLine(weight);
        }

        //Change ',' with '.' in case user input uses ',' as a decimal point to avoid problems
        private static double decPointEdit()
        {
            double x = double.Parse(Console.ReadLine().Replace(',', '.'));
            return x;
        }
    }
}