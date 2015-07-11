namespace Minesweeper.Game
{
    using System;
    using System.Collections.Generic;

    public class Commands
    {
        public static void HighScores(List<Highscore> players)
        {
            Console.WriteLine("\nPoints:");
            if (players.Count > 0)
            {
                for (int i = 0; i < players.Count; i++)
                {
                    Console.WriteLine("{0}. {1}", i + 1, players[i]);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty scoreboard!\n");
            }
        }

        public static void PlayTurn(char[,] playfield, char[,] bombs, int row, int col)
        {
            char bombCount = Count(bombs, row, col);
            bombs[row, col] = bombCount;
            playfield[row, col] = bombCount;
        }

        public static void PrintField(char[,] board)
        {
            int rows = board.GetLength(0);
            int cols = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < rows; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(board[i, j] + " ");
                }

                Console.WriteLine("|");
            }

            Console.WriteLine("   ---------------------\n");
        }

        public static char[,] CreatePlayField()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        public static char[,] PlaceBombs()
        {
            int rows = 5;
            int columns = 10;
            char[,] playfield = new char[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    playfield[i, j] = '-';
                }
            }

            List<int> bombs = new List<int>();
            while (bombs.Count < 15)
            {
                Random random = new Random();
                int number = random.Next(50);
                if (!bombs.Contains(number))
                {
                    bombs.Add(number);
                }
            }

            foreach (int number in bombs)
            {
                int column = number / columns;
                int row = number % columns;
                if (row == 0 && number != 0)
                {
                    column--;
                    row = columns;
                }
                else
                {
                    row++;
                }

                playfield[column, row - 1] = '*';
            }

            return playfield;
        }

        public static char Count(char[,] playfield, int row, int col)
        {
            int count = 0;
            int rows = playfield.GetLength(0);
            int columns = playfield.GetLength(1);

            if (row - 1 >= 0)
            {
                if (playfield[row - 1, col] == '*')
                {
                    count++;
                }
            }

            if (row + 1 < rows)
            {
                if (playfield[row + 1, col] == '*')
                {
                    count++;
                }
            }

            if (col - 1 >= 0)
            {
                if (playfield[row, col - 1] == '*')
                {
                    count++;
                }
            }

            if (col + 1 < columns)
            {
                if (playfield[row, col + 1] == '*')
                {
                    count++;
                }
            }

            if ((row - 1 >= 0) && (col - 1 >= 0))
            {
                if (playfield[row - 1, col - 1] == '*')
                {
                    count++;
                }
            }

            if ((row - 1 >= 0) && (col + 1 < columns))
            {
                if (playfield[row - 1, col + 1] == '*')
                {
                    count++;
                }
            }

            if ((row + 1 < rows) && (col - 1 >= 0))
            {
                if (playfield[row + 1, col - 1] == '*')
                {
                    count++;
                }
            }

            if ((row + 1 < rows) && (col + 1 < columns))
            {
                if (playfield[row + 1, col + 1] == '*')
                {
                    count++;
                }
            }

            return char.Parse(count.ToString());
        }
    }
}
