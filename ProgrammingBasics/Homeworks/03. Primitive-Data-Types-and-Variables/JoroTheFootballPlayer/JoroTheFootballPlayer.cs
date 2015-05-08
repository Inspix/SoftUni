/* Joro loves a lot to play football. He used to play for his local village club 
 * “Pantera” Kaloyanovets. However, he is a programmer now and he is very busy. 
 * Now he is able to play only in the holidays and in the weekends. Joro plays in 
 * 1/2 of the holidays and once in the weekends, but not every weekend – only when
 * he is not tired and only when he is not going to his hometown. Joro goes at his
 * hometown h weekends in the year. The other weekends are considered “normal”. 
 * Joro is tired in 1/3 of the normal weekends. When Joro is at his hometown, 
 * he always plays football with his old friends once, at Sunday. In addition, 
 * if the year is leap, Joro plays football 3 more times additionally, in non-weekend 
 * days. We assume the year has exactly 52 weekends.
 * 
 * Your task is to write a program that calculates how many times Joro plays football 
 * (rounded down to the nearest integer number).
*/
using System;

namespace JoroTheFootballPlayer
{
    internal class JoroTheFootballPlayer
    {
        private static void Main(string[] args)
        {
            string yearType = Console.ReadLine();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            double normalWeekends = (52 - h) * (double)2 / 3;
            double holydayPlays = (double)p / 2;

            double allPlays = normalWeekends + holydayPlays + h;

            if (yearType == "t")
            {
                allPlays += 3;
                Console.WriteLine((int)allPlays);
            }
            else
            {
                Console.WriteLine((int)allPlays);
            }
        }
    }
}