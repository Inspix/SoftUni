using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace SumOfnNumbers
{
    internal class SumOfnNumbers
    {
        private static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            #region Tests

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Testing with variables from the examples!\n");
            double[] exampleOne = new double[3] { 20, 60, 10 };
            double[] exampleTwo = new double[5] { 2, -1, -0.5, 4, 2 };
            double[] exampleThree = new double[1] { 1 };

            Console.WriteLine("The sum of the 3 numbers 20,60,10 is {0}", exampleOne.Sum());
            Console.WriteLine("The sum of the 5 numbers 2,-1,-0.5,4,2 is {0}", exampleTwo.Sum());
            Console.WriteLine("The sum of the 1 number 1 is {0}", exampleThree.Sum());
            Console.WriteLine("\nTest End!\n");
            Console.ForegroundColor = ConsoleColor.White;

            #endregion Tests

            Console.Write("How many numbers do you want to sum?");
            List<double> x = getNumbers((int)getInput());
            Console.WriteLine("The sum of the numbers is:{0}", x.Sum());
        }

        private static List<double> getNumbers(int n)
        {
            List<double> numbers = new List<double>();
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Enter number #{0}", i);
                numbers.Add(getInput());
            }
            return numbers;
        }

        private static double getInput()
        {
            double number;
            do
            {
                if (Double.TryParse(Console.ReadLine().Replace(',', '.'), out number))
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