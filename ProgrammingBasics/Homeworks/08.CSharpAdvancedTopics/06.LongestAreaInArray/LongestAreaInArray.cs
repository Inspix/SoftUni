using System;
using System.Collections.Generic;
using System.Linq;

internal class LongestAreaInArray
{
    private static void Main(string[] args)
    {
        string[] strings = new string[int.Parse(Console.ReadLine())];
        for (int i = 0; i < strings.Length; i++)
        {
            strings[i] = Console.ReadLine();
        }

        Dictionary<string, int> Areas = new Dictionary<string, int>();

        foreach (var item in strings)
        {
            if (Areas.ContainsKey(item))
            {
                Areas[item]++;
            }
            else
            {
                Areas.Add(item, 1);
            }
        }

        for (int i = 0; i < Areas.Max(x => x.Value); i++)
        {
            Console.WriteLine(Areas.Aggregate((x, y) => y.Value > x.Value ? y : x).Key);
        }
    }
}