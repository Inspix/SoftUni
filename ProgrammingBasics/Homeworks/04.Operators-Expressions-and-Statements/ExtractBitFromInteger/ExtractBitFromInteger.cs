/*Write an expression that extracts from given integer n the value of given bit at index p*/

using System;

namespace ExtractBitFromInteger
{
    internal class ExtractBitFromInteger
    {
        private static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine(bitCheck(input, p) ? "1" : "0");
        }

        private static bool bitCheck(int x, int p)
        {
            return (x & (1 << p)) != 0;
        }
    }
}