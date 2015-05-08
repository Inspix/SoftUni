using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        BigInteger number = Factorial(2 * n) / (Factorial(n + 1) * Factorial(n));
        Console.WriteLine(number);

    }
    private static BigInteger Factorial(int i)
    {
        if (i == 0)
        {
            return 1;
        }
        return i * Factorial(i - 1);
    }
}
