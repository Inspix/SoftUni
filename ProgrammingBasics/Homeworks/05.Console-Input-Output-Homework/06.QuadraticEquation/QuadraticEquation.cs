using System;
using System.Globalization;
using System.Threading;

namespace QuadraticEquation
{
    internal class QuadraticEquation
    {
        private static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Tuple<double, double> roots;

            #region Tests

            //Test from homework examples
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Test with the variables from the examples!\n");
            double[] testA = new double[] { 2, -1, -0.5, 5 };
            double[] testB = new double[] { 5, 3, 4, 2 };
            double[] testC = new double[] { -3, 0, -8, 8 };

            for (int i = 0; i <= testA.GetUpperBound(0); i++)
            {
                roots = getRoots(testA[i], testB[i], testC[i]);
                Console.WriteLine("Quadratic equation with coefficients {0,-3},{1,-3},{2,-3}\n{5,37}x1={3,3} , x2={4}\n", testA[i], testB[i], testC[i], roots.Item1, roots.Item2, "The roots are: ");
            }
            Console.WriteLine("\nTest end!\n");
            Console.ForegroundColor = ConsoleColor.White;

            #endregion Tests

            Console.WriteLine("Please enter 3 coefficients for the quadratic equation:");
            double a = getInput();
            double b = getInput();
            double c = getInput();

            roots = getRoots(a, b, c);

            Console.WriteLine("Quadratic equation with coefficients {0,-3},{1,-3},{2,-3}\n{5,37}x1={3,3} , x2={4}\n", a, b, c, roots.Item1, roots.Item2, "The roots are: ");
        }

        //Get double input with a check
        private static double getInput()
        {
            double number;
            do
            {
                if (double.TryParse(Console.ReadLine().Replace(',', '.'), out number))
                {
                    break;
                }
                else
                {
                    Console.Write("Invalid input,try again: ");
                }
            } while (true);
            return number;
        }

        /// <summary>
        /// Solves a quadratic equation given 3 numbers
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        /// <param name="c">Third number</param>
        /// <returns>Returns Tuple with the 2 results</returns>
        private static Tuple<double, double> getRoots(double a, double b, double c)
        {
            c = Math.Sqrt((b * b) - (4 * a * c));
            a = 2 * a;
            return new Tuple<double, double>((-b - c) / a, (-b + c) / a);
        }
    }
}