using System;
using System.Collections.Generic;
using System.Linq;

class PythagoreanNumbers
{
    static void Main(string[] args)
    {
        bool noMatch = true;
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(numbers);

        for (int a = 0; a < n; a++)
        {
            for (int b = 0; b < n; b++)
            {
                for (int c = 0; c < n; c++)
                {
                    if (numbers[a] <= numbers[b])
                    {
                        if (PytaNumber(numbers[a], numbers[b], numbers[c]))
                        {
                            if (noMatch) noMatch = false;
                            Console.WriteLine("{0}*{0} + {1}*{1} = {2}*{2}",numbers[a], numbers[b], numbers[c]);
                        } 
                    }
                }
            }
        }
        if (noMatch) Console.WriteLine("No");
    }

    static bool PytaNumber(int a, int b, int c)
    {
        a *= a;
        b *= b;
        c *= c;
        if (a + b == c)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
