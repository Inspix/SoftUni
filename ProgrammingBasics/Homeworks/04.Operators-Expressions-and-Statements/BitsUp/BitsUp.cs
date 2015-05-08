using System;

namespace BitsUp
{
    internal class BitsUp
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int step = int.Parse(Console.ReadLine());
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                for (int bits = 7; bits >= 0; bits--)
                {
                    if (index == 1 || index % step == 1)
                    {
                        number = number |= (1 << bits);
                    }
                    index++;
                }
                Console.WriteLine(number);
            }
        }
    }
}