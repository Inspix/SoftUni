using System;
using System.Collections.Generic;
using System.Linq;

class PlusRemove
{
    static void Main()
    {
        string input;
        List<string> characters = new List<string>();
        List<Tuple<int, int>> charToRemove = new List<Tuple<int, int>>();
        do
        {
            input = Console.ReadLine();
            if (input == "END")
            {
                break;
            }
            else
            {
                characters.Add(input);
            }
        } while (true);

        charToRemove = CheckForPlus(toLowerAndExtend(characters));

        foreach (var pos in charToRemove)
        {
            characters[pos.Item1] = characters[pos.Item1].Remove(pos.Item2, 1).Insert(pos.Item2, " ");
        }

        foreach (string item in characters)
        {
            Console.WriteLine(item.Replace(" ",""));
        }
    }

    static List<Tuple<int, int>> CheckForPlus(List<string> characters)
    {

        List<Tuple<int, int>> results = new List<Tuple<int, int>>();
        for (int row = 0; row < characters.Count-2; row++)
        {
            for (int col = 1; col < characters[row].Length - 1; col++)
            {
                char toCheck = characters[row][col];
                if (toCheck == ' ')
                {
                    continue;
                }
                else if (characters[row][col] == toCheck && characters[row + 1][col] == toCheck && characters[row + 2][col] == toCheck && characters[row + 1][col - 1] == toCheck && characters[row + 1][col + 1] == toCheck)
                {
                    results.Add(new Tuple<int, int>(row, col));
                    results.Add(new Tuple<int, int>(row + 1, col));
                    results.Add(new Tuple<int, int>(row + 2, col));
                    results.Add(new Tuple<int, int>(row + 1, col + 1));
                    results.Add(new Tuple<int, int>(row + 1, col - 1));
                }
            }  
        }
        return results;
    }

    static List<string> toLowerAndExtend(List<string> characters)
    {
        List<string> newCharacters = new List<string>();
        int maxLength = characters.Max(s => s.Length);
        for (int i = 0; i < characters.Count; i++)
        {
            newCharacters.Add(characters[i].PadRight(maxLength, ' ').ToLower());
        }
        return newCharacters;
    }
}
