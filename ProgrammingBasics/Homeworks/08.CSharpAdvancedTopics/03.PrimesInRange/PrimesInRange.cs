using System;
using System.Collections.Generic;

internal class PrimesInRange
{
    private static void Main(string[] args)
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());

        List<int> primes = FindPrimesInRange(start, end);
        string outputString = "";
        foreach (int i in primes)
        {
            outputString = outputString + i + ",";
        }
        Console.WriteLine(outputString.TrimEnd(','));
    }

    private static List<int> FindPrimesInRange(int start, int end)
    {
        List<int> numbers = new List<int>();
        for (int i = start; i <= end; i++)
        {
            if (IsPrime(i))
            {
                numbers.Add(i);
            }
        }
        return numbers;
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