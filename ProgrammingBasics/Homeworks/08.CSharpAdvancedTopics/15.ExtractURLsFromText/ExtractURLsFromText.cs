using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class ExtractURLsFromText
{
    static void Main(string[] args)
    {
        string pattern = @"(http:\/\/|www.)([a-zA-Z0-9]([a-zA-Z0-9\-]{0,61}[a-zA-Z0-9])?\.)+[a-zA-Z]{2,6}";
        string input = Console.ReadLine();
        Regex rgx = new Regex(pattern,RegexOptions.IgnoreCase);
        MatchCollection sites = rgx.Matches(input);

        foreach (var item in sites)
        {
            Console.WriteLine(item);
        }
    }
}
