/*Write an expression that checks for given integer if its third digit from right-to-left is 7. */

using System;

namespace ThirdDigit7
{
    internal class ThirdDigit7
    {
        private static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} | {1}", input, isThirdNumber7(input));
        }

        private static bool isThirdNumber7(int x)
        {
            string str = x.ToString();
            return (str.Length >= 3 && str[str.Length - 3] == 55) ? true : false;
        }
    }
}