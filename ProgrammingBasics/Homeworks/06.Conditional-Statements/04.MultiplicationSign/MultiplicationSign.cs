using System;
using System.Globalization;
using System.Threading;

namespace MultiplicationSign
{
    internal class MultiplicationSign
    {
        private static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            signCheck(getInput(), getInput(), getInput());
        }

        private static void signCheck(double a, double b, double c)
        {
            if (a == 0 || b == 0 || c == 0)//If any of the numbers is 0 the number is 0
            {
                Console.WriteLine(0);
            }
            else if (a < 0 && b < 0 && c < 0)//If all of the numbers are negative, the result is negative(odd number of negative numbers is always negative)
            {
                Console.WriteLine("-");
            }
            else if ((a < 0 && b < 0) || (a < 0 && c < 0) || (b < 0 && c < 0))//If 2 of the numbers are negative the result is positive (- * - = +)
            {
                Console.WriteLine("+");
            }
            else if (a < 0 || b < 0 || c < 0)//If one number is negative the result is negative
            {
                Console.WriteLine("-");
            }
            else //If none of above are met, the result is positive
            {
                Console.WriteLine("+");
            }
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