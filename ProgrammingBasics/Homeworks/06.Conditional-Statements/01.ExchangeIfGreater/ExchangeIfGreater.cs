using System;
using System.Globalization;
using System.Threading;

namespace ExchangeIfGreater
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            double a = getInput();
            double b = getInput();
            double temp;

            if (a > b) // if a is greater than b, change places
            {
                temp = a;
                a = b;
                b = temp;
                Console.WriteLine("{0} {1}", a, b);
            }
            else //else just print them
            {
                Console.WriteLine("{0} {1}", a, b);
            }
        }

        //Check for valid input;
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