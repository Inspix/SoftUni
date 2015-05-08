using System;

namespace NumberAsWords
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            SpellOutNumber(int.Parse(Console.ReadLine()));
        }

        private static void SpellOutNumber(int x)
        {
            if (x <= 19)
            {
                Console.WriteLine(SingleOrHundreds(x, false));
            }
            else if (x > 19 && x < 100)
            {
                if (x % 10 == 0)
                {
                    Console.WriteLine(secondDigit(x / 10));
                }
                else
                {
                    Console.WriteLine(secondDigit(x / 10) + " " + SingleOrHundreds(x % 10, false).ToLower());
                }
                Console.WriteLine();
            }
            else if (x >= 100)
            {
                if (x % 100 == 0)
                {
                    Console.WriteLine(SingleOrHundreds(x / 100, true));
                }
                else if (x % 10 == 0)
                {
                    Console.WriteLine(SingleOrHundreds(x / 100, true) + " and " + secondDigit((x / 10) % 10).ToLower());
                }
                else if (x % 100 < 20)
                {
                    Console.WriteLine(SingleOrHundreds(x / 100, true) + " and " + SingleOrHundreds(x % 100, false).ToLower());
                }
                else
                {
                    Console.WriteLine(SingleOrHundreds(x / 100, true) + " and " + secondDigit((x / 10) % 10).ToLower() + " " + SingleOrHundreds(x % 10, false).ToLower());
                }
            }
        }

        private static string SingleOrHundreds(int x, bool hundreds)
        {
            switch (x)
            {
                case 0: return "Zero";
                case 1: return hundreds ? "One hundred" : "One";
                case 2: return hundreds ? "Two hundred" : "Two";
                case 3: return hundreds ? "Three hundred" : "Three";
                case 4: return hundreds ? "Four hundred" : "Four";
                case 5: return hundreds ? "Five hundred" : "Five";
                case 6: return hundreds ? "Six hundred" : "Six";
                case 7: return hundreds ? "Seven hundred" : "Seven";
                case 8: return hundreds ? "Eight hundred" : "Eight";
                case 9: return hundreds ? "Nine hundred" : "Nine";
                case 10: return "Ten";
                case 11: return "Eleven";
                case 12: return "Twelve";
                case 13: return "Thirteen";
                case 14: return "Fourteen";
                case 15: return "Fifteen";
                case 16: return "Sixteen";
                case 17: return "Seventeen";
                case 18: return "Eighteen";
                case 19: return "Nineteen";
                default: return "x";
            }
        }

        private static string secondDigit(int x)
        {
            switch (x)
            {
                case 2: return "Twenty";
                case 3: return "Thirty";
                case 4: return "Fourty";
                case 5: return "Fifty";
                case 6: return "Sixty";
                case 7: return "Seventy";
                case 8: return "Eighty";
                case 9: return "Ninety";
                default: return "x";
            }
        }
    }
}