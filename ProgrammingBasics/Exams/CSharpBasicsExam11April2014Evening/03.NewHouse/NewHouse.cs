using System;
using System.Text;

internal class NewHouse
{
    private static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());
        roof(size);
        Base(size);
    }

    private static void roof(int size)
    {
        char[] draw = new char[size];
        for (int i = 0; i <= size / 2; i++)
        {
            draw[(size / 2) + i] = '*';
            draw[(size / 2) - i] = '*';
            Console.WriteLine(new string(draw).Replace((char)0, '-'));
        }
    }

    private static void Base(int size)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append('|');
        sb.Append('*', size - 2);
        sb.Append('|');

        for (int i = 0; i < size; i++)
        {
            Console.WriteLine(sb.ToString());
        }
    }
}