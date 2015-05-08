/* Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26
 * of given 32-bit unsigned integer.*/

using System;

namespace BitExchange
{
    internal class BitExchange
    {
        private static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());
            Console.WriteLine(bitChange(n));
        }

        private static uint bitChange(uint x)
        {
            char[] input = Convert.ToString(x, 2).PadLeft(32, '0').ToCharArray();
            char[] result = new char[32];
            Array.Reverse(input);
            Array.Copy(input, result, 32);
            for (int i = 0; i <= 2; i++)
            {
                result[3 + i] = input[24 + i];
                result[24 + i] = input[3 + i];
            }
            Array.Reverse(result);
            string output = new string(result);
            return Convert.ToUInt32(output, 2);
        }
    }
}