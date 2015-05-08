using System;

internal class GCD
{
    private static void Main(string[] args)
    {
        long a = long.Parse(Console.ReadLine());
        long b = long.Parse(Console.ReadLine());
        if (a > b)
        {
            Console.WriteLine(GcdCalc(a, b));
        }
        else
        {
            Console.WriteLine(GcdCalc(b, a));
        }
    }

    private static long GcdCalc(long a, long b)
    {
        if (b == 0)
        {
            return a;
        }
        else
        {
            return GcdCalc(b, a % b);
        }
    }
}