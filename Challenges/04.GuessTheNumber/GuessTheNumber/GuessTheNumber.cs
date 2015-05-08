using System;
using System.Collections.Generic;
using System.Threading;

class GuessTheNumber
{
    public static int winner = 0;
    static void Main()
    {
        InitConsole();
        Draw.DrawHomeScreen();
        while (true)
        {
            Console.Clear();
            initNewGame(winner);
            Console.Clear();
            Game.NewGame(winner);
            Thread.Sleep(1500);
            Console.Clear();
            if (!Continue())
            {
                break;
            }
            
        }
    }

    // Init console size
    static void InitConsole()
    {
        Console.WindowHeight = 11;
        Console.BufferHeight = 13;
        Console.WindowWidth = 60;
        Console.BufferWidth = 60;
    }

    //Init new game with all normal values and asks for a secret number based on last winner;
    static void initNewGame(int winner)
    {
        if (winner == 0)
        {
            Draw.DrawAt(11, 4, "Please wait CPU is selecting a number...", ConsoleColor.Red);
            Thread.Sleep(AI.rnd.Next(1000,4000));
            AI.thinkNumber();
        }
        else
        {
            Draw.DrawAt(Console.WindowWidth / 2 - 13, 4, "Enter your secret number!", ConsoleColor.Red);
            Judge.SetNumber(Draw.enterNumber());
            AI.min = 1;
            AI.max = 101;
            AI.lastNum.Clear();
        }
        Game.lifes = 7;
        Draw.bigger = 2;
        Draw.smaller = 2;
        Game.guessed = false;
    }

    // Ask if you want another game;
    static bool Continue()
    {
        Draw.DrawAt(Console.WindowWidth / 2 - 13, 1, "Do you want to play again?", ConsoleColor.Yellow);
        Draw.DrawAt(Console.WindowWidth / 2 - 21, 2, "Press 'N' to exit, any other key for new game!", ConsoleColor.Yellow);
        Console.SetCursorPosition(Console.WindowWidth / 2, 4);
        ConsoleKeyInfo key = Console.ReadKey();
        if (key.Key == ConsoleKey.N)
        {
            Console.Clear();
            Draw.DrawAt(Console.WindowWidth / 2 - 9, Console.WindowHeight / 2 - 1, "Guess the Number", ConsoleColor.Red);
            Draw.DrawAt(Console.WindowWidth / 2 - 5, Console.WindowHeight / 2 + 1, "Good Bye", ConsoleColor.Green);
            Thread.Sleep(1000);
            Console.SetCursorPosition(0, Console.WindowHeight - 1);
            return false;
        }
        return true;
    }
}

public static class AI
{
    public static int min = 1;
    public static int max = 100;
    public static List<int> lastNum = new List<int>();
    public static Random rnd = new Random();
    // Set the secret number if its cpus turn
    public static void thinkNumber()
    {
        Judge.SetNumber(rnd.Next(1, 101));
    }
    // AI Guess
    public static void guess()
    {
        if (min < 1)
        {
            min = 1;
        }
        else if (max > 101)
        {
            max = 101;
        }
        int x = rnd.Next(min, max);
        while (lastNum.Contains(x))
        {
            x = rnd.Next(min, max);
        }
        lastNum.Add(x);
        Thread.Sleep(rnd.Next(500, 3000));
        Draw.enterNumber(x);
        Thread.Sleep(500);
        Draw.ClearFromTo(24, 3, 36, 3);
        string tips = Judge.checkGuessAI(x);
        switch (tips)
        {
            case "-5": max = x - 1; min = x - 6;
                break;
            case "-10": max = x - 2; min = x - 20;
                break;
            case "-": max = x - 3;
                break;
            case "+5": min = x + 1; max = x + 6;
                break;
            case "+10": min = x + 2; max = x + 20;
                break;
            case "+": min = x + 3;
                break; 
            default:
                break;
        }
    }
}

// Judge class, sends hints, keeps the secret number
public static class Judge
{
    private static int secretNumber;
    // Set the secret number
    public static void SetNumber(int x)
    {
        secretNumber = x;
    }

