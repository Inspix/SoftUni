using System;
using System.Collections.Generic;
using System.Linq;

namespace Pairs
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<int> sums = getPairs(Input());
            if (sums.Max() - sums.Min() == 0)
            {
                Console.WriteLine("Yes, value={0}", sums[0]);
            }
            else
            {
                int maxd = 0;
                int value = sums[0];
                for (int i = 1; i < sums.Count; i++)
                {
                    int difference = Math.Abs(value - sums[i]);
                    value = sums[i];
                    maxd = Math.Max(maxd, difference);
                }
                Console.WriteLine("No, maxdiff={0}", maxd);
            }
        }

        private static List<int> Input()
        {
            int temp;
            bool check;

            List<int> numbers = new List<int>();

            do
            {
                check = false;
                string[] x = Console.ReadLine().Split(' ');
                foreach (var item in x)
                {
                    if (int.TryParse(item, out temp))
                    {
                        numbers.Add(temp);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input,try again!:\n");
                        numbers.Clear();
                        check = true;
                        break;
                    }
                }
            } while (check);
            return numbers;
        }

        private static List<int> getPairs(List<int> numbers)
        {
            List<int> pairs = new List<int>();
            int index = 0;
            for (int i = 0; i < numbers.Count / 2; i++)
            {
                int sum = 0;

                sum += numbers[index];
                index++;
                sum += numbers[index];
                index++;
                pairs.Add(sum);
            }
            return pairs;
        }
    }
}