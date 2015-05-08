using System;
using System.Numerics;

namespace FibonacciNumbers
{
    internal class FibonacciNumbers
    {
        private static void Main(string[] args)
        {
            #region Tests

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Testing with the example inputs from the homework!\n");

            Console.Write("Input 1 : ");
            printFibonacci(1);
            Console.Write("Input 3 : ");
            printFibonacci(3);
            Console.Write("Input 10: ");
            printFibonacci(10);

            Console.WriteLine("\nTest end!\n");
            Console.ForegroundColor = ConsoleColor.White;

            #endregion Tests

            Console.Write("How many numbers from fibonacci sequence do you want(bigger than zero)?:");
            printFibonacci(getInput());
        }

        //Print n fibonacci numbers
        //Tested with ulong until its full and than continue with biginteger
        //to check the performance (tested with 300 numbers).. for this task only BigInteger is little bit faster.(could be wrong first time tesing)
        private static void printFibonacci(int n)
        {
            BigInteger x = 0;
            BigInteger y = 1;

            Console.Write("{0} ", x);
            for (int i = 1; i <= n - 1; i++)
            {
                if (i % 2 == 0)
                {
                    x = x + y;
                    Console.Write("{0} ", x);
                }
                else
                {
                    y = x + y;
                    Console.Write("{0} ", y);
                }
            }
            Console.WriteLine();
        }

        //Get input with a validation
        private static int getInput()
        {
            int number;
            do
            {
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    if (number < 1)
                    {
                        Console.Write("Invalid input,try again: ");
                        continue;
                    }
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