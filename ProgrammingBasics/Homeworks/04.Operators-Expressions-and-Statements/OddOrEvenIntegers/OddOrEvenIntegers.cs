/*Write an expression that checks if given integer is odd or even.*/

using System;

namespace OddOrEvenIntegers
{
    internal class OddOrEvenIntegers
    {
        private static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            if (input % 2 == 0)
            {
                Console.WriteLine("The number is Even");
            }
            else
            {
                Console.WriteLine("The number is Odd");
            }
        }
    }
}