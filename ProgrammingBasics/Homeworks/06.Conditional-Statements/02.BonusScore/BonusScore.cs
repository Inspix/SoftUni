using System;

namespace BonusScore
{
    internal class BonusScore
    {
        private static void Main(string[] args)
        {
            addBonus(getInput());
        }

        private static void addBonus(int x)
        {
            if (x >= 1 && x <= 3)
            {
                Console.WriteLine(x * 10);
            }
            else if (x >= 4 && x <= 6)
            {
                Console.WriteLine(x * 100);
            }
            else if (x >= 7 && x <= 9)
            {
                Console.WriteLine(x * 1000);
            }
            else if (x <= 0 || x > 9)
            {
                Console.WriteLine("Invalid score");
            }
        }

        private static int getInput()
        {
            int number;
            do
            {
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    break;
                }
                else
                {
                    Console.Write("Invalid input,try again: ");
                }
            } while (true);
            return number;
        }
    }
}