using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CountTheCoins
{
    static int coins = 0;
    static int wallhits = 0;
    static int xPos = 0;
    static int yPos = 0;
    static List<string> board = new List<string>();
    static void Main(string[] args)
    {
        for (int i = 0; i <= 3; i++)
        {
            board.Add(Console.ReadLine());
        }
        char[] commands = Console.ReadLine().ToCharArray();
        foreach (char c in commands)
        {
            Move(c);
        }

        Console.WriteLine("Coins collected:" + coins);
        Console.WriteLine("\nWalls hit:" + wallhits);

    }

    static void Move(char c)
    {
        switch (c)
        {
            case 'V':
                if (xPos + 1 > board.Count)
                {
                    wallhits++;
                break;
                }
                else if (yPos > board[xPos+1].Length-1)
                {
                    wallhits++;
                    break;
                }else
                {
                     xPos++;
                }
                if (board[xPos][yPos] == '$')
                {
                    coins++;
                }
                break;
            case '^': 
                if (xPos - 1 < 0)
                {
                    wallhits++;
                    break;
                }
                else if (yPos > board[xPos - 1].Length - 1)
                {
                    wallhits++;
                    break;
                }
                else
                {
                    xPos--;
                }
                if (board[xPos][yPos] == '$')
                {
                    coins++;
                }
                break;
            case '<':
                if (yPos - 1 < 0)
                {
                    wallhits++;
                    break;
                }
                else
                {
                    yPos--;
                }
                if (board[xPos][yPos] == '$')
                {
                    coins++;
                }
                break;
            case '>':
                if (yPos + 1 > board[xPos].Length)
                {
                    wallhits++;
                    break;
                }
                else
                {
                    yPos++;
                }
                if (board[xPos][yPos] == '$')
                {
                    coins++;
                }
                break;
            default:
                break;
        }
    }
}
