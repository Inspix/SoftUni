using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ZeroSubset
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] numbers = new int[5];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = getInput();
            }
            GetSubsets(numbers);
        }

        private static void GetSubsets(int[] nums)
        {
            List<List<int>> subsets = new List<List<int>>();
            byte[] subsetN = new byte[1];

            for (byte i = 2; i < Math.Pow(2, nums.Length); i++)
            {
                if (GetBits(i) > 1)
                {
                    subsetN[0] = i;
                    BitArray x = new BitArray(subsetN);
                    List<int> subset = new List<int>();
                    for (int bitN = 0; bitN < x.Count; bitN++)
                    {
                        if (x[bitN])
                        {
                            subset.Add(nums[bitN]);
                        }
                    }
                    subsets.Add(subset);
                }
            }

            bool noSubsets = true;
            foreach (List<int> subset in subsets)
            {
                if (subset.Sum() == 0)
                {
                    noSubsets = false;
                    for (int i = 0; i < subset.Count; i++)
                    {
                        if (i == subset.Count - 1)
                        {
                            Console.Write("{0} = ", subset[i]);
                        }
                        else
                        {
                            Console.Write("{0} + ", subset[i]);
                        }
                    }
                    Console.WriteLine("0");
                }
            }
            if (noSubsets)
            {
                Console.WriteLine("No Subsets");
            }
        }

        private static int GetBits(int i)
        {
            i = i - ((i >> 1) & 0x55555555);
            i = (i & 0x33333333) + ((i >> 2) & 0x33333333);
            return (((i + (i >> 4)) & 0x0F0F0F0F) * 0x01010101) >> 24;
        }

        private static int getInput()
        {
            int num;
            do
            {
                if (int.TryParse(Console.ReadLine(), out num))
                {
                    break;
                }
                else
                {
                    Console.Write("Invalid input,try again: ");
                }
            } while (true);
            return num;
        }
    }
}