using System;

internal class PrimeChecker
{
    private static void Main(string[] args)
    {
        long n = long.Parse(Console.ReadLine());
        Console.WriteLine(IsPrime(n));
    }

    private static bool IsPrime(long x)
    {
        if (x == 0 || x == 1)
        {
            return false;
        }
        else if (x == 2)
        {
            return true;
        }
        else
        {
            for (int i = 2; i < x; i++)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}