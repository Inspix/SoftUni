using System;
using System.Text;

class StringLength
{
    static void Main()
    {
        string input = Console.ReadLine();

        StringBuilder output = new StringBuilder(input);
        int length = output.Length;
        if (length >= 20)
        {
            output.Remove(20, output.Length - 20);
        }
        else
        {
            output.Append('*', 20 - output.Length);
        }
        Console.WriteLine(output.ToString());
    }
}
