using System;
using System.Globalization;
using System.Threading;

namespace BeerTime
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            string date = DateTime.Now.ToShortDateString();
            string time = Console.ReadLine();

            DateTime range = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 00, 00, 00);
            DateTime range2 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 03, 00, 00);
            DateTime range3 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 13, 00, 00);
            DateTime check;

            if (DateTime.TryParse(date + " " + time, out check))
            {
                if ((check >= range && check < range2) || (check >= range3 && check <= range.AddDays(1).Subtract(new TimeSpan(0, 0, 1))))
                {
                    Console.WriteLine("beer time");
                }
                else
                {
                    Console.WriteLine("non-beer time");
                }
            }
            else
            {
                Console.WriteLine("Invalid Time");
            }
        }
    }
}