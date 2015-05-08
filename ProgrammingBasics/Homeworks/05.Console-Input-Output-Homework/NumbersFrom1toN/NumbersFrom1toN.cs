using System;

namespace NumbersFrom1toN
{
    internal class NumbersFrom1toN
    {
        private static void Main(string[] args)
        {
            #region Tests

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Testing with variables from the examples!\n");
            int[] testInts = new int[] { 3, 5, 1 };
            foreach (int item in testInts)
            {
                Console.WriteLine("Input: {0}", item);
                printNumbers(item);
                Console.WriteLine();
            }
            Console.WriteLine("Test End!\n");
            Console.ForegroundColor = ConsoleColor.White;

            #endregion Tests

            Console.Write("How many numbers do you want to print?:");
            printNumbers(getInput());
        }

        private static void printNumbers(int x)
        {
            for (int i = 1; i <= x; i++)
            {
                Console.WriteLine(i);
            }
        }

        private static int getInput()
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
    }
}