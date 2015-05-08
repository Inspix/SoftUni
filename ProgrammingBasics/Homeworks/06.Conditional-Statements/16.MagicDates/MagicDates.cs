using System;

namespace MagicDates
{
    internal class MagicDates
    {
        private static void Main(string[] args)
        {
            int startYear = int.Parse(Console.ReadLine());
            DateTime start = new DateTime(startYear, 1, 1);
            int endYear = int.Parse(Console.ReadLine());
            DateTime end = new DateTime(endYear, 12, 31);
            int magicW = int.Parse(Console.ReadLine());
            int index = 0;
            while (start != end.AddDays(1))
            {
                if (checkWeight(start, magicW))
                {
                    Console.WriteLine(start.ToString("dd-MM-yyyy"));
                    index++;
                }
                start = start.AddDays(1);
            }
            if (index == 0)
            {
                Console.WriteLine("No");
            }
        }

        private static bool checkWeight(DateTime date, int magic)
        {
            string datetime = date.ToString("ddMMyyyy");

            int weight = 0;
            for (int i = 0; i < datetime.Length; i++)
            {
                for (int y = i + 1; y < datetime.Length; y++)
                {
                    weight += (datetime[i] - 48) * (datetime[y] - 48);
                }
            }
            if (weight == magic)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}