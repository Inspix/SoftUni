using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CountSymbols
{
    static void Main()
    {
        char[] input = Console.ReadLine().ToCharArray();
        Dictionary<char, int> characters = new Dictionary<char, int>();
        foreach (char c in input)
        {
            if (characters.ContainsKey(c))
            {
                characters[c]++;
            }
            else
            {
                characters.Add(c, 1);
            }
        }

        foreach (KeyValuePair<char,int> pair in characters.OrderBy(s=> s.Key))
        {
            Console.WriteLine("{0}:{1} time/s",pair.Key,pair.Value);
        }
    }
}