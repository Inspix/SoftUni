using System;

internal class MinMaxAverageNumbers
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        bool firstN = true;
        int min = 0;
        int max = 0;
        int sum = 0;
        double average;
        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            if (firstN)
            {
                min = number;
                max = number;
                sum = number;
                firstN = false;
            }
            else
            {
                min = Math.Min(min, number);
                max = Math.Max(max, number);
                sum += number;
            }
        }
        average = (double)sum / n;
        Console.WriteLine("min={0}", min);
        Console.WriteLine("max={0}", max);
        Console.WriteLine("sum={0}", sum);
        Console.WriteLine("avg={0:0.00}", average);
    }
}