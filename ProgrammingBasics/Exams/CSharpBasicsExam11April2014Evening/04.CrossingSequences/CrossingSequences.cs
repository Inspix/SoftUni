using System;
using System.Collections.Generic;

internal class CrossingSequences
{
    public static List<int> tribunacci = new List<int>();

    private static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int spiralA = int.Parse(Console.ReadLine());
        int spiralB = int.Parse(Console.ReadLine());
        populateTribunaci(a, b, c);
        int result = spiralCheck(spiralA, spiralB);
        if (result != -1)
        {
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("No");
        }
    }

    private static int spiralCheck(int a, int b)
    {
        int number = a;
        int step = 1;
        if (tribunacci.Contains(number))
        {
            return number;
        }
        while (number < 1000000)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int y = 0; y < step; y++)
                {
                    number += b;
                }
                if (tribunacci.Contains(number))
                {
                    return number;
                }
            }

            step++;
        }
        return -1;
    }

    private static void populateTribunaci(int a, int b, int c)
    {
        int sum = a + b + c;
        tribunacci.Add(a);
        tribunacci.Add(b);
        tribunacci.Add(c);
        while (sum <= 1000000)
        {
            a = a + b + c;
            tribunacci.Add(a);
            b = a + b + c;
            tribunacci.Add(b);
            sum = a + b + c;
            c = a + b + c;
            tribunacci.Add(c);
        }
    }
}