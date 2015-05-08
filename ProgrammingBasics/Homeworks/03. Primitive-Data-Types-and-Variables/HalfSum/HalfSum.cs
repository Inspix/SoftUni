/* Nakov likes numbers. He often plays with their sums and differences. 
 * Once he invented the following game. He takes a sequence of numbers, 
 * splits them into two subsequences with the same number of elements 
 * and sums the left and right sub-sums, and compares the sub-sums. Please help him.
 * 
 * You are given a number n and 2*n numbers. Write a program to check whether 
 * the sum of the first n numbers is equal to the sum of the second n numbers.
 * Print as result “Yes” or “No”. In case of yes, print also the sum. In case of
 * no, print also the difference between the left and the right sums.
*/
using System;
using System.Linq;

namespace HalfSum
{
    internal class HalfSum
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers1 = new int[n];
            int[] numbers2 = new int[n];
            for (int i = 0; i < numbers1.Length; i++)
            {
                numbers1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < numbers2.Length; i++)
            {
                numbers2[i] = int.Parse(Console.ReadLine());
            }
            if (numbers2.Sum() == numbers1.Sum())
            {
                Console.WriteLine("Yes, sum={0}", numbers1.Sum());
            }
            else
            {
                Console.WriteLine("No, diff={0}", numbers1.Sum() - numbers2.Sum());
            }
        }
    }
}