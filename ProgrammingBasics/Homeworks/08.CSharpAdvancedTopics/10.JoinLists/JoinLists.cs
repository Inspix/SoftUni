using System;
using System.Collections.Generic;
using System.Linq;

internal class JoinLists
{
    private static void Main(string[] args)
    {
        string[] numbers1 = Console.ReadLine().Split(' ');
        string[] numbers2 = Console.ReadLine().Split(' ');

        IEnumerable<int> numbers = from x in numbers1.Union(numbers2)
                                   orderby int.Parse(x) ascending
                                   select Convert.ToInt32(x);

        foreach (int item in numbers)
        {
            Console.Write(item + " ");
        }
    }
}