namespace Minesweeper.Game
{
    using System;
    using System.Collections.Generic;

    public class Engine
    {
        private string command = string.Empty;
        private char[,] playField;
        private char[,] bombs;
        private int counter = 0;
        private bool dead = false;
        private List<Highscore> highscores;
        private int row = 0;
        private int col = 0;
        private bool welcomeMessege = true;
        private const int MaxCells = 35;
        private bool winner = false;

        public Engine()
        {
            this.Init();
        }

        private void Init()
        {
            this.highscores = new List<Highscore>(6);
            this.playField = Commands.CreatePlayField();
            this.bombs = Commands.PlaceBombs();
        }

        public void Start()
        {
            do
            {
                if (this.welcomeMessege) this.WelcomeMsg();

                Console.Write("Enter row and column: ");
                this.command = Console.ReadLine().Trim();

                if (this.command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out this.row) &&
                        int.TryParse(command[2].ToString(), out this.col) &&
                        this.row < this.playField.GetLength(0) &&
                        this.col < this.playField.GetLength(1))
                    {
                        this.command = "turn";
                    }
                }

                switch (this.command)
                {
                    case "top":
                        Commands.HighScores(highscores);
                        break;
                    case "restart":
                        this.playField = Commands.CreatePlayField();
                        this.bombs = Commands.PlaceBombs();
                        Commands.PrintField(this.playField);
                        this.dead = false;
                        this.welcomeMessege = false;
                        break;
                    case "exit":
                        break;
                    case "turn":
                            this.Turn();
                        break;
                    default:
                        Console.WriteLine("\nError! Invalid command\n");
                        break;
                }

                if (this.dead) this.OnDeath();
                if (this.winner) this.OnWin();
            }
            while (this.command != "exit");
            Console.WriteLine("Made in Bulgaria!");
            Console.WriteLine("Bye.");
        }

        private void WelcomeMsg()
        {
            Console.WriteLine(
                "Lets play Minesweeper! Your goal is to find all spaces without mines."
                + " Command \"тop\" shows the top players, \"restart\" starts new game, \"Еxit\" exits the game!");
            Commands.PrintField(this.playField);
            this.welcomeMessege = false;
        }

        private void Turn()
        {
            if (this.bombs[this.row, this.col] != '*')
            {
                if (this.bombs[this.row, this.col] == '-')
                {
                    Commands.PlayTurn(this.playField, this.bombs, this.row, this.col);
                    this.counter++;
                }

                if (MaxCells == counter)
                {
                    this.winner = true;
                }
                else
                {
                    Commands.PrintField(playField);
                }
            }
            else
            {
                this.dead = true;
            }
        }

        private void OnWin()
        {
            Console.WriteLine("\nCongratulations! You opened all cells!");
            Commands.PrintField(bombs);
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            Highscore score = new Highscore(name, this.counter);
            this.highscores.Add(score);
            Commands.HighScores(this.highscores);
            this.playField = Commands.CreatePlayField();
            this.bombs = Commands.PlaceBombs();
            this.counter = 0;
            this.winner = false;
            this.welcomeMessege = true;
        }

        private void OnDeath()
        {
            Commands.PrintField(bombs);
            Console.Write("\nBoom! Gameover with {0} points. Please enter your name: ", this.counter);
            string name = Console.ReadLine();
            Highscore score = new Highscore(name, this.counter);
            if (this.highscores.Count < 5)
            {
                this.highscores.Add(score);
            }
            else
            {
                for (int i = 0; i < this.highscores.Count; i++)
                {
                    if (this.highscores[i].Points < score.Points)
                    {   this.highscores.Insert(i, score);
                        this.highscores.RemoveAt(this.highscores.Count - 1);
                        break;
                    }
                }
            }

            this.highscores.Sort((r1, r2) => r2.Name.CompareTo(r1.Name));
            this.highscores.Sort((r1, r2) => r2.Points.CompareTo(r1.Points));
            Commands.HighScores(this.highscores);

            this.playField = Commands.CreatePlayField();
            this.bombs = Commands.PlaceBombs();
            this.counter = 0;
            this.dead = false;
            this.welcomeMessege = true;
        }
    }
}
