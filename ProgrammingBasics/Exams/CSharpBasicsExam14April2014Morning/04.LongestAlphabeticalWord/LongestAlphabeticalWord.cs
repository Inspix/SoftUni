using System;
using System.Collections.Generic;
using System.Linq;

internal class LongestAlphabeticalWord
{
    public static int index = 0;
    public static char[,] crossword;
    public static List<string> results = new List<string>();
    private static void Main(string[] args)
    {
        string word = Console.ReadLine();
        int size = int.Parse(Console.ReadLine());
        crossword = new char[size, size];

        for (int x = 0; x <= crossword.GetUpperBound(0); x++)
        {
            for (int y = 0; y <= crossword.GetUpperBound(1); y++)
            {
                crossword[x, y] = GetChar(word);
                index++;
            }
        }
        for (int x = 0; x <= crossword.GetUpperBound(0); x++)
        {
            for (int y = 0; y <= crossword.GetUpperBound(1); y++)
            {
                CheckDirections(x, y);
            }
        }
        int maxLenght = results.Max(x => x.Length);
        IEnumerable<string> longest = from x in results  
                                      where (x.Length == maxLenght)
                                      orderby x ascending
                                      select x;
        
        Console.WriteLine(longest.First());
    }

    private static void CheckDirections(int x, int y)
    {
        string result = "";
        //right
        for (int i = x; i <= crossword.GetUpperBound(0); i++)
        {
            if (result.Length == 0)
            {
                result = result + crossword[i, y];
            }
            else if (crossword[i - 1, y] < crossword[i, y])
            {
                result = result + crossword[i, y];
            }
            else
            {
                break;
            }
        }
        results.Add(result);
        result = "";
        //down
        for (int i = y; i <= crossword.GetUpperBound(1); i++)
        {
            if (result.Length == 0)
            {
                result = result + crossword[x, i];
            }
            else if (crossword[x, i - 1] < crossword[x, i])
            {
                result = result + crossword[x, i];
            }
            else
            {
                break;
            }
        }
        results.Add(result);
        //left
        result = "";
        for (int i = x; i >= 0; i--)
        {
            if (result.Length == 0)
            {
                result = result + crossword[i, y];
            }
            else if (crossword[i + 1, y] < crossword[i, y])
            {
                result = result + crossword[i, y];
            }
            else
            {
                break;
            }
        }
        results.Add(result);
        result = "";
        //up
        for (int i = y; i >= 0; i--)
        {
            if (result.Length == 0)
            {
                result = result + crossword[x, i];
            }
            else if (crossword[x, i+1] < crossword[x, i])
            {
                result = result + crossword[x, i];
            }
            else
            {
                break;
            }
        }
        results.Add(result);
    }

    private static char GetChar(string x)
    {
        if (index >= x.Length)
        {
            index = 0;
        }
        return x[index];
    }
}