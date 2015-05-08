/*Using bitwise operators, write an expression for finding
 * the value of the bit #3 of a given unsigned integer.
 * The bits are counted from right to left, starting from bit #0.
 * The result of the expression should be either 1 or 0.*/

using System;

namespace BitExtraction
{
    internal class BitExtraction
    {
        private static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(bitCheck(input) ? "1" : "0");
        }

        private static bool bitCheck(int x)
        {
            return (x & (1 << 3)) != 0;
        }
    }
}