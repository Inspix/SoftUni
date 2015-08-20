using _01.Dictionary;
using System;
using System.Linq;

namespace _02.CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            HashTable<char, int> table = new HashTable<char, int>();
            foreach (char c in input)
            {
                if (!table.ContainsKey(c))
                {
                    table[c] = 0;
                }
                table[c]++;
            }


            foreach (var item in table.OrderBy(s => s.Key))
            {
                Console.WriteLine(item);
            }
        }
    }
}
