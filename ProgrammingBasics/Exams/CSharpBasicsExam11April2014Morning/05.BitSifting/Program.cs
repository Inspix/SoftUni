using System;

internal class Program
{
    private static void Main(string[] args)
    {
        ulong numtoSieve = ulong.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            ulong sieve = ulong.Parse(Console.ReadLine());
            numtoSieve = numtoSieve & ~(sieve);
        }
        checkNofBits(numtoSieve);
    }

    private static void checkNofBits(ulong x)
    {
        x -= (x >> 1) & 0x5555555555555555UL;
        x = (x & 0x3333333333333333UL) + ((x >> 2) & 0x3333333333333333UL); //put count of each 4 bits into those 4 bits
        x = (x + (x >> 4)) & 0x0F0F0F0F0F0F0F0FUL;        //put count of each 8 bits into those 8 bits
        x = (x * 0x0101010101010101) >> 56;
        Console.WriteLine(x);
    }
}