using System;
using System.Text.RegularExpressions;

class SentenceExtractor
{
    static void Main(string[] args)
    {
        string word = Console.ReadLine();
        string toCheck = Console.ReadLine();

        Regex rgx = new Regex(@"(\w[^.!?]*\b" + word + @"\b[^.!?]*[.!?])");
        MatchCollection matches = rgx.Matches(toCheck);
        foreach (var item in matches)
        {
            Console.WriteLine(item);
        }
    }
}