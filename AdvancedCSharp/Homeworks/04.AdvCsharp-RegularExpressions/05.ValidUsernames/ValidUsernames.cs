using System;
using System.Text.RegularExpressions;

class ValidUsernames
{
    static void Main()
    {
        string pattern = @"\b[a-zA-Z][\w_]{2,24}\b";
        string input = Console.ReadLine();
        MatchCollection matches = Regex.Matches(input, pattern);

        int maxSum = 0;
        string nameOne = string.Empty;
        string nameTwo = string.Empty;
        for (int i = 0; i < matches.Count-1; i++)
        {
            int currentSum = matches[i].Length + matches[i + 1].Length;
            if (maxSum < currentSum || maxSum == 0)
            {
                maxSum = currentSum;
                nameOne = matches[i].Value;
                nameTwo = matches[i + 1].Value;
            }
        }

        Console.WriteLine(nameOne);
        Console.WriteLine(nameTwo);
    }
}