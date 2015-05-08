using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace SumOf3Numbers
{
    internal class SumOf3Numbers
    {
        private static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            #region Tests

            //Test with example variables
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Tests with variables from the examples!\n");
            //Playing with tuples
            List<Tuple<double, double, double>> testVariables = new List<Tuple<double, double, double>>()
            {
                new Tuple<double, double, double>(3,4,11),
                new Tuple<double, double, double>(-2,0,3),
                new Tuple<double, double, double>(5.5,4.5,20.1)
            };

            foreach (var num in testVariables)
            {
                Console.WriteLine("The sum of {0}, {1}, {2} is: {3}", num.Item1, num.Item2, num.Item3, num.Item1 + num.Item2 + num.Item3);
            }
            Console.WriteLine("\nTest end\n");
            Console.ForegroundColor = ConsoleColor.White;

            #endregion Tests

            Console.WriteLine("Please enter 3 real numbers:");
            double numberOne = getInput();
            double numberTwo = getInput();
            double numberThree = getInput();

            Console.WriteLine("The sum of these three numbers is: {0}", numberOne + numberTwo + numberThree);
        }

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
    }
}