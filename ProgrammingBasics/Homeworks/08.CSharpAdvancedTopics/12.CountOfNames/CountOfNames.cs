using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CountOfNames
{
    static void Main(string[] args)
    {
        string[] names = Console.ReadLine().Split(' ');
        Dictionary<string, int> Names = new Dictionary<string, int>();
        
        foreach (string i in names)
        {
            if (Names.ContainsKey(i))
            {
                Names[i]++;
            }
            else
            {
                Names.Add(i, 1);
            }
        }

        foreach (KeyValuePair<string,int> pair in Names.OrderBy(x => x.Key))
        {
            Console.WriteLine(pair.Key + " -> " + pair.Value);
        }
    }
}
