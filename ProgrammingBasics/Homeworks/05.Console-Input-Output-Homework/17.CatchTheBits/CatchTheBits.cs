using System;
using System.Collections;
using System.Linq;

namespace CatchTheBits
{
    internal class CatchTheBits
    {
        private static void Main(string[] args)
        {
            #region Tests

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Testing with variables from the examples!\n");
            ArrayList testValues = new ArrayList();
            testValues.Add(new int[] { 109, 87 });
            testValues.Add(new int[] { 45, 87, 250 });
            testValues.Add(new int[] { 45, 87 });
            int[] steps = { 11, 2, 2 };
            for (int i = 0; i < steps.Length; i++)
            {
                int[] testArray = (int[])testValues[i];
                Console.WriteLine("Input variables: # of integers {0}, Step: {1},Integers: {2}", testArray.Length, steps[i], string.Join(", ", testArray.Select(v => v.ToString())));
                Console.WriteLine("Result:");
                result(check((int[])testValues[i], steps[i]));
            }
            Console.WriteLine("\nTesting Done!\n");
            Console.ForegroundColor = ConsoleColor.White;

            #endregion Tests

            int n = int.Parse(Console.ReadLine());
            int step = int.Parse(Console.ReadLine());
            result(check(n, step));
        }

        private static void result(string x)
        {
            while (x.Length != 0)
            {
                if (x.Length < 8)
                {
                    Console.WriteLine(Convert.ToInt32(x.PadRight(8, '0'), 2));
                    break;
                }
                if (x.Length >= 8)
                {
                    Console.WriteLine(Convert.ToInt32(x.Substring(0, 8), 2));
                    x = x.Remove(0, 8);
                }
            }
        }

        //Get a string with extracted bits
        private static string check(int n, int step)
        {
            int index = 0;
            string toCheck = "";
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                for (int y = 7; y >= 0; y--)
                {
                    if (index == 1 | index % step == 1)
                    {
                        toCheck = toCheck + (bitCheck(number, y));
                    }
                    index++;
                }
            }
            return toCheck;
        }

        /// <summary>
        /// Overload method for checking with static data
        /// Used for testing
        /// </summary>
        /// <param name="n">Integer array with numbers to check</param>
        /// <param name="step">Step</param>
        /// <returns>Returns string with extracted bits</returns>
        private static string check(int[] n, int step)
        {
            int index = 0;
            string toCheck = "";
            foreach (int x in n)
            {
                for (int y = 7; y >= 0; y--)
                {
                    if (index == 1 | index % step == 1)
                    {
                        toCheck = toCheck + (bitCheck(x, y));
                    }
                    index++;
                }
            }
            return toCheck;
        }

        private static int bitCheck(int x, int p)
        {
            bool test = (x & (1 << p)) != 0;
            if (test)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}