using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PandaScotishFlag
{
    public static int charPosition = 64;
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        if (n == 1)
        {
            Console.WriteLine("A");
        }
        else
        {
            PrintTopBottom(n);
            for (int i = 1; i <= (n/2) -1; i++)
            {
                PrintRest(n, i);
            }
            PrintMiddle(n);
            for (int i = (n / 2) - 1; i >=1; i--)
            {
                PrintRest(n, i);
            }
            PrintTopBottom(n);
        }
    }
    public static char GetChar()
    {
        if (charPosition >= 90)
        {
            charPosition = 64;
        }
        charPosition++;
        return (char)charPosition;
    }

    public static void PrintTopBottom(int x)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(GetChar());
        sb.Append('#', x - 2);
        sb.Append(GetChar());
        Console.WriteLine(sb.ToString());
    }

    public static void PrintMiddle(int x)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append('-', x / 2);
        sb.Append(GetChar());
        sb.Append('-', x / 2);
         Console.WriteLine(sb.ToString());
    }

    public static void PrintRest(int x,int position)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append('~', position);
        sb.Append(GetChar());
        sb.Append('#', x - 2 - (position*2));
        sb.Append(GetChar());
        sb.Append('~', position);
        Console.WriteLine(sb.ToString());
    }
}
