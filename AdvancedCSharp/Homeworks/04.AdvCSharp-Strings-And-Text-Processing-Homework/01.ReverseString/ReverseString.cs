using System;
using System.Text;

class ReverseString
{
    static void Main()
    {
        string input = Console.ReadLine();
        Console.WriteLine(Reverse(input));
    }
    public static string Reverse(string x)
    {
        StringBuilder sb = new StringBuilder();
        int lenght = x.Length - 1;
        for (int i = lenght; i >= 0; i--)
        {
            sb.Append(x[i]);
        }
        return sb.ToString();
    }
}


