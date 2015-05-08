/*Petya often plays with numbers. Her recent game was to play with 9-digit 
 * numbers and calculate their sums of digits, as well as to split them into 
 * triples with special properties. Help her to calculate very special numbers 
 * called “nine-digit magic numbers”.
 * 
 * You are given two numbers: diff and sum. Using the digits from 1 to 7 generate 
 * all 9-digit numbers in format abcdefghi, such that their sub-numbers abc, 
 * def and ghi have a difference diff (ghi-def = def-abc = diff), their sum of 
 * digits is sum and abc ≤ def ≤ ghi. Numbers holding these properties are also 
 * called “nine-digit magic numbers”.
 * 
 * Your task is to write a program to print these numbers in increasing order.
*/

//Had to take a peek in the authors solution to make it faster in the calculations

using System;

namespace Nine_DigitMagicNumbers
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());
            int diff = int.Parse(Console.ReadLine());
            int a = 0;
            for (int abc = 111; abc < 777; abc++)
            {
                int def = abc + diff;
                int ghi = def + diff;
                if (numberCheck(abc) && numberCheck(def) && numberCheck(ghi) && sumCheck(abc, def, ghi) == sum)
                {
                    Console.WriteLine("{0}{1}{2}", abc, def, ghi);
                    a++;
                }
            }
            if (a == 0)
            {
                Console.WriteLine("No");
            }
        }

        private static bool numberCheck(int x)
        {
            while (x >= 7)
            {
                if (x % 10 > 7 || x % 10 == 0)
                {
                    return false;
                }
                x /= 10;
            }
            return true;
        }

        private static int sumCheck(int x, int y, int z)
        {
            string numbers = x.ToString() + y.ToString() + z.ToString();
            int result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                result += (int)numbers[i] - 48;
            }
            return result;
        }
    }
}