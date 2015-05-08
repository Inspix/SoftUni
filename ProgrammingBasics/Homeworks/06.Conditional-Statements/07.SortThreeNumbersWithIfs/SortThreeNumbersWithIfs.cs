using System;
using System.Globalization;
using System.Threading;

namespace SortThreeNumbersWithIfs
{
    internal class SortThreeNumbersWithIfs
    {
        private static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            sort3withIfsOnly(getInput(), getInput(), getInput());
        }

        private static void sort3withIfsOnly(double a, double b, double c) //Sort 3 numbers using nested If statements
        {
            if (a > b)
            {
                if (a > c)
                {
                    if (b > c)
                    {
                        Console.WriteLine("{0},{1},{2}", a, b, c);
                    }
                    else
                    {
                        Console.WriteLine("{0},{1},{2}", a, c, b);
                    }
                }
                else
                {
                    Console.WriteLine("{0},{1},{2}", c, a, b);
                }
            }
            else if (b > c)
            {
                if (a > c)
                {
                    Console.WriteLine("{0},{1},{2}", b, a, c);
                }
                else
                {
                    Console.WriteLine("{0},{1},{2}", b, c, a);
                }
            }
            else
            {
                Console.WriteLine("{0},{1},{2}", c, b, a);
            }
        }

        //Validate input
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