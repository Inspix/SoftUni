using System;
using System.Collections.Generic;
using System.Linq;

class SequenceInMatrix
{
    public static Dictionary<string, int> matches = new Dictionary<string, int>();
    static void Main()
    {
        //string[,] matrix = new string[3, 3] { { "s", "qq", "s"},
        //                                    { "pp", "pp", "s" }, 
        //                                    { "pp", "qq", "s" } };

        string[,] matrix = new string[3, 4] { { "ha", "fifi", "ho", "hi"},
                                            { "fo", "ha", "hi", "xx" }, 
                                            { "xxx", "ho", "ha", "xx" } };

        for (int x = 0; x < matrix.GetUpperBound(0); x++)
        {
            for (int y = 0; y <= matrix.GetUpperBound(1); y++)
            {
                InitGetDiagonals(ref matrix, x, y);
            }
        }

        GetDuplicates(ref matrix);

        KeyValuePair<string, int> longest = (from entry in matches orderby entry.Value descending select entry).First();
        for (int i = 0; i < longest.Value; i++)
        {
            if (i == longest.Value-1 )
            {
                Console.Write(longest.Key);
            }
            else
            {
                Console.Write(longest.Key + ", ");
            }
            
        } 
        Console.WriteLine();
    }

    static void GetDuplicates(ref string[,] matrix)
    {
        Dictionary<string, int> match = new Dictionary<string, int>();

        for (int i = 0; i <= matrix.GetUpperBound(1); i++)
        {
            int xDown = 0;
            while (xDown >= 0 && xDown <= matrix.GetUpperBound(0))
            {
                if (match.ContainsKey(matrix[xDown, i]))
                {
                    match[matrix[xDown, i]]++;
                }
                else
                {
                    match.Add(matrix[xDown, i], 1);
                }
                xDown++;
            }
            KeyValuePair<string, int> longest = (from entry in match orderby entry.Value descending select entry).First();
            CompareMatches(longest);
            match.Clear();
        }

        for (int i = 0; i <= matrix.GetUpperBound(0); i++)
        {
            int y = 0;
            while (y >= 0 && y <= matrix.GetUpperBound(1))
            {
                if (match.ContainsKey(matrix[i, y]))
                {
                    match[matrix[i, y]]++;
                }
                else
                {
                    match.Add(matrix[i, y], 1);
                }
                y++;
            }
            KeyValuePair<string, int> longest = (from entry in match orderby entry.Value descending select entry).First();
            CompareMatches(longest);
            match.Clear();
        }
    }

    static void GetDuplicates(ref string[,] matrix, int xStart,int yStart,int x, int y)
    {
        int xPosition = xStart;
        int yPosition = yStart;
        Dictionary<string, int> match = new Dictionary<string, int>();
        while (xPosition >= 0 && xPosition <= matrix.GetUpperBound(0) && yPosition >= 0 && yPosition <= matrix.GetUpperBound(1))
        {
            if (match.ContainsKey(matrix[xPosition, yPosition]))
            {
                match[matrix[xPosition, yPosition]]++;
            }
            else
            {
                match.Add(matrix[xPosition, yPosition], 1);
            }
            xPosition += x;
            yPosition += y;
        }
        KeyValuePair<string, int> longest = (from entry in match orderby entry.Value descending select entry).First();
        CompareMatches(longest);
    }

    static void InitGetDiagonals(ref string [,] matrix,int x, int y)
    {
        GetDuplicates(ref matrix, x, y, x + 1, y + 1);
        GetDuplicates(ref matrix, x, y, x + 1, y - 1);
    }

    static void CompareMatches(KeyValuePair<string, int> pair)
    {
        if (matches.ContainsKey(pair.Key))
        {
            if (matches[pair.Key] < pair.Value)
            {
                matches[pair.Key] = pair.Value;
            }
        }
        else
        {
            matches.Add(pair.Key, pair.Value);
        }
    }
}
