using System;
using System.Text;

namespace IsoscelessTriangle
{
    internal class IsoscelesTriangleB
    {
        public static char c = '\u00A9';

        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int baseSize = 0;
            bool proceed = false;
            Console.WriteLine("Please enter the size of the triangle base(from 3 to 40(Console Limitation)");
            while (!proceed)
            {
                if (int.TryParse(Console.ReadLine(), out baseSize))
                {
                    if (baseSize >= 3 && baseSize <= 40)
                    {
                        Console.WriteLine("Printing triangle with base of {0}\n", baseSize);
                        proceed = true;
                    }
                    else
                    {
                        Console.WriteLine("Number {0} is out of range! Please enter valid one(form 3 to 40):");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter a valid number");
                }
            }

            printTop(baseSize);
            for (int i = 2; i < baseSize; i++)
            {
                printSides(baseSize, i);
            }
            printBottom(baseSize);
        }

        private static void printTop(int x)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(' ', x - 1);
            sb.Append(c);
            Console.WriteLine(sb.ToString());
        }

        private static void printSides(int x, int y)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(' ', x - y);
            sb.Append(c);
            sb.Append(' ', y - 2);
            sb.Append(' ');
            sb.Append(' ', y - 2);
            sb.Append(c);
            Console.WriteLine(sb.ToString());
        }

        private static void printBottom(int x)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < x; i++)
            {
                sb.Append(c);
                sb.Append(' ');
            }
            Console.WriteLine(sb.ToString());
            Console.WriteLine();
        }
    }
}