    // Check if the AI guess is right, otherwise return hints as strings
    public static string checkGuessAI(int x)
    {
        if (x == secretNumber)
        {
            Game.guessed = true;
            return string.Empty;
        }
        else if (x > secretNumber)
        {
            if (x - secretNumber <= 5)
            {
                checkGuess(x);
                return "-5";
            }
            else if (x - secretNumber <= 15)
            {
                checkGuess(x);
                return "-10";
            }
            else
            {
                checkGuess(x);
                return "-";
            }
        }
        else
        {
            if (secretNumber - x <= 5)
            {
                checkGuess(x);
                return "+5";
            }
            else if (secretNumber - x <= 15)
            {
                checkGuess(x);
                return "+10";
            }
            else
            {
                checkGuess(x);
                return "+";
            }
        }
    }

    // Checks guess and Draws hints on the screen
    public static void checkGuess(int x)
    {
        if (x == secretNumber)
        {
            Game.guessed = true; // Toggle the winning condition
        }
        else if (x > secretNumber)
        {
            if (x - secretNumber <= 5)
            {
                Draw.DrawGuess(false, x);
                Draw.DrawHints("Hot");
            }
            else if (x - secretNumber <= 15)
            {
                Draw.DrawGuess(false, x);
                Draw.DrawHints("Warm");
            }
            else
            {
                Draw.DrawGuess(false, x);
                Draw.DrawHints("Cold");
            }
        }
        else
        {
            if (secretNumber - x <= 5)
            {
                Draw.DrawGuess(true, x);
                Draw.DrawHints("Hot");
            }
            else if (secretNumber - x <= 15)
            {
                Draw.DrawGuess(true, x);
                Draw.DrawHints("Warm");
            }
            else
            {
                Draw.DrawGuess(true, x);
                Draw.DrawHints("Cold");
            }
        }
    }
}

// Gameplay class
static class Game
{
    public static bool guessed = false; // Toggle on right answer 
    public static int lifes = 7;

    // Starts new game based on last winner (0 - player , 1 - cpu)
    public static void NewGame(int player)
    {
        Draw.DrawBoard();

        if (player == 0)
        {
            while (lifes != 0)
            {
                Draw.DrawLifes(lifes);
                Judge.checkGuess(Draw.enterNumber());
                if (guessed)
                {
                    Draw.DrawWinScreen();
                    break;
                }
                lifes--;
            }
        }
        else
        {
            while (lifes != 0)
            {
                Console.CursorVisible = false;
                Draw.DrawLifes(lifes);
                AI.guess();
                if (guessed)
                {
                    Draw.DrawWinScreen();
                    Console.CursorVisible = true;
                    break;
                }
                lifes--;
            }
            Console.CursorVisible = true;
        }
        
        if (!guessed)
        {
            Draw.DrawLoseScreen();
            GuessTheNumber.winner = GuessTheNumber.winner == 0 ? 1 : 0;  // After someone loses swap places;
        }
    }
}

static class Draw
{
    // Draw at position without color
    public static void DrawAt(int row, int col, object obj)
    {
        Console.SetCursorPosition(row, col);
        Console.Write(obj.ToString());
    }

    // Draw at position with color
    public static void DrawAt(int row, int col, object obj,ConsoleColor clr)
    {
        Console.ForegroundColor = clr;
        DrawAt(row, col, obj);
        Console.ForegroundColor = ConsoleColor.White;
    }

    // Draw lifes at board
    public static void DrawLifes(int lifes)
    {
        DrawAt(Console.WindowWidth / 2-1, Console.WindowHeight - 2, ' ');
        DrawAt(Console.WindowWidth / 2-1, Console.WindowHeight - 2, lifes,ConsoleColor.Red);
    }


    /// <summary>
    /// Guess check
    /// </summary>
    /// <param name="guess">number(for AI) or blank for Player</param>
    /// <returns>integer(pass it over to the Judge for check and hints)</returns>
    public static int enterNumber(int guess = 0)
    {
        ClearFromTo(26, 3, 36, 3);
        Console.SetCursorPosition(29, 3);
        
        int x = guess;
        if (guess == 0)
        {
            do
            {
                if (int.TryParse(Console.ReadLine(), out x))
                {
                    if (x > 100 || x < 1)
                    {
                        DrawAt(24, 3, "Wrong Input");
                        Thread.Sleep(500);
                        ClearFromTo(24, 3, 36, 3);
                        Console.SetCursorPosition(28, 3);
                        continue;
                    }
                    break;
                }
                else
                {
                    DrawAt(24, 3, "Wrong Input");
                    Thread.Sleep(500);
                    ClearFromTo(24, 3, 36, 3);
                    Console.SetCursorPosition(29, 3);
                }
            } while (true);
        }
        else
        {
            ClearFromTo(26, 3, 36, 3);
            Console.SetCursorPosition(29, 3);
            DrawAt(29, 3, x);
        }
        return x;
    }

