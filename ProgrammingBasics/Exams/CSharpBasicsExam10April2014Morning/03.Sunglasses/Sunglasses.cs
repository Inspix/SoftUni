using System;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());
        TopBottom(input);
        for (int i = 2; i < input; i++)
        {
            if (i == (input / 2) + 1)
            {
                Console.WriteLine(Middle(input).Replace(' ', '|'));
            }
            else
            {
                Console.WriteLine(Middle(input));
            }
        }
        TopBottom(input);
    }

    private static void TopBottom(int size)
    {
        StringBuilder draw = new StringBuilder();
        draw.Append('*', size * 2);
        draw.Append(' ', size);
        draw.Append('*', size * 2);
        Console.WriteLine(draw.ToString());
    }

    private static string Middle(int size)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append('*');
        sb.Append('/', (size * 2) - 2);
        sb.Append('*');
        sb.Append(' ', size);
        sb.Append('*');
        sb.Append('/', (size * 2) - 2);
        sb.Append('*');
        return sb.ToString();
    }
}