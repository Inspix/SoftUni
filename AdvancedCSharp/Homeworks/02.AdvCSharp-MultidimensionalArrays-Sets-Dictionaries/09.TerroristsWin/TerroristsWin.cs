using System;

class TerroristsWin
{
    static void Main()
    {
        string input = Console.ReadLine();
        string result = string.Empty;
        while (input != null)
        {
            result = input;
            input = ExlodeBomb(input);
        }
        Console.WriteLine(result);
    }

    static string ExlodeBomb(string x)
    {
        int firstIndex = x.IndexOf('|');
        
        int secondIndex = x.IndexOf('|',firstIndex+1);
        if (firstIndex == -1 || secondIndex == -1)
        {
            return null;
        }
        int sum = 0;
        for (int i = firstIndex + 1; i < secondIndex; i++)
        {
            sum += x[i];
        }
        sum = sum % 10;
        string toReplace = string.Empty;
        if (firstIndex - sum <= 0)
        {
            toReplace = x.Substring(0, secondIndex + sum + 1);
        }
        else if(secondIndex + sum >= x.Length)
        {
            toReplace = x.Substring(firstIndex - sum);
        }
        else
        {
            toReplace = x.Substring(firstIndex - sum, secondIndex - firstIndex + 1 + (sum * 2));
        }
        
        x = x.Replace(toReplace, new string('.', toReplace.Length));
        return x;
    }
}
