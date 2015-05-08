using System;
using System.Globalization;
using System.Threading;

namespace FormatingNumbers
{
    internal class FormatingNumbers
    {
        private static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            #region Tests

            //Tests from homework examples
            int[] testInts = new int[] { 254, 499, 0 };
            double[] testDoubleA = new double[] { 11.6, -0.5559, 3 };
            double[] testDoubleB = new double[] { 0.5, 10000, -0.1234 };

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Test!\n");

            for (int i = 0; i <= testInts.GetUpperBound(0); i++)
            {
                Console.WriteLine("|{0,-10}|{1}|{2,10}|{3,-10}|", getHex(testInts[i]), getBinary(testInts[i]), decimalCheck(testDoubleA[i], 2), decimalCheck(testDoubleB[i], 3));
            }

            Console.WriteLine("\nTest end!");
            Console.ForegroundColor = ConsoleColor.White;

            #endregion Tests

            int a = getIntInput();
            double b = getDoubleInput(2);
            double c = getDoubleInput(3);

            Console.WriteLine("|{0,-10}|{1}|{2,10}|{3,-10}|", getHex(a), getBinary(a), decimalCheck(b, 2), decimalCheck(c, 3));
        }

        //Get integer input with a check
        private static int getIntInput()
        {
            int number;
            do
            {
                if (int.TryParse(Console.ReadLine(), out number))
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
        /// Get double input with a check and rounding
        /// </summary>
        /// <param name="digits">Digits to round to</param>
        /// <returns>Returns rounded double</returns>
        private static double getDoubleInput(int digits)
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
            return Math.Round(number, digits);
        }

        /// <summary>
        /// Convert given integer to its binary representation
        /// </summary>
        /// <param name="x">integer to convert</param>
        /// <returns>Returns binary string</returns>
        private static string getBinary(int x)
        {
            return Convert.ToString(x, 2).PadLeft(10, '0');
        }

        /// <summary>
        /// Convert given integer to its hexadecimal representation
        /// </summary>
        /// <param name="x">Integer to convert</param>
        /// <returns>Returns Hex string</returns>
        private static string getHex(int x)
        {
            return Convert.ToString(x, 16).ToUpper();
        }

        /// <summary>
        /// Check if given double has decimal point
        /// </summary>
        /// <param name="x">double to check</param>
        /// <param name="points">amount of numbers after the decimal point</param>
        /// <returns>Returns whole number or adds zeros when needed</returns>
        private static string decimalCheck(double x, int points)
        {
            string strToCheck = string.Format("{0:0.00}", x);

            if (strToCheck.Contains(".00"))
            {
                return strToCheck.Remove(strToCheck.IndexOf('.'));
            }
            if (points == 3)
            {
                return string.Format("{0:0.000}", x);
            }

            return strToCheck;
        }
    }
}