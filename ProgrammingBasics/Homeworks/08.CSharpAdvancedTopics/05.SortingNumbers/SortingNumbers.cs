using System;
using System.Collections.Generic;
using System.Linq;

internal class SortingNumbers
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        IEnumerable<int> ordNumbers = numbers.OrderBy(x => x);

        foreach (int i in ordNumbers)
        {
            Console.WriteLine(i);
        }
    }
}