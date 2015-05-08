using System;
using System.Text;

internal class WineGlass
{
    public static int index = 0;

    private static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());
        Glass(size);
        Neck(size);
        GlassBase(size);
    }

    private static void Glass(int size)
    {
        int jump = 2;
        for (int i = 0; i < size / 2; i++)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append('.', i);
            sb.Append('\\');
            sb.Append('*', size - jump);
            sb.Append('/');
            sb.Append('.', i);
            jump += 2;
            Console.WriteLine(sb.ToString());
            index++;
        }
    }

    private static void Neck(int size)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append('.', (size / 2) - 1);
        sb.Append('|', 2);
        sb.Append('.', (size / 2) - 1);
        if (size >= 12)
        {
            for (int i = size / 2; i < size - 2; i++)
            {
                Console.WriteLine(sb.ToString());
                index++;
            }
        }
        else
        {
            for (int i = size / 2; i < size - 1; i++)
            {
                Console.WriteLine(sb.ToString());
                index++;
            }
        }
    }

    private static void GlassBase(int size)
    {
        for (int i = index; i < size; i++)
        {
            Console.WriteLine(new string('-', size));
        }
    }
}