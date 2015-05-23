using System;
using System.Collections.Generic;
using System.Linq;

class NightLife
{
    static void Main()
    {
        Dictionary<string, Avenue> avenues = new Dictionary<string, Avenue>();

        string[] input;
        do
        {
            input = Console.ReadLine().Split(';');
            if (input[0] == "END")
            {
                break;
            }
            else if (input.Length != 3)
            {
                Console.WriteLine("Invalid input...");
                continue;
            }
            else
            {
                if (avenues.ContainsKey(input[0]))
                {
                    avenues[input[0]].AddPerformance(input[1], input[2]);
                }
                else
                {
                    avenues.Add(input[0], new Avenue(input[1], input[2]));
                }
            }
        } while (true);

        foreach (KeyValuePair<string,Avenue> pair in avenues)
        {
            Console.WriteLine(pair.Key);
            foreach (KeyValuePair<string, SortedSet<string>> ave in pair.Value.Avenues)
            {
                Console.WriteLine("-->" + ave.Key + ":" + string.Join(",", ave.Value));
            }
        }

    }
}

class Avenue
{
    public SortedDictionary<string, SortedSet<string>> Avenues;

    public Avenue(string avenueName, string performer)
    {
        this.Avenues = new SortedDictionary<string, SortedSet<string>>();
        this.Avenues.Add(avenueName, new SortedSet<string> { performer });
    }

    public void AddPerformance(string avenue,string performer)
    {
        if (Avenues.ContainsKey(avenue))
        {
            this.Avenues[avenue].Add(performer);
        }
        else
        {
            this.Avenues.Add(avenue, new SortedSet<string> { performer });
        }
    }
}
