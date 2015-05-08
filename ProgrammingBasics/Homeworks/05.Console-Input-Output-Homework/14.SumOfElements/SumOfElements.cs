using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfElements
{
    class SumOfElements
    {
        static void Main(string[] args)
        {
            #region Tests
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Testing with the example variables!");
            string[] testValues = new string[] { "3 4 1 1 2 12 1", "6 1 2 3", "1 1 10", "5 5 1", "1 1 1", "0 0" };
            foreach (string t in testValues)
            {
                Console.WriteLine("\nInput : {0}",t);
                Console.Write("Result: ");
                checkSumOfElements(getNumbers(t));
            }
            Console.WriteLine("\nTest End!\n");
            Console.ForegroundColor = ConsoleColor.White;
            #endregion
            List<int> nums = getNumbers(Console.ReadLine());
            checkSumOfElements(nums);
            
        }

        private static void checkSumOfElements(List<int> x)
        {
            int minDiff = x.Sum();
            int? sum = null;
            foreach (int i in x)
            {
                if (i == x.Sum() - i)
                {
                    sum = i;
                    Console.WriteLine("Yes = {0}", i);
                    break;
                }
                if (minDiff > (x.Sum() - i) - i)
                {
                    minDiff = (x.Sum() - i) - i;
                }
            }
            if (!sum.HasValue)
            {
                Console.WriteLine("No = {0}", Math.Abs(minDiff));
            }
        }

        private static List<int> getNumbers(string str)
        {
            List<int> numbers = new List<int>();
            string[] x = str.Split(' ');
            foreach (var item in x)
            {
                numbers.Add(int.Parse(item));
            }
            return numbers;
        }
    }
}
