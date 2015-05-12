using System;

class SubstringCount
{
    static void Main()
    {
        string input = Console.ReadLine().ToLower();
        string phrase = Console.ReadLine().ToLower();
        
        Console.WriteLine(SubstringMatches(input,phrase));
    }

    static int SubstringMatches(string toMatch,string substing)
    {
        int lastIndex = 0;
        int count = 0;

        while (true)
        {
            lastIndex = toMatch.IndexOf(substing, lastIndex);
            if (lastIndex == -1)
            {
                break;
            }
            else
            {
                lastIndex++;
                count++;
            }
        }
        return count;
    }
}
