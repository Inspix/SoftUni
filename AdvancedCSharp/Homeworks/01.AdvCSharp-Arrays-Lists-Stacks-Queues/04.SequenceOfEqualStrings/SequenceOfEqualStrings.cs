using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SequenceOfEqualStrings
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        Dictionary<string, int> results = new Dictionary<string, int>();
        
        for (int i = 0; i <= input.GetUpperBound(0); i++)
        {
            if (results.ContainsKey(input[i]))
            {
                results[input[i]]++;
            }
            else
            {
                results.Add(input[i], 1);
            }

        }
        foreach (KeyValuePair<string,int> str in results)
        {
            for (int i = 0; i < str.Value; i++)
            {
                Console.Write("{0} ",str.Key);
            }
            Console.WriteLine();
        }
    }
}
