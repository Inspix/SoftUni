using System;
using System.Numerics;

class TrailingZeroes
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(GetTrailingZeroes(Factorial(n)));
    }

    private static BigInteger Factorial(int x)
    {
        BigInteger result = 1;
        for (int i = 2; i <= x; i++)
        {
            result *= i;
        }
        return result;
    }

    private static long GetTrailingZeroes(BigInteger x)
    {
        long result = 0;

        while (true)
        {
            if (x % 10 == 0)
            {
                result++;
                x /= 10;
            }
            else
            {
                break;
            }
        }
        return result;
    }
}