    /// <summary>
    /// Clears selected area
    /// </summary>
    /// <param name="x">starting point(col)</param>
    /// <param name="y">starting point(row)</param>
    /// <param name="tx">ending point(col)</param>
    /// <param name="ty">ending point(row)</param>
    public static void ClearFromTo(int x, int y, int tx, int ty)
    {
        for (int i = x; i <= tx; i++)
        {
            for (int z = y; z <= ty; z++)
            {
                DrawAt(i, z, ' ');
            }
        }
    }

    // Draw winner screen
    public static void DrawWinScreen()
    {
        Console.Clear();
        DrawAt(Console.WindowWidth / 2 - 6,Console.WindowHeight / 2 , "You are right!",ConsoleColor.Green);
    }

    // Draw loser screen
    public static void DrawLoseScreen()
    {
        Console.Clear();
        DrawAt(Console.WindowWidth / 2 - 5, Console.WindowHeight / 2, "You failed!",ConsoleColor.DarkMagenta);
    }

    // Init board based on last winner
    public static void DrawBoard()
    {
        int x = GuessTheNumber.winner;
        string TopBottomBorder = new string('*', 59);
        string otherBorders = "*" + new string(' ', 18) + "*" + new string(' ', 19) + "*" + new string(' ', 18) + "*";
        DrawAt(0, 0, TopBottomBorder);
        for (int i = 1; i < 10; i++)
        {
            DrawAt(0, i, otherBorders);
        }
        DrawAt(x == 0 ? 3 : 43, 1, string.Format("Guessing: {0}",x == 0? "You":"CPU"), ConsoleColor.DarkGreen);
        DrawAt(21, 2, "Enter your guess:", ConsoleColor.DarkGreen);
        DrawAt(Console.WindowWidth / 2-3, Console.WindowHeight - 3, "Tries:");
        DrawAt(0, 10, TopBottomBorder);
    }

    // Draw hints bassed on "judge" tip
    public static void DrawHints(string guess)
    {        
        ClearFromTo(24, 1, 34, 1);
        switch (guess)
        {
            case "Warm": DrawAt(28, 1, guess, ConsoleColor.DarkRed);
                break;
            case "Hot": DrawAt(29, 1, guess, ConsoleColor.Red);
                break;
            case "Cold": DrawAt(28, 1, guess, ConsoleColor.DarkCyan);
                break;
            default:
                break;
        }
       
    }

    // Draws tips on the sides depending if the number is bigger or smaller
    public static int bigger = 2;
    public static int smaller = 2;
    public static void DrawGuess(bool isBigger, int guess)
    {
        if (isBigger)
        {
            DrawAt(4,bigger,string.Format("Bigger than {0}",guess),ConsoleColor.Red);
            bigger++;
        }
        else
        {
            DrawAt(42, smaller, string.Format("Lesser than {0}", guess),ConsoleColor.Green);
            smaller++;
        }
    }

    // Draw Home Screen
    public static void DrawHomeScreen()
    {
        Console.Clear();
        DrawAt(Console.WindowWidth / 2 - 8, 2, "Guess the Number", ConsoleColor.Red);
        DrawAt(Console.WindowWidth / 2 - 3, 4, "Rules");
        DrawAt(7, 6, "You have 7 tries to guess your oponents number", ConsoleColor.Cyan);
        DrawAt(2, 7, "The Judge will give you hints every time you guess wrong", ConsoleColor.Cyan);
        DrawAt(3, 8, "If you win you guess again, if you lose you swap roles", ConsoleColor.Cyan);
        DrawAt(Console.WindowWidth / 2 - 12, 10, "Press any key to start...", ConsoleColor.Gray);
        Console.ReadKey();
    }
}
