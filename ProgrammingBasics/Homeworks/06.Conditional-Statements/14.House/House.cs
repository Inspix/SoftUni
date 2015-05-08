using System;

namespace House
{
    internal class House
    {
        private static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            roof(size);
            roofBase(size);
            houseSides(size);
            houseBottom(size);
        }

        private static void roof(int size)
        {
            for (int i = 0; i < size / 2; i++)
            {
                char[] draw = new char[size];
                draw[(size) / 2 + i] = '*';
                draw[(size) / 2 - i] = '*';

                Console.WriteLine(new string(draw).Replace((char)0, '.'));
            }
        }

        private static void roofBase(int size)
        {
            Console.WriteLine(new string('*', size));
        }

        private static void houseSides(int size)
        {
            char[] draw = new char[size];
            draw[size / 2 - (size + 1) / 4] = '*';
            draw[size / 2 + (size + 1) / 4] = '*';
            for (int i = 0; i < (size / 2) - 1; i++)
            {
                Console.WriteLine(new string(draw).Replace((char)0, '.'));
            }
        }

        private static void houseBottom(int size)
        {
            char[] draw = new char[size];
            for (int i = size / 2 - (size + 1) / 4; i <= size / 2 + (size + 1) / 4; i++)
            {
                draw[i] = '*';
            }
            Console.WriteLine(new string(draw).Replace((char)0, '.'));
        }
    }
}