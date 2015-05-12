using System;
using System.Text;


class UnicodeCharacters
{
    static void Main()
    {
        string input = Console.ReadLine();
        StringBuilder result = new StringBuilder();
        foreach (char c in input)
        {
            result.Append(getUnicodeChar(c));
        }
        Console.WriteLine(result.ToString());
    }
    static string getUnicodeChar(char c)
    {
        return "\\u" + ((int)c).ToString("X").PadLeft(4, '0');
    }
}
