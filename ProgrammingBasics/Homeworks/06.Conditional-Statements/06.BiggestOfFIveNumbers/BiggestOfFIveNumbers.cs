using System;
using System.Globalization;
using System.Threading;

namespace BiggestOf3Numbers
{
    internal class BiggestOf3Numbers
    {
        private static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.Write("Biggest number is:{0}\n", checkForBiggest(5));
        }

        private static double? checkForBiggest(int x)//Method for checking x amount of numbers
        {
            double? biggest = null; //Must be null instead of 0 because we will check negative numbers too
            double number;
            for (int i = 0; i < x; i++)
            {
                number = getInput();
                if (biggest.HasValue)//If there is a number in the "biggest" variable perform a check
                {
                    if (number > biggest) { biggest = number; }
                }
                else
                {
                    biggest = number;//Set a starting number for the "biggest" variable
                }
            }
            return biggest;
        }

        //Valid input check
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