using System;
using System.Collections.Generic;
using System.Linq;

class SortedSubsetSums
{
    static void Main(string[] args)
    {
        bool match = false;
        int n = int.Parse(Console.ReadLine());
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).Distinct().ToArray();
        // List of tuples to store all information about every subset(string for printing, int for the sum, int for the number of operands)
        List<Tuple<string, int, int>> subsets = new List<Tuple<string, int, int>>();

        int numberOfSubsets = 1 << numbers.Length;
        // Get each subset
        for (int i = 1; i < numberOfSubsets; i++)
        {
            Tuple<string, int, int> subset = getSortedSubset(i, numbers);
            if (subset.Item2 == n) // Add matching subsets to list
            {
                if (!match)
                {
                    match = true;
                }
                subsets.Add(subset);
            }
        }

        // Sort the list of subsets first by string, then by number of operands
        subsets = subsets.OrderBy(s => s.Item1).OrderBy(s => s.Item3).ToList();

        // Print the subsets
        foreach (var item in subsets)
        {
            Console.WriteLine(item.Item1 + "= "+ item.Item2);
        }

        // If theres no match output
        if (!match)
        {
            Console.WriteLine("No matching subsets");
        }
    }

    // Method for getting sorted subset
    public static Tuple<string, int, int> getSortedSubset(int iteration, int[] numbers)
    {
        int position = 0;
        int bitmask = iteration;
        string result = string.Empty;
        int sum = 0;
        int operands = 1;
        List<int> nums = new List<int>();
        while (bitmask > 0)
        {
            if ((bitmask & 1) == 1 && position >= 0)
            {
                nums.Add(numbers[position]);
                sum += numbers[position];
                operands++;
            }
            bitmask >>= 1;
            position++;
           
        }
        nums.Sort();
        foreach (int item in nums)
        {
            result += item + " + ";
        }
        result = result.Remove(result.Length - 2);

        return new Tuple<string, int,int>(result, sum,operands);
    }
}
