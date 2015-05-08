using System;
using System.Text;

internal class Eclipse
{
    private static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());
        TopBottom(size);
        for (int i = 1; i < size - 1; i++)
        {
            if (i == size / 2)
            {
                Console.WriteLine(Middle(size).Replace(' ', '-'));
            }
            else
            {
                Console.WriteLine(Middle(size));
            }
        }
        TopBottom(size);
    }

    private static void TopBottom(int size)
    {
        string border = new string('*', size * 2);
        border = " " + border.Remove(0, 1);
        border = border.Remove(border.Length - 1) + " ";
        Console.WriteLine("{0}{1}{0}", border, new string(' ', size -1));
    }

    private static string Middle(int size)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append('*');
        sb.Append('/', (size * 2) - 2);
        sb.Append('*');
        sb.Append(' ', size -1);
        sb.Append('*');
        sb.Append('/', (size * 2) - 2);
        sb.Append('*');
        return sb.ToString();
    }
}