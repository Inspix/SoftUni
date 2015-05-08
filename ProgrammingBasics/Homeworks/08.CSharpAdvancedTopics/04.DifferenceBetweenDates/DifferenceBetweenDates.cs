using System;
using System.Globalization;
using System.Threading;

internal class DifferenceBetweenDates
{
    private static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), "d.MM.yyyy", CultureInfo.InvariantCulture);
        DateTime secondDate = DateTime.ParseExact(Console.ReadLine(), "d.MM.yyyy", CultureInfo.InvariantCulture);

        int result = 0;
        while (firstDate != secondDate)
        {
            if (firstDate < secondDate)
            {
                firstDate = firstDate.AddDays(1);
                result++;
            }
            else
            {
                firstDate = firstDate.AddDays(-1);
                result--;
            }
        }
        Console.WriteLine(result);
    }
}