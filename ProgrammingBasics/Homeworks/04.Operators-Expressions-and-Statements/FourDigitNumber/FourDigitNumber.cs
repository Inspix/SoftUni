/* Write a program that takes as input a four-digit number in format abcd
 * (e.g. 2011) and performs the following:
 *
 * •Calculates the sum of the digits (in our example 2+0+1+1 = 4).
 * •Prints on the console the number in reversed order: dcba (in our example 1102).
 * •Puts the last digit in the first position: dabc (in our example 1201).
 * •Exchanges the second and the third digits: acbd (in our example 2101).
 *
 * The number has always exactly 4 digits and cannot start with 0.
 */

using System;
using System.Linq;

namespace FourDigitNumber
{
    internal class FourDigitNumber
    {
        private static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] numbers = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                numbers[i] = input[i] - 48;
            }
            Console.WriteLine("Sum of the digits is:{0}", numbers.Sum());
            Console.WriteLine("Reversed numbers:{0}", string.Join("", numbers.Reverse()));
            Console.WriteLine("Last digit in first position:{0}", string.Join("", numbers[3], numbers[0], numbers[1], numbers[2]));
            Console.WriteLine("Exchange the second and the third digits:{0}", string.Join("", numbers[0], numbers[2], numbers[1], numbers[3]));
        }
    }
}