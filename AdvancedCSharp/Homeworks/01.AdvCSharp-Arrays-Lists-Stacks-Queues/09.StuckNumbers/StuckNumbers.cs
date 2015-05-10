using System;
using System.Collections.Generic;
using System.Linq;

class StuckNumbers
{
    static void Main(string[] args)
    {        
        bool noMatch = true;
        int n = int.Parse(Console.ReadLine());
        string[] numbers = Console.ReadLine().Split(new char[]{' ',',',';'},StringSplitOptions.RemoveEmptyEntries);
        for (int a = 0; a < n; a++)
        {
            for (int b = 0; b < n; b++)
            {
                for (int c = 0; c < n; c++)
                {
                    for (int d = 0; d < n; d++)
                    {
                        if (a != b && a != c && a != d && b != c && b != d && c != d )
                        {
                            if (numbers[a]+numbers[b] == numbers[c]+numbers[d])
                            {
                                if (noMatch) noMatch = false;
                                Console.WriteLine("{0}|{1}=={2}|{3}", numbers[a], numbers[b], numbers[c], numbers[d]);
                            }
                        }
                        else
                        {
                            continue;
                        }                       
                    }
                }
            }
        }
        if (noMatch)
        {
            Console.WriteLine("No");
        }
    }
}