using System;

namespace Volleyball
{
    internal class Volleyball
    {
        private static void Main(string[] args)
        {
            string yearType = Console.ReadLine();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            double holidayplays = p * (double)2 / 3;
            double normalweekends = (48 - h) * (double)3 / 4;
            double allplays = holidayplays + normalweekends + h;
            if (yearType == "leap")
            {
                Console.WriteLine((int)(allplays + (allplays * 0.15)));
            }
            else
            {
                Console.WriteLine((int)allplays);
            }
        }
    }
}