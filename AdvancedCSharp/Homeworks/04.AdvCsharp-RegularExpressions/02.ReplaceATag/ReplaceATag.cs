using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class ReplaceATag
{
    static void Main()
    {
        string input = Console.ReadLine();
        string pattern = @"<a(.*?)>(.*)<\/a>";
        string replace = @"[URL$1]$2[/URL]";

        input = Regex.Replace(input, pattern, replace);
        Console.WriteLine(input);
    }
}
