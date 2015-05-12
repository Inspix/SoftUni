using System;
using System.Text;

class TextFilter
{
    static void Main()
    {
        string[] forbiddenWords = Console.ReadLine().Split(',');
        StringBuilder sb = new StringBuilder(Console.ReadLine());

        foreach (string str in forbiddenWords)
        {
            sb.Replace(str.Trim(), new string('*', str.Length));
        }

        Console.WriteLine(sb.ToString());
    }
}
