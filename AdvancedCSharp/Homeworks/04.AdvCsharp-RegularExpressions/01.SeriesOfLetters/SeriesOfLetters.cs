using System;
using System.Text.RegularExpressions;

class SeriesOfLetters
{
    static void Main()
    {
        
        string input = Console.ReadLine();

        input = Regex.Replace(input, @"(\w)\1+", "$1");

        Console.WriteLine(input);
    }
}
