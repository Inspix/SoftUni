using System;

internal class Joro
{
    private static void Main(string[] args)
    {
        string yearType = Console.ReadLine();
        int p = int.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());

        double holidays = (double)p / 2;
        double plays = (52 - h) * (double)2 / 3;

        if (yearType == "t")
        {
            Console.WriteLine("{0}", (int)(plays + holidays + h + 3));
        }
        else
        {
            Console.WriteLine("{0}", (int)(plays + holidays + h));
        }
    }
}