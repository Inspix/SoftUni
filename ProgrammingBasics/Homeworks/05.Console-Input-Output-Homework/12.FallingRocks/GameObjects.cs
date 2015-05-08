using System;
using System.Collections.Generic;
using System.Threading;
using IrrKlang;

namespace FallingRocks
{
    internal class GameObjects
    {
        #region PlayerObject

        public static Player P1 = new Player()
        {
            row = Draw.GameHeight - 1,
            col = Draw.GameWidth / 2,
            look = "\u231E\u267E\u231F",
            clr = ConsoleColor.White
        };

        #endregion PlayerObject

        //Variables to tinker with
        //uncomment for music
        public static IrrKlang.ISoundEngine x = new ISoundEngine();

        public static double musicSpeed = 0.7;
        public static bool playSound = true;
        public static bool colisionEnabled = true;

        public static string[] rocksChar = new string[]
        {
            "@","\u2311","\u2314","\u25CF","\u25C8","\u2617","\u25D9","\u2588"
        };

        //Rock manipulation
        public static List<Rock> rocks = new List<Rock>();

        public static void MoveRocks()
        {
            List<Rock> newRocks = new List<Rock>();

            for (int i = 0; i < rocks.Count; i++)
            {
                Rock newR = rocks[i];
                newR.Row++;
                if (colision(newR.Row, newR.Col)) // Call for colision check
                {
                    if (Score.gotPowerUp(newR.RockType))
                    {
                        //just skiping death
                    }
                    else
                    {
                        Score.DrawDeathScreen(); //On getting hit call deathscreen
                        break;
                    }
                }
                if (newR.Row >= Draw.GameHeight)
                {
                    Score.addScore(newR.RockType); //Add to score, based on a pased rock type
                }
                if (newR.Row < Draw.GameHeight) //Add new rock coordinates
                {
                    newRocks.Add(newR);
                }
            }
            rocks = newRocks; //Clear unused rocks and give new coordinates
        }

        /// <summary>
        /// checks for colision with the Player(P1)
        /// </summary>
        /// <param name="row">Row of the rock</param>
        /// <param name="col">Col of the rock</param>
        /// <returns>Returns true if there's a colision</returns>
        public static bool colision(int row, int col)
        {
            if (!colisionEnabled)
            {
                return false;
            }
            if (row == GameObjects.P1.row && (col == GameObjects.P1.col + 1 || col == GameObjects.P1.col + 2 || col == GameObjects.P1.col))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Player controller
        /// </summary>
        /// <param name="key">Key pressed</param>
        public static void MovePlayer(ConsoleKeyInfo key)
        {
            if (key.Key == ConsoleKey.LeftArrow)
            {
                if (P1.col - 1 > 0)
                {
                    P1.col--;
                }
            }
            if (key.Key == ConsoleKey.RightArrow)
            {
                if (P1.col + 1 < Draw.GameWidth - 2)
                {
                    P1.col++;
                }
            }
        }

        public static void MenuMove(ConsoleKeyInfo key)
        {
            if (key.Key == ConsoleKey.UpArrow)
            {
                if (Draw.menuIndex == 1)
                {
                    Console.Beep(2000, 50);
                }
                else
                {
                    Draw.menuIndex--;
                }
            }
            if (key.Key == ConsoleKey.DownArrow)
            {
                if (Draw.menuIndex == 4)
                {
                    Console.Beep(1000, 50);
                }
                else
                {
                    Draw.menuIndex++;
                }
            }
            if (key.Key == ConsoleKey.B)
            {
                Game.rules = false;
                Game.cleared = true;
                Draw.clearWholeField(15);
                Thread.Sleep(10);
                Draw.drawMenuItems();
            }
            if (key.Key == ConsoleKey.Enter)
            {
                if (Draw.menuIndex == 4)
                {
                    Environment.Exit(0);
                }
                if (Draw.menuIndex == 3)
                {
                    if (!playSound)
                    {
                        Draw.musicState = "Music on";
                        playSound = true;
                        music();
                    }
                    else
                    {
                        Draw.musicState = "Music off";
                        playSound = false;
                        music();
                    }
                }
                if (Draw.menuIndex == 2)
                {
                    Game.rules = true;
                }
                if (Draw.menuIndex == 1)
                {
                    Score.newGame();
                    Game.menuThread = true;
                    Game.GamePlay();
                }
            }
        }

        /// <summary>
        /// Music on death
        /// </summary>
        public static void deathMusic()
        {
            if (playSound)
            {
                Console.Beep(784, (int)(600 * musicSpeed));
                Console.Beep(784, (int)(600 * musicSpeed));
                Console.Beep(784, (int)(600 * musicSpeed));
                Console.Beep(622, (int)(450 * musicSpeed));
                Console.Beep(938, (int)(150 * musicSpeed));
                Console.Beep(784, (int)(600 * musicSpeed));
                Console.Beep(622, (int)(450 * musicSpeed));
                Console.Beep(938, (int)(150 * musicSpeed));
                Console.Beep(784, (int)(1200 * musicSpeed));
                Console.Beep(1174, (int)(600 * musicSpeed));
                Console.Beep(1174, (int)(600 * musicSpeed));
                Console.Beep(1174, (int)(600 * musicSpeed));
                Console.Beep(1245, (int)(450 * musicSpeed));
                Console.Beep(938, (int)(150 * musicSpeed));
                Console.Beep(784, (int)(600 * musicSpeed));
                Console.Beep(622, (int)(450 * musicSpeed));
                Console.Beep(960, (int)(150 * musicSpeed));
                Console.Beep(784, (int)(1200 * musicSpeed));
            }
        }

        public static void music()
        {
            Console.SetCursorPosition(30, 25);
            if (playSound)
            {
                //Uncomment and change file name if you want background music
                x.Play2D("01Kinesis.mp3", true);
            }
            else
            {
                x.StopAllSounds();
            }
        }
    }

