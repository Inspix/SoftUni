using System;

internal class WorkHours
{
    private static void Main(string[] args)
    {
        int h = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());

        double normaldays = (double)d * 0.90;
        double hoursAvailable = ((normaldays * 12) * p) / 100;

        if (hoursAvailable - h >= 0)
        {
            Console.WriteLine("Yes");
            Console.WriteLine((int)(hoursAvailable - h));
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine((int)hoursAvailable - h);
        }
    }
}