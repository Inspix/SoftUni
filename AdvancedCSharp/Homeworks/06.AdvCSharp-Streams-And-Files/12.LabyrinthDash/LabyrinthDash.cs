using System;
using System.Collections.Generic;

class LabyrinthDash
{
    private static List<char[]> labyrinth = new List<char[]>();
    private static int x;
    private static int y;
    private static int lifes = 3;
    private static int movesMade = 0;
    private static bool fellOff;
    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());
        for (int i = 0; i < rows; i++)
        {
            labyrinth.Add(Console.ReadLine().Replace('\t',' ').Replace('\n',' ').ToCharArray());
        }
        string Movements = Console.ReadLine();

        for (int i = 0; i < Movements.Length; i++)
        {
            if (fellOff) break;
            if (lifes == 0) break;
            Move(Movements[i]);
        }
        if (fellOff)
        {
            Console.WriteLine("Fell off a cliff! Game Over!");
        }
        if (lifes == 0)
        {
            Console.WriteLine("No lives left! Game Over!");
        }
        Console.WriteLine("Total moves made: {0}",movesMade);
    }

    static bool checkMove(char c)
    {
        switch (c)
        {
            case '_':
                Console.WriteLine("Bumped a wall.");
                return false;
            case '|':
                Console.WriteLine("Bumped a wall.");
                return false;
            case '@':
                lifes--;
                movesMade++;
                Console.WriteLine("Ouch! That hurt! Lives left: {0}", lifes);
                return true;
            case '*':
                lifes--;
                movesMade++;
                Console.WriteLine("Ouch! That hurt! Lives left: {0}", lifes);
                return true;
            case '#':
                lifes--;
                movesMade++;
                Console.WriteLine("Ouch! That hurt! Lives left: {0}", lifes);
                return true;
            case '$':
                lifes++;
                movesMade++;
                Console.WriteLine("Awesome! Lives left: {0}", lifes);
                return true;
            case ' ':
                movesMade++;
                fellOff = true;
                return true;
            case '.':
                movesMade++;
                Console.WriteLine("Made a move!");
                return true;
            default:
                return false;
        }
    }

    static void Move(char c)
    {
        try
        {
            switch (c)
            {
                case '<':
                    if (checkMove(labyrinth[x][y - 1]))
                    {
                        y--;
                        if (labyrinth[x][y] == '$')
                        {
                            labyrinth[x][y] = '.';
                        }
                    }
                    break;
                case '>':
                    if (checkMove(labyrinth[x][y + 1]))
                    {
                        y++;
                        if (labyrinth[x][y] == '$')
                        {
                            labyrinth[x][y] = '.';
                        }
                    }
                    break;
                case '^':
                    if (checkMove(labyrinth[x - 1][y]))
                    {
                        x--;
                        if (labyrinth[x][y] == '$')
                        {
                            labyrinth[x][y] = '.';
                        }
                    }
                    break;
                case 'v':
                    if (checkMove(labyrinth[x + 1][y]))
                    {
                        x++;
                        if (labyrinth[x][y] == '$')
                        {
                            labyrinth[x][y] = '.';
                        }
                    }
                    break;
            }
        }
        catch (Exception)
        {
            fellOff = true;
            movesMade++;
        }
        
    }
}