using System;
using System.Collections.Generic;

namespace FallingRocks
{
    internal class Score
    {
        public const string Startinglifes = "\u2665\u2665\u2665\u2665\u2665";
        public static string lifes = new string('\u2665', 5);
        public static string lifes2 = "";
        public static string lifes3 = "";
        public static double points = 0;
        public static int level = 1;
        public static double multiplier = 1;
        public static int diffSpeed = Game.dSpeed;
        public static double scoreJump = 1;
        public static Dictionary<string, int> effects = new Dictionary<string, int>();
        public static Dictionary<string, string> powerUps = new Dictionary<string, string>();

        /// <summary>
        /// Draw the Scoreboard items
        /// </summary>
        public static void DrawScoreBoard()
        {
            Draw.DrawAt(1, 3, "Lifes");
            Draw.DrawAt(2, 3, lifes, ConsoleColor.Red);
            Draw.DrawAt(3, 3, lifes2, ConsoleColor.Red);
            Draw.DrawAt(4, 3, lifes3, ConsoleColor.Red);
            Draw.DrawAt(1, 10, "Score");
            Draw.DrawAt(2, 10, Math.Round(points, 2), ConsoleColor.DarkYellow);
            Draw.DrawAt(1, 18, "Power Ups");
            Draw.DrawAt(1, 28, "Level");
            Draw.DrawAt(2, 28, level, ConsoleColor.Gray);
        }

        //Redraw only the score
        public static void RedrawScore()
        {
            Draw.DrawAt(2, 10, string.Format("{0:0.00}", points), ConsoleColor.DarkYellow);
        }

        //Init new game
        public static void newGame()
        {
            points = 0;
            lifes = Startinglifes;
            lifes2 = "";
            lifes3 = "";
            level = 1;
            Game.frequency = Game.dFrequency;
            Game.speed = Game.dSpeed;
            diffSpeed = Game.dSpeed;
        }

        //Scalling difficulty
        public static void difficulty()
        {
            if (level % 2 == 1 && Score.points >= scoreJump)
            {
                level++;
                scoreJump *= 2;
                Draw.DrawAt(2, 28, level, ConsoleColor.Gray);
                Draw.DrawAt(3, 26, "NL:" + scoreJump, ConsoleColor.Gray);
                if (Game.speed - 10 >= 1)
                {
                    Game.speed -= 10;
                    diffSpeed -= 10;
                }
            }
            if (level % 2 == 0 && Score.points >= scoreJump)
            {
                level++;
                scoreJump *= 2;
                Draw.DrawAt(2, 28, level, ConsoleColor.Gray);
                Draw.DrawAt(3, 26, "NL:" + scoreJump, ConsoleColor.Gray);
                if (Game.frequency > 1)
                {
                    Game.frequency--;
                }
            }
        }

        //Print death screen when you lose a life the pernament Label is intentional
        public static void DrawDeathScreen()
        {
            Console.Clear();
            GameObjects.rocks.Clear();
            Draw.DrawBorders();
            loseLifes(1);
            Score.DrawScoreBoard();
            Draw.DrawAt(Draw.GameHeight / 2, (Draw.GameWidth - 6) / 2, "YOU DIED!", ConsoleColor.Red);
            GameObjects.deathMusic();
        }

        //Print XLdeath screen when you collect an invisible skull a life the pernament Label is intentional
        public static void DrawExtraDeathScreen()
        {
            Console.Clear();
            GameObjects.rocks.Clear();
            Draw.DrawBorders();
            loseLifes(3);
            Score.DrawScoreBoard();
            Draw.DrawAt(Draw.GameHeight / 2, (Draw.GameWidth - 6) / 2, "YOU DIED!", ConsoleColor.Red);
            Draw.DrawAt((Draw.GameHeight / 2) + 1, (Draw.GameWidth - 6) / 2, "Horribly!", ConsoleColor.Red);
            GameObjects.deathMusic();
        }

        //Add lifes
        public static void addLifes()
        {
            if (lifes.Length < 5)
            {
                lifes = lifes + "\u2665";
            }
            else if (lifes2.Length < 5)
            {
                lifes2 = lifes2 + "\u2665";
            }
            else if (lifes3.Length < 5)
            {
                lifes3 = lifes3 + "\u2665";
            }
            DrawScoreBoard();
        }

        //take away lifes
        public static void loseLifes(int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (lifes3.Length > 0)
                {
                    lifes3 = lifes3.Remove(lifes3.Length - 1);
                }
                else if ((lifes2.Length > 0))
                {
                    lifes2 = lifes2.Remove(lifes2.Length - 1);
                }
                else if ((lifes.Length > 0))
                {
                    lifes = lifes.Remove(lifes.Length - 1);
                }
            }
        }

        //Score values of different rocks
        public static void addScore(string x)
        {
            switch (x)
            {
                case "\u2311": points += 0.01 * multiplier;
                    break;

                case "\u2314": points += 0.02 * multiplier;
                    break;

                case "\u25CF": points += 0.03 * multiplier;
                    break;

                case "\u25C8": points += 0.04 * multiplier;
                    break;

                case "\u2617": points += 0.05 * multiplier;
                    break;

                case "\u25D9": points += 0.06 * multiplier;
                    break;

                case "\u2588": points += 0.07 * multiplier;
                    break;
            }
        }

