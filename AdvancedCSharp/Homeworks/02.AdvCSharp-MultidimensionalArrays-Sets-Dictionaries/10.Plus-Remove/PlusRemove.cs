using System;
using System.Collections.Generic;
using System.Linq;

class PlusRemove
{
    static void Main()
    {
        string input;
        List<string> characters = new List<string>();
        List<Position> charToRemove = new List<Position>();
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

        foreach (Position pos in charToRemove)
        {
            characters[pos.Row] = characters[pos.Row].Remove(pos.Col, 1).Insert(pos.Col, " ");
        }

        foreach (string item in characters)
        {
            Console.WriteLine(item.Replace(" ",""));
        }
    }

    static List<Position> CheckForPlus(List<string> characters)
    {
        
        List<Position> results = new List<Position>();
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
                    results.Add(new Position { Row = row, Col = col });
                    results.Add(new Position { Row = row + 1, Col = col });
                    results.Add(new Position { Row = row + 2, Col = col });
                    results.Add(new Position { Row = row + 1, Col = col + 1 });
                    results.Add(new Position { Row = row + 1, Col = col - 1 });
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
class Position
{
    public int Row {set;get;}
    public int Col {set;get;}
}
