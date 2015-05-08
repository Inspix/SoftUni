using System;
using System.Collections.Generic;
using System.Linq;

class SortArrayOfNumbers
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int[] numbers = GetSortedNumArray(input);
        foreach (int i in numbers)
        {
            Console.Write(i + " ");
        }
    }

    static int[] GetSortedNumArray(string x)
    {
        List<int> numbers = new List<int>();
        Array.ForEach(x.Split(' '),s => 
        {
            int cNum;
            if (Int32.TryParse(s,out cNum))
            {
                numbers.Add(cNum);
            }
        });
        numbers.Sort();
        return numbers.ToArray();
    }
}
