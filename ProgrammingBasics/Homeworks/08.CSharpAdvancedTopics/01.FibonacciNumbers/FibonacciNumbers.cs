using System;
using System.Numerics;

internal class FibonacciNumbers
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(Fib(n));
    }

    private static BigInteger Fib(int n)
    {
        int index = n;
        BigInteger result = 0;
        if (n == 0 || n == 1)
        {
            return 1;
        }
        else
        {
            BigInteger a = 1;
            BigInteger b = 1;

            for (int i = 1; i < n; i++)
            {
                if (i % 2 == 1)
                {
                    result = a + b;
                    a = a + b;
                }
                else
                {
                    result = a + b;
                    b = a + b;
                }
            }
        }
        return result;
    }
}