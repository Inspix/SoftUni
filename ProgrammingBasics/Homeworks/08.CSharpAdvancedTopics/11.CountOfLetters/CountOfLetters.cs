using System;
using System.Collections.Generic;
using System.Linq;

internal class CountOfLetters
{
    private static void Main(string[] args)
    {
        char[] letters = Console.ReadLine().Replace(" ", "").ToCharArray();
        Dictionary<char, int> count = new Dictionary<char, int>();
        foreach (char item in letters)
        {
            if (count.ContainsKey(item))
            {
                count[item]++;
            }
            else
            {
                count.Add(item, 1);
            }
        }

        foreach (KeyValuePair<char, int> item in count.OrderBy(x => x.Key))
        {
            Console.WriteLine(item.Key + " -> " + item.Value);
        }
    }
}