/* Write a program that exchanges bits {p, p+1, …, p+k-1} with
 * bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
 * The first and the second sequence of bits may not overlap.*/

using System;

namespace BitExchange
{
    internal class BitExchange
    {
        private static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            if (Math.Abs(p - q) < k)
            {
                Console.WriteLine("overlapping");
            }
            else
            {
                Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
                bitChange(n, p, q, k);
            }
        }

        private static void bitChange(uint x, int p, int q, int k)
        {
            char[] input = Convert.ToString(x, 2).PadLeft(32, '0').ToCharArray();
            char[] result = new char[32];
            Array.Reverse(input);
            Array.Copy(input, result, 32);
            try
            {
                for (int i = 0; i <= k - 1; i++)
                {
                    result[p + i] = input[q + i];
                    result[q + i] = input[p + i];
                }
                Array.Reverse(result);
                string returnvalue = new string(result);
                Console.WriteLine(Convert.ToUInt32(returnvalue, 2));
            }
            catch
            {
                Console.WriteLine("out of range");
            }
        }
    }
}