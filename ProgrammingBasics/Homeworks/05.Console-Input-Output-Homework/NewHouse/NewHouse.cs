using System;
using System.Text;

namespace NewHouse
{
    internal class NewHouse
    {
        private static void Main(string[] args)
        {
            roof(int.Parse(Console.ReadLine()));
        }

        private static void roof(int size)
        {
            char[] str = new char[size];
            string toPrint = "";
            int mid = size / 2;
            for (int i = 0; i <= (size / 2); i++)
            {
                str[mid + i] = '*';
                str[mid - i] = '*';
                toPrint = new string(str).Replace((char)0, '-');
                Console.WriteLine(toPrint);
            }
            walls(size);
        }

        private static void walls(int size)
        {
            StringBuilder toPrint = new StringBuilder();
            toPrint.Append('|');
            toPrint.Append('*', size - 2);
            toPrint.Append('|');
            for (int i = 1; i <= size; i++)
            {
                Console.WriteLine(toPrint.ToString());
            }
        }
    }
}