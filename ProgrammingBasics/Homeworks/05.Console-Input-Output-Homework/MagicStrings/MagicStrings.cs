using System;

namespace MagicStrings
{
    internal class MagicStrings
    {
        private static int leftWeight;
        private static int rightWeight;
        private static int diff;
        private static bool hasMatch = false;
        private static char[] letters = new char[] { 'k', 'n', 'p', 's' };

        private static string left;
        private static string right;

        private static void Main(string[] args)
        {
            #region Tests

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Testing with example inputs from the homework!\n");
            int[] testInts = { 16, 15, 20 };
            foreach (int i in testInts)
            {
                hasMatch = false;
                Console.WriteLine("\nInput:{0}", i);
                diff = i;
                leftString();
                if (!hasMatch)
                {
                    Console.WriteLine("No");
                }
            }
            Console.WriteLine("\nTest Done!\n");
            Console.ForegroundColor = ConsoleColor.White;

            #endregion Tests

            diff = int.Parse(Console.ReadLine());
            leftString();
            if (!hasMatch)
            {
                Console.WriteLine("No");
            }
        }

        private static void leftString()
        {
            for (int i = 0; i <= letters.GetUpperBound(0); i++)
            {
                for (int i2 = 0; i2 <= letters.GetUpperBound(0); i2++)
                {
                    for (int i3 = 0; i3 <= letters.GetUpperBound(0); i3++)
                    {
                        for (int i4 = 0; i4 <= letters.GetUpperBound(0); i4++)
                        {
                            left = "" + letters[i] + letters[i2] + letters[i3] + letters[i4];
                            leftWeight = calcWeight(left);
                            rightString();
                        }
                    }
                }
            }
        }

        private static void rightString()
        {
            for (int i = 0; i <= letters.GetUpperBound(0); i++)
            {
                for (int i2 = 0; i2 <= letters.GetUpperBound(0); i2++)
                {
                    for (int i3 = 0; i3 <= letters.GetUpperBound(0); i3++)
                    {
                        for (int i4 = 0; i4 <= letters.GetUpperBound(0); i4++)
                        {
                            right = "" + letters[i] + letters[i2] + letters[i3] + letters[i4];
                            rightWeight = calcWeight(right);
                            int tempdiff = Math.Abs(leftWeight - rightWeight);
                            if (tempdiff == diff)
                            {
                                Console.WriteLine(left + right);
                                hasMatch = true;
                            }
                        }
                    }
                }
            }
        }

        private static int calcWeight(string toCheck)
        {
            int result = 0;
            foreach (char c in toCheck)
            {
                switch (c)
                {
                    case 's': result += 3;
                        break;

                    case 'n': result += 4;
                        break;

                    case 'k': result += 1;
                        break;

                    case 'p': result += 5;
                        break;
                }
            }
            return result;
        }
    }
}