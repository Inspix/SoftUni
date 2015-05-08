/* Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...*/

using System;

namespace Sequence
{
    internal class Sequence
    {
        private static void Main(string[] args)
        {
            int x = 2;
            for (int i = 0; i < 10; i++)
            {
                if (x % 2 == 0)
                {
                    Console.WriteLine(x);
                }
                else
                {
                    Console.WriteLine(-x);
                }
                x++;
            }
        }
    }
}