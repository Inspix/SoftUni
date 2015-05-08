/* Write an expression that checks if given positive integer number n
 * (n ≤ 100) is prime (i.e. it is divisible without remainder only to itself and 1).*/

using System;

namespace PrimeNumberCheck
{
    internal class PrimeNumberCheck
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(primeCheck(n));
        }

        private static bool primeCheck(int x)
        {
            if (x == 1 || x <= 0)
            {
                return false;
            }
            if (x == 2)
            {
                return true;
            }
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