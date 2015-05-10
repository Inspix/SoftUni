using System;
using System.Collections.Generic;
using System.Linq;

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

            
            Console.WriteLine(string.Join(" ", sequences[i]));
        }

        Console.Write("Longest: ");
        Console.WriteLine(string.Join(" ", sequences[index]));
    }
}