        //Check if you are hit by a powerup and pass its effects to powerUpEffects();
        public static bool gotPowerUp(string x)
        {
            switch (x)
            {
                case "\u21EA": { powerUpEffects(50, x); return true; } //Points Up
                case "\u21AC": { powerUpEffects(20, x); return true; } //Speed Up
                case "\u2622": { powerUpEffects(1, x); return true; } //Clear rocks
                case "\u2665": { addLifes(); return true; } //Life up
                case "\u273E": { powerUpEffects(15, x); return true; } //Invincibility
                case "\u2620": { DrawExtraDeathScreen(); return true; } //Death
                case "\u21AB": { powerUpEffects(20, x); return true; }//Slow down
                case "\u2744": { powerUpEffects(15, x); return true; }//freeze
                case "\u2661": { addLifes(); addLifes(); return true; }//XLife up
                default: return false;
            }
        }

        //Add powerup effects to the effects list and add its duration
        public static void powerUpEffects(int duration, string effect)
        {
            if (effects.ContainsKey(effect))
            {
                effects[effect] += duration;
            }
            else
            {
                effects.Add(effect, duration);
            }
        }

        /// <summary>
        /// Show powerup icons on screen while adding its effect
        /// </summary>
        public static void initPowerUps()
        {
            Dictionary<string, int> newEffects = new Dictionary<string, int>();
            foreach (KeyValuePair<string, int> i in effects)
            {
                #region PointsUpEffect

                if (i.Key == "\u21EA" && i.Value != 0) // points up
                {
                    Draw.DrawAt(2, 18, '\u21EA', ConsoleColor.Blue);
                    multiplier = 10;
                    newEffects.Add(i.Key, i.Value - 1);
                }
                else if (i.Key == "\u21EA" && i.Value == 0)
                {
                    Draw.DrawAt(2, 18, ' ');
                    multiplier = 1;
                }

                #endregion PointsUpEffect

                #region SpeedUpEffect

                if (i.Key == "\u21AC" && i.Value != 0)
                {
                    Draw.DrawAt(2, 19, '\u21AC', ConsoleColor.Yellow);//Speed Up
                    if (Game.speed - 10 >= 1)
                    {
                        Game.speed -= 10;
                    }
                    newEffects.Add(i.Key, i.Value - 1);
                }
                else if (i.Key == "\u21AC" && i.Value == 0)
                {
                    Draw.DrawAt(2, 19, ' ');
                    Game.speed = diffSpeed;
                }

                #endregion SpeedUpEffect

                #region SlowDownEffect

                if (i.Key == "\u21AB" && i.Value != 0)// Slow Down
                {
                    Draw.DrawAt(3, 19, '\u21AB', ConsoleColor.Yellow);
                    Game.speed += 10;
                    newEffects.Add(i.Key, i.Value - 1);
                }
                else if (i.Key == "\u21AB" && i.Value == 0)
                {
                    Draw.DrawAt(3, 19, ' ');
                    Game.speed = diffSpeed;
                }

                #endregion SlowDownEffect

                #region ClearRocksEffect

                if (i.Key == "\u2622" && i.Value != 0)
                {
                    Draw.DrawAt(2, 20, '\u2622', ConsoleColor.Magenta);//Clear rocks
                    GameObjects.rocks.Clear();
                    Draw.clearWholeField(6);
                    newEffects.Add(i.Key, i.Value - 1);
                }
                else if (i.Key == "\u2622" && i.Value == 0)
                {
                    Draw.DrawAt(2, 20, ' ');
                }

                #endregion ClearRocksEffect

                #region InvincibilityEffect

                if (i.Key == "\u273E" && i.Value != 0)
                {
                    Draw.DrawAt(2, 21, '\u273E', ConsoleColor.DarkYellow);//Invincibility
                    if (GameObjects.colisionEnabled)
                    {
                        GameObjects.P1.clr = ConsoleColor.DarkGray;
                        GameObjects.colisionEnabled = false;
                    }
                    newEffects.Add(i.Key, i.Value - 1);
                }
                else if (i.Key == "\u273E" && i.Value == 0)
                {
                    GameObjects.P1.clr = ConsoleColor.White;
                    Draw.DrawAt(2, 21, ' ');
                    GameObjects.colisionEnabled = true;
                }

                #endregion InvincibilityEffect

                #region FreezeEffect

                if (i.Key == "\u2744" && i.Value != 0)//Freeze
                {
                    Draw.DrawAt(3, 18, '\u2744', ConsoleColor.Cyan);
                    if (Draw.drawingEnabled)
                    {
                        Draw.drawingEnabled = false;
                    }
                    newEffects.Add(i.Key, i.Value - 1);
                }
                else if (i.Key == "\u2744" && i.Value == 0)
                {
                    Draw.clearWholeField(6);
                    Draw.drawingEnabled = true;
                    Draw.DrawAt(3, 18, ' ');
                }

                #endregion FreezeEffect

                effects = newEffects;
            }
        }
    }
}