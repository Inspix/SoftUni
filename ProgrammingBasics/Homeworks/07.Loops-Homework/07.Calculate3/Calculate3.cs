using System;
using System.Numerics;

class Calculate3
{
    static void Main(string[] args)
    {
        long n = long.Parse(Console.ReadLine());
        long k = long.Parse(Console.ReadLine());
        BigInteger nResult = n;
        BigInteger kResult = k;
        BigInteger nMinusk = n - k;

        for (long i = n-1; i >=1; i--)
        {
            nResult *= i;
            if (i < k)
            {
                kResult *= i; 
            }
            if (i< n-k)
            {
                nMinusk *= i;
            }
        }
        BigInteger result = nResult / (kResult * nMinusk);
        Console.WriteLine(result);
    }
}

