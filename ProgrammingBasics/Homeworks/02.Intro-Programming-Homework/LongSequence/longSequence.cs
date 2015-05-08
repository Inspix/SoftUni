/* Write a program that prints the first 1000 members of the sequence:
 * 2, -3, 4, -5, 6, -7, … You might need to learn how to use loops in C# 
 * (search in Internet).*/

using System;

namespace LongSequence
{
    internal class longSequence
    {
        private static void Main(string[] args)
        {
            int x = 2;
            for (int i = 1; i <= 1000; i++)
            {
                if (x % 2 == 0)
                {
                    Console.Write(" " + x);
                }
                else
                {
                    Console.Write(" " + (-x));
                }
                x++;
            }
            Console.WriteLine();
        }
    }
}