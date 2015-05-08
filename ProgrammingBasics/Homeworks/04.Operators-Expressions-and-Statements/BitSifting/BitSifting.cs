using System;

namespace BitSifting
{
    internal class BitSifting
    {
        private static void Main(string[] args)
        {
            ulong number = ulong.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                ulong numberN = ulong.Parse(Console.ReadLine());
                number = number & ~(numberN);
            }
            Console.WriteLine(NumberOfSetBits(number));
        }

        //Hamming Weight http://en.wikipedia.org/wiki/Hamming_weight
        private static int NumberOfSetBits(ulong i)
        {
            i = i - ((i >> 1) & 0x5555555555555555UL);
            i = (i & 0x3333333333333333UL) + ((i >> 2) & 0x3333333333333333UL);
            return (int)(unchecked(((i + (i >> 4)) & 0xF0F0F0F0F0F0F0FUL) * 0x101010101010101UL) >> 56);
        }
    }
}