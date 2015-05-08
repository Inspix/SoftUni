/*We are given an integer number n, a bit value v (v=0 or 1) and a
 * position p. Write a sequence of operators (a few lines of C# code)
 * that modifies n to hold the value v at the position p from the binary
 * representation of n while preserving all other bits in n. */

using System;

namespace ModifyBitAtPosition
{
    internal class ModifyBitAtPosition
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int v = int.Parse(Console.ReadLine());

            Console.WriteLine(bitChange(n, p, v));
        }

        private static int bitChange(int n, int p, int v)
        {
            if (v == 0)
            {
                return (n &= ~(1 << p));
            }
            else
            {
                return (n |= (v << p));
            }
        }
    }
}