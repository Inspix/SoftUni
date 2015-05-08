using System;

namespace NumbersDividable
{
    internal class NumbersDividable
    {
        private static void Main(string[] args)
        {
            #region Tests

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Testing with example inputs from the homework!\n");
            int[,] testValues = new int[,] { { 17, 25 }, { 5, 30 }, { 3, 33 }, { 3, 4 }, { 99, 120 }, { 107, 196 } };

            for (int i = 0; i <= testValues.GetUpperBound(0); i++)
            {
                Console.Write("Input : {0,-4} , {1,-5}", testValues[i, 0], testValues[i, 1]);
                Console.WriteLine("Result: {0}", getNumbers(testValues[i, 0], testValues[i, 1]));
            }
            Console.WriteLine("\nTest End!\n");
            Console.ForegroundColor = ConsoleColor.White;

            #endregion Tests

            Console.WriteLine("Please enter 2 integers each on new line:");
            Console.WriteLine("There are {0} numbers in that range that are dividable by 5", getNumbers(getInput(), getInput()));
        }

        //Check the range between 2 numbers and return how many of those can be divided by 5
        private static int getNumbers(int start, int end)
        {
            int amount = 0;
            for (int i = start; i <= end; i++)
            {
                if (i % 5 == 0)
                {
                    amount++;
                }
            }
            return amount;
        }

        //Get input with a validation
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