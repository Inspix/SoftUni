using System;
using System.Globalization;
using System.Threading;

internal class Cinema
{
    private static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string projectType = Console.ReadLine();

        int rows = int.Parse(Console.ReadLine());
        int columns = int.Parse(Console.ReadLine());

        if (projectType == "Premiere")
        {
            Console.WriteLine("{0:0.00} leva", (double)(rows * columns) * 12);
        }
        else if (projectType == "Normal")
        {
            Console.WriteLine("{0:0.00} leva", (double)(rows * columns) * 7.50);
        }
        else
        {
            Console.WriteLine("{0:0.00} leva", (double)(rows * columns) * 5);
        }
    }
}