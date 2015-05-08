using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace SumOf5Numbers
{
    internal class SumOf5Numbers
    {
        private static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            #region Tests

            //Test with examples from the homework
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Testing with the example inputs from the homework!\n");
            string[] testInputs = new string[] { "1 2 3 4 5", "10 10 10 10 10", "1.5 3.14 8.2 -1 0" };

            foreach (string item in testInputs)
            {
                Console.WriteLine("Input: {0}", item);
                Console.WriteLine("The sum of the numbers is: {0}", sumCalc(checkInput(item)));
            }

            Console.WriteLine("\nTest end!\n");
            Console.ForegroundColor = ConsoleColor.White;

            #endregion Tests

            Console.WriteLine("Please enter numbers separated by space:");
            Console.WriteLine("The sum is:{0}", sumCalc(checkInput()));
        }

        /// <summary>
        /// Calculates the sum of all numbers from a list
        /// </summary>
        /// <param name="x">List with doubles</param>
        /// <returns>Returns double with the sum</returns>
        private static double sumCalc(List<double> x)
        {
            double sum = 0;
            foreach (double item in x)
            {
                sum += item;
            }
            return sum;
        }

        /// <summary>
        /// Gets input, checks if its valid and returns numbers
        /// </summary>
        /// <returns>Returns list of doubles</returns>
        private static List<double> checkInput()
        {
            double temp;
            bool check;

            List<double> numbers = new List<double>();

            do
            {
                check = false;
                string[] x = Console.ReadLine().Split(' ');
                foreach (var item in x)
                {
                    if (double.TryParse(item, out temp))
                    {
                        numbers.Add(temp);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input,try again!:\n");
                        numbers.Clear();
                        check = true;
                        break;
                    }
                }
            } while (check);
            return numbers;
        }

        /// <summary>
        /// Get numbers from string without validation
        /// </summary>
        /// <param name="str">String to extract numbers from</param>
        /// <returns>Returns list with doubles</returns>
        private static List<double> checkInput(string str)
        {
            List<double> numbers = new List<double>();
            string[] x = str.Split(' ');
            foreach (var item in x)
            {
                numbers.Add(double.Parse(item));
            }
            return numbers;
        }
    }
}