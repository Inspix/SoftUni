/* Write a Boolean expression that checks for given integer if it can
 * be divided (without remainder) by 7 and 5 in the same time.*/

using System;

namespace DivideBySevenAndFive
{
    internal class DivideBySevenAndFive
    {
        private static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine((input % 7 == 0 && input % 5 == 0) ? true : false);
        }
    }
}