    //Rock class (i have no idea what i'm doin :D
    public class Rock
    {
        public int Col { get; set; }

        public int Row { get; set; }

        public string RockType { get; set; }

        public ConsoleColor Clr { get; set; }

        //Rock initialise
        public Rock(int row, int col, string rockType, ConsoleColor clr)
        {
            Col = col;
            Row = row;
            RockType = rockType;
            Clr = clr;
        }

        //Rock copy;
        public Rock(Rock x)
        {
            Col = x.Col;
            Row = x.Row;
            RockType = x.RockType;
            Clr = x.Clr;
        }

        /// <summary>
        /// Gives random rock and random powerups based on chance
        /// </summary>
        /// <returns>Returns a Rock</returns>
        public static Rock randomRock()
        {
            int chance = Game.rnd.Next(0, 301);
            Rock x = new Rock(6, Game.rnd.Next(1, Draw.GameWidth),
                GameObjects.rocksChar[Game.rnd.Next(0, GameObjects.rocksChar.Length)],
                (ConsoleColor)Game.rnd.Next(2, 16));
            if (chance < 15)
            {
                x.Clr = ConsoleColor.Yellow;
                x.RockType = "\u21AC"; //Speed up power up
            }
            else if (chance > 15 && chance < 30)
            {
                x.Clr = ConsoleColor.Blue;
                x.RockType = "\u21EA"; //Multiplier powerup;
            }
            else if (chance > 30 && chance < 33)
            {
                x.Clr = ConsoleColor.Red;
                x.RockType = "\u2665"; //Life;
            }
            else if (chance > 33 && chance < 36)
            {
                x.Clr = ConsoleColor.DarkYellow;
                x.RockType = "\u273E"; //Invincibility;
            }
            else if (chance > 36 && chance < 38)
            {
                x.Clr = ConsoleColor.Black;
                x.RockType = "\u2620"; //Death (-3 lifes)
            }
            else if (chance > 38 && chance < 48)
            {
                x.Clr = ConsoleColor.Yellow;
                x.RockType = "\u21AB"; //Slow down
            }
            else if (chance > 48 && chance < 58)
            {
                x.Clr = ConsoleColor.Cyan;
                x.RockType = "\u2744"; //Freeze
            }
            else if (chance > 190 && chance < 199)
            {
                x.Clr = ConsoleColor.Magenta;
                x.RockType = "\u2622"; //Clear Rocks
            }
            else if (chance > 299)
            {
                x.Clr = ConsoleColor.Red;
                x.RockType = "\u2661"; //Better heart
            }
            return x;
        }
    }

    //Struct for the player character
    public struct Player
    {
        public int row;
        public int col;
        public string look;
        public ConsoleColor clr;
    }
}