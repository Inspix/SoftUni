using System;
using System.Text;

internal class Arrow
{
    private static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());
        Top(size);
        for (int i = 0; i < size - 2; i++)
        {
            Trunk(size);
        }
        Middle(size);
        ArrowDraw(size);
    }

    private static void Top(int size)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append('.', size / 2);
        sb.Append('#', size);
        sb.Append('.', size / 2);
        Console.WriteLine(sb.ToString());
    }

    private static void Trunk(int size)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append('.', size / 2);
        sb.Append('#');
        sb.Append('.', size / 2);
        sb.Append('.', (size / 2) - 1);
        sb.Append('#');
        sb.Append('.', size / 2);
        Console.WriteLine(sb.ToString());
    }

    private static void Middle(int size)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append('#', (size / 2) + 1);
        sb.Append('.', size - 2);
        sb.Append('#', (size / 2) + 1);
        Console.WriteLine(sb.ToString());
    }

    private static void ArrowDraw(int size)
    {
        int position = size - 1;
        for (int i = size - 2; i >= 0; i--)
        {
            char[] draw = new char[(size * 2) - 1];
            draw[size - position] = '#';
            draw[size + position - 2] = '#';
            position--;
            Console.WriteLine(new string(draw).Replace((char)0, '.'));
        }
    }
}