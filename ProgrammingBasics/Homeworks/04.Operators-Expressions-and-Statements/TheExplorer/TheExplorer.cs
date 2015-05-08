using System;

namespace TheExplorer
{
    internal class TheExplorer
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            top(n);
            bottom(n);
        }

        private static void top(int size)
        {
            char[] pic = new char[size];
            string x = "";
            for (int i = 0; i <= size / 2; i++)
            {
                Array.Clear(pic, 0, size);
                pic[size / 2 + i] = '*';
                pic[size / 2 - i] = '*';
                x = new string(pic);
                Console.WriteLine(x.Replace((char)0, '-'));
            }
        }

        private static void bottom(int size)
        {
            char[] pic = new char[size];
            string x = "";
            for (int i = size / 2 - 1; i >= 0 / 2; i--)
            {
                Array.Clear(pic, 0, size);
                pic[size / 2 + i] = '*';
                pic[size / 2 - i] = '*';
                x = new string(pic);
                Console.WriteLine(x.Replace((char)0, '-'));
            }
        }
    }
}