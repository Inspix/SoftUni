using System;
using System.Text.RegularExpressions;

class ExtractEmails
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        Regex rgx = new Regex(@"[\w._-]*@[\w._-]*\w");
        MatchCollection matches = rgx.Matches(input);

        foreach (var match in matches)
        {
            Console.WriteLine(match);
        }

    }
}
