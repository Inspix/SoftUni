/* Write a Boolean expression that returns if the bit at position p
 * (counting from 0, starting from the right) in given integer number n has value of 1*/

using System;

namespace CheckBitAtPosition
{
    internal class CheckBitAtPosition
    {
        private static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine(bitCheck(input, p));
        }

        private static bool bitCheck(int x, int p)
        {
            return (x & (1 << p)) != 0;
        }
    }
}