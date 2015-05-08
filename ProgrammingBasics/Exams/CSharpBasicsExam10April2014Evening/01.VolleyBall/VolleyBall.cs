using System;

internal class VolleyBall
{
    private static void Main(string[] args)
    {
        string yearType = Console.ReadLine();
        double p = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());

        double normalWeekends = (48 - h) * (3.0 / 4);
        double holidays = p * (2.0 / 3);
        double allPlays = normalWeekends + holidays + h;
        if (yearType == "leap")
        {
            Console.WriteLine((int)(allPlays + (allPlays * 0.15)));
        }
        else
        {
            Console.WriteLine((int)allPlays);
        }
    }
}