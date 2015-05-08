using System;
using System.Globalization;
using System.Threading;

internal class ExamSchedule
{
    private static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int hour = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());
        string partOfDay = Console.ReadLine();
        DateTime start = DateTime.Parse(string.Format("{0}:{1} {2}", hour, minutes, partOfDay));
        int examhours = int.Parse(Console.ReadLine());
        int examminutes = int.Parse(Console.ReadLine());
        start = start.AddHours(examhours);
        start = start.AddMinutes(examminutes);

        Console.WriteLine(start.ToString("hh:mm:tt"));
    }
}