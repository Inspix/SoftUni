using System;
using System.Linq;

class LongestWordInText
{
    static void Main(string[] args)
    {
        string[] words = Console.ReadLine().Split(' ');
        Console.WriteLine(words.OrderByDescending(x => x.Length).First().TrimEnd('.'));
    }
}
