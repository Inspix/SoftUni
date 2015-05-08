using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LongestIncSeq
{
    public static List<int> lastSeq = new List<int>();
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        List<List<int>> sequences = new List<List<int>>();
        
        int lastNum = int.Parse(input[0]);
        lastSeq.Add(lastNum);
        for (int i = 1; i <= input.GetUpperBound(0); i++)
        {
            int currentNum = int.Parse(input[i]);
            if (lastNum < currentNum)
            {
                lastSeq.Add(currentNum);
            }
            else
            {
                sequences.Add(lastSeq);
                lastSeq = new List<int>();
                lastSeq.Add(currentNum);
            }
            lastNum = currentNum;
        }
        sequences.Add(lastSeq);

        int index = 0;
        int count = 0;
        for (int i = 0; i < sequences.Count; i++)
        {
            if (count < sequences[i].Count)
            {
                count = sequences[i].Count;
                index = i;
            }

            foreach (int item in sequences[i])
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }

        Console.Write("Longest: ");
        foreach (int item in sequences[index])
        {
            Console.Write(item + " ");
        }
    }
}
