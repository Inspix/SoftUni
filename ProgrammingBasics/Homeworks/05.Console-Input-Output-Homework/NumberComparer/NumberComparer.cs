using System;
using System.Globalization;
using System.Threading;

namespace NumberComparer
{
    internal class NumberComparer
    {
        private static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            #region Tests

            //Tests from homework file
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Test with variables from the examples!\n");
            double[,] testNumbers = new double[,]
            {
                {5,6},
                {10,5},
                {0,0},
                {-5,-2},
                {1.5,1.6}
            };
            for (int i = 0; i <= testNumbers.GetUpperBound(0); i++)
            {
                Console.WriteLine("A= {0,-5}|B= {1,-5}|Greater: {2}", testNumbers[i, 0], testNumbers[i, 1], Math.Max(testNumbers[i, 0], testNumbers[i, 1]));
            }
            Console.WriteLine("Test end!\n");
            Console.ForegroundColor = ConsoleColor.White;

            #endregion Tests

            Console.WriteLine("\nPlease enter 2 numbers:");
            double x = getInput();
            double y = getInput();
            Console.WriteLine("The greater number is:{0}", Math.Max(x, y));
        }

        //Get double input with check
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