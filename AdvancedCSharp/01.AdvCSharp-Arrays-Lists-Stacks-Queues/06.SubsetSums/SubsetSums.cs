using System;
using System.Collections.Generic;
using System.Linq;

class SubsetSums
{
    static void Main(string[] args)
    {
        bool match = false;
        int n = int.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split(' ');
        List<int> numbers = new List<int>();
        foreach (string str in input)
        {
            int x = int.Parse(str);
            if (!numbers.Contains(x))
            {
                numbers.Add(x);
            }
        }
        for (int i = 1; i < (int)Math.Pow(2,numbers.Count); i++)
        {
            Tuple<string,int> subset = getSubset(i,numbers);
            if (subset.Item2 == n)
            {
                if (!match)
                {
                    match = true; 
                }
                Console.WriteLine(subset.Item1);
            }
        }
        if (!match)
        {
            Console.WriteLine("No matching subsets");
        }
    }

    public static Tuple<string,int> getSubset(int iteration, List<int> numbers)
    {
        int position = 0;
        int bitmask = iteration;
        string result = string.Empty;
        int sum = 0;
        while (bitmask > 0)
        {
            if ((bitmask & 1) == 1 && position >= 0)
            {
                result += numbers[position] + " + ";
                sum += numbers[position];
            }
            bitmask >>= 1;
            position++;
        }
        result = result.Remove(result.Length-2) + " = " + sum;

        return new Tuple<string, int>(result, sum);
    }
}
