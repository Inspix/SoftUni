using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PokerStreight
{
    public static char[] suits = { 'C', 'D', 'H', 'S' };
    public static int weight;
    public static List<string> results = new List<string>();
    static void Main(string[] args)
    {
        weight = int.Parse(Console.ReadLine());
        GenerateSuits();
        Console.WriteLine(results.Count);
    }

    public static void GenerateSuits()
    {
        string toCheck = string.Empty;
        for (int i = 1; i <=10; i++)
        {
            for (int a = 0; a < 4; a++)
            {
                for (int b = 0; b < 4; b++)
                {
                    for (int c = 0; c < 4; c++)
                    {
                        for (int d = 0; d < 4; d++)
                        {
                            for (int e = 0; e < 4; e++)
                            {
                                toCheck = StreightGenerator(i).Replace('a', suits[a])
                                                              .Replace('b', suits[b])
                                                              .Replace('c', suits[c])
                                                              .Replace('d', suits[d])
                                                              .Replace('e', suits[e]);
                                if (WeightCheck(toCheck))
                                {
                                    results.Add(toCheck);
                                }
                            }
                        }
                    }
                }
            }
        }
    }

    public static string StreightGenerator(int type)
    {
        switch (type)
        {
            case 1: return "Aa 2b 3c 4d 5e";
            case 2: return "2a 3b 4c 5d 6e";
            case 3: return "3a 4b 5c 6d 7e";
            case 4: return "4a 5b 6c 7d 8e";
            case 5: return "5a 6b 7c 8d 9e";
            case 6: return "6a 7b 8c 9d 10e";
            case 7: return "7a 8b 9c 10d Je";
            case 8: return "8a 2b 3c 4d 5e";
            case 9: return "9a 2b 3c 4d 5e";
            case 10: return "10a Jb Qc Kd Ae";
            default: return "";
        }
    }

    public static bool WeightCheck(string x)
    {
        string[] cards = x.Split(' ');
        int cardN = 1;
        int weightResult = 0;
        foreach (string item in cards)
        {
            foreach (char c in item)
	        {
		         switch (c)
                 {
                     case 'A': if (cardN == 1)
                         {
                             weightResult += (1 * (cardN * 10));
                         }
                         else
                         {
                             weightResult += (14 * (cardN * 10));
                         }
                         break;
                     case '2': weightResult += 2 * (cardN * 10);
                         break;
                     case '3': weightResult += 3 * (cardN * 10);
                         break;
                     case '4': weightResult += 4 * (cardN * 10);
                         break;
                     case '5': weightResult += 5 * (cardN * 10);
                         break;
                     case '6': weightResult += 6 * (cardN * 10);
                         break;
                     case '7': weightResult += 7 * (cardN * 10);
                         break;
                     case '8': weightResult += 8 * (cardN * 10);
                         break;
                     case '9': weightResult += 9 * (cardN * 10);
                         break;
                     case '1': weightResult += 10 * (cardN * 10);
                         break;
                     case 'J': weightResult += 11 * (cardN * 10);
                         break;
                     case 'Q': weightResult += 12 * (cardN * 10);
                         break;
                     case 'K': weightResult += 13 * (cardN * 10);
                         break;
                     case 'C': weightResult += 1;
                         break;
                     case 'D': weightResult += 2;
                         break;
                     case 'H': weightResult += 3;
                         break;
                     case 'S': weightResult += 4;
                         break;
                     default: weightResult += 0;
                         break;
                 }
	        }
            cardN++;
            
        }
        return weightResult == weight;
        
    }
}
 