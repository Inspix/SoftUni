using System;
using System.Text.RegularExpressions;

internal class CountingWordInText
{
    private static void Main(string[] args)
    {
        string word = Console.ReadLine();
        string pattern = @"\b" + word + "\\b";
        Regex rgx = new Regex(pattern, RegexOptions.IgnoreCase);
        string sentence = "The Software University (SoftUni) trains software engineers, gives them a profession and a job. Visit us at http://softuni.bg. Enjoy the SoftUnification at SoftUni.BG. Contact us.Email: INFO@SOFTUNI.BG. Facebook: https://www.facebook.com/SoftwareUniversity. YouTube: http://www.youtube.com/SoftwareUniversity. Google+: https://plus.google.com/+SoftuniBg/. Twitter: https://twitter.com/softunibg. GitHub: https://github.com/softuni";
        Console.WriteLine("\n" + sentence);
        MatchCollection result = rgx.Matches(sentence);

        Console.WriteLine(result.Count);
    }
}