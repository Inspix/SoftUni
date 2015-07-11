using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem2.SortWords
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var words = Console.ReadLine().Split().ToList();

            Sort(words);
            Console.WriteLine(string.Join(" ", words));
        }

        // As a method to check the result with unit testing i know it makes no sense
        public static void Sort(List<string> words)
        {
            words.Sort();
        }
    }
}
