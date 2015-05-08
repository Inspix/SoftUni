using System;

internal class CalculateN1
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());

        double s = 1;
        int num = 0;
        for (int i = 1; i <= n; i++)
        {
            num = i;
            for (int f = i - 1; f >= 1; f--)
            {
                num *= f;
            }
            s += (double)num / (double)Math.Pow(x, i);
        }
        Console.WriteLine("{0:0.00000}", s);
    }
}