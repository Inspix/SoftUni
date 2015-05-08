using System;
using System.Text;
using System.Threading;

namespace FallingRocks
{
    public class Draw
    {
        public const int PlayableAreaHeight = 25;
        public const int PlayableAreaWidth = 35;
        public const int MenuHeight = 5;
        public const int GameHeight = PlayableAreaHeight + MenuHeight + 3;
        public const int GameWidth = PlayableAreaWidth + 2;
        public const char BorderChar = '\u2551';
        public const ConsoleColor borderColor = ConsoleColor.DarkCyan;

        public static int menuIndex = 1;
        public static string musicState = "Music on";
        public static bool drawingEnabled = true;

        /// <summary>
        /// Draw method
        /// </summary>
        /// <param name="row">Row to draw on</param>
        /// <param name="col">Column to draw on</param>
        /// <param name="toDraw">Object to draw</param>
        public static void DrawAt(int row, int col, object toDraw)
        {
            Console.SetCursorPosition(col, row);
            Console.Write(toDraw);
        }

        /// <summary>
        /// Draw method with color
        /// </summary>
        /// <param name="row">row to draw on</param>
        /// <param name="col">column to draw on</param>
        /// <param name="toDraw">object to draw</param>
        /// <param name="clr">color to draw with</param>
        public static void DrawAt(int row, int col, object toDraw, ConsoleColor clr)
        {
            Console.ForegroundColor = clr;
            Console.SetCursorPosition(col, row);
            Console.Write(toDraw);
            Console.ForegroundColor = ConsoleColor.White;
        }

        /// <summary>
        /// Draw method with both console colors
        /// </summary>
        /// <param name="row">Row to Draw on</param>
        /// <param name="col">Column to draw on</param>
        /// <param name="toDraw">Object to draw</param>
        /// <param name="clr">foreground color</param>
        /// <param name="bclr">background color</param>
        public static void DrawAt(int row, int col, object toDraw, ConsoleColor clr, ConsoleColor bclr)
        {
            Console.ForegroundColor = clr;
            Console.BackgroundColor = bclr;
            Console.SetCursorPosition(col, row);
            Console.Write(toDraw);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }

        /// <summary>
        /// Draw menu logo
        /// </summary>
        public static void DrawMenuLogo()
        {
            Console.Clear();
            DrawAt(4, (Console.WindowWidth - 22) / 2, "aaaaa aaaaa aaaaa a   a".Replace('\u0061', '\u2588'));
            Thread.Sleep(55);
            DrawAt(5, (Console.WindowWidth - 22) / 2, "a   a a   a a   a a  a ".Replace('\u0061', '\u2588'));
            Thread.Sleep(55);
            DrawAt(6, (Console.WindowWidth - 22) / 2, "aaaa  a   a a     aaa  ".Replace('\u0061', '\u2588'));
            Thread.Sleep(55);
            DrawAt(7, (Console.WindowWidth - 22) / 2, "a   a a   a a   a a  a ".Replace('\u0061', '\u2588'));
            Thread.Sleep(55);
            DrawAt(8, (Console.WindowWidth - 22) / 2, "a   a aaaaa aaaaa a   a".Replace('\u0061', '\u2588'));
            Thread.Sleep(55);

            DrawAt(10, (Console.WindowWidth - 22) / 2, "aaaaa aaaaa a     a    ".Replace('\u0061', '\u2588'));
            Thread.Sleep(55);
            DrawAt(11, (Console.WindowWidth - 22) / 2, "a     a   a a     a    ".Replace('\u0061', '\u2588'));
            Thread.Sleep(55);
            DrawAt(12, (Console.WindowWidth - 22) / 2, "aaaa  aaaaa a     a    ".Replace('\u0061', '\u2588'));
            Thread.Sleep(55);
            DrawAt(13, (Console.WindowWidth - 22) / 2, "a     a   a a     a    ".Replace('\u0061', '\u2588'));
            Thread.Sleep(55);
            DrawAt(14, (Console.WindowWidth - 22) / 2, "a     a   a aaaaa aaaaa".Replace('\u0061', '\u2588'));
            Thread.Sleep(55);
        }

        /// <summary>
        /// Draw menu items based on selection
        /// </summary>
        public static void drawMenuItems()
        {
            if (menuIndex == 1)
            {
                DrawAt(19, (Console.WindowWidth - 22) / 2, "New Game...", ConsoleColor.Red);
            }
            else
            {
                DrawAt(19, (Console.WindowWidth - 22) / 2, "New Game...");
            }
            if (menuIndex == 2)
            {
                DrawAt(20, (Console.WindowWidth - 22) / 2, "Rules..", ConsoleColor.Red);
            }
            else
            {
                DrawAt(20, (Console.WindowWidth - 22) / 2, "Rules..");
            }
            if (menuIndex == 3)
            {
                DrawAt(21, (Console.WindowWidth - 21) / 2, "\u276e" + musicState + "\u276f ", ConsoleColor.Red);
            }
            else
            {
                DrawAt(21, (Console.WindowWidth - 23) / 2, " " + musicState + "   ");
            }
            if (menuIndex == 4)
            {
                DrawAt(22, (Console.WindowWidth - 22) / 2, "Exit Rock Fall", ConsoleColor.Red);
            }
            else
            {
                DrawAt(22, (Console.WindowWidth - 22) / 2, "Exit Rock Fall");
            }
        }

        /// <summary>
        /// Draw rules page
        /// </summary>
        public static void drawRules()
        {
            DrawAt(17, 3, "\u21AC", ConsoleColor.Yellow);
            DrawAt(17, 5, @"""Speed Up""", ConsoleColor.Yellow);
            DrawAt(19, 3, "\u21EA", ConsoleColor.Blue);
            DrawAt(19, 5, @"""Multiplier Up""", ConsoleColor.Blue);
            DrawAt(21, 3, "\u2622", ConsoleColor.Magenta);
            DrawAt(21, 5, @"""Nuke""", ConsoleColor.Magenta);
            DrawAt(23, 3, "\u2665", ConsoleColor.Red);
            DrawAt(23, 5, @"""Life""", ConsoleColor.Red);
            DrawAt(25, 3, "\u273E", ConsoleColor.DarkYellow);
            DrawAt(25, 5, @"""Invincibility""", ConsoleColor.DarkYellow);
            DrawAt(17, 23, "\u21AB", ConsoleColor.Yellow);
            DrawAt(17, 25, @"""Slow Down""", ConsoleColor.Yellow);
            DrawAt(19, 23, "\u2620", ConsoleColor.Black, ConsoleColor.Gray);
            DrawAt(19, 25, @"""Death""", ConsoleColor.Gray);
            DrawAt(21, 23, "\u2744", ConsoleColor.Cyan);
            DrawAt(21, 25, @"""Freeze""", ConsoleColor.Cyan);
            DrawAt(23, 23, "\u2661", ConsoleColor.Red);
            DrawAt(23, 25, @"""XLife""", ConsoleColor.Red);
            DrawAt(25, 23, "\u2646", ConsoleColor.Red);
            DrawAt(25, 25, "Comming soon", ConsoleColor.Red);

            DrawAt(27, 15, "Controls");
            DrawAt(28, 5, "< - MoveLeft");
            DrawAt(28, 20, "MoveRight - >");

            DrawAt(30, 29, "B - Back");
        }

        public static void drawDisclaimer()
        {
            Console.Clear();
            DrawAt(3, 3, "To fully experiance the whole \n project you must install DejaVu Mono    Font and hook it to the console.\n Also you need an mp3 in the project/     build folder and uncomment a           few lines in order to get \n     background music!\n\n    Press Any key..");
        }

        /// <summary>
        /// Draw Game Borders
        /// </summary>
        public static void DrawBorders()
        {
            for (int row = 1; row < GameHeight; row++)
            {
                DrawAt(row, 0, BorderChar, borderColor);
                DrawAt(row, GameWidth, BorderChar, borderColor);
            }

            StringBuilder topBorder = new StringBuilder();
            topBorder.Append('\u2554');
            topBorder.Append('\u2550', GameWidth - 1);
            topBorder.Append('\u2557');
            DrawAt(0, 0, topBorder.ToString(), borderColor);

            StringBuilder middleBorder = new StringBuilder();
            middleBorder.Append('\u2560');
            middleBorder.Append('\u2550', GameWidth - 1);
            middleBorder.Append('\u2563');
            DrawAt(MenuHeight, 0, middleBorder.ToString(), borderColor);

            StringBuilder bottomBorder = new StringBuilder();
            bottomBorder.Append('\u255A');
            bottomBorder.Append('\u2550', GameWidth - 1);
            bottomBorder.Append('\u255D');
            DrawAt(GameHeight, 0, bottomBorder.ToString(), borderColor);
        }

        /// <summary>
        /// Draw the player
        /// </summary>
        public static void DrawPlayer()
        {
            DrawAt(GameObjects.P1.row, GameObjects.P1.col, GameObjects.P1.look, GameObjects.P1.clr);
        }

        /// <summary>
        /// Draw rocks from the rock list
        /// </summary>
        public static void DrawRocks()
        {
            if (drawingEnabled)
            {
                foreach (Rock x in GameObjects.rocks)
                {
                    if (x.Row > 6)
                    {
                        Draw.DrawAt(x.Row - 1, x.Col, " ");
                        Draw.DrawAt(x.Row, x.Col, x.RockType, x.Clr);
                    }
                }
            }
        }

        /// <summary>
        /// Clear the row that the player character is
        /// </summary>
        public static void clearPlayingField()
        {
            for (int col = 1; col < GameWidth; col++)
            {
                DrawAt(GameHeight - 1, col, " ");
            }
        }

        /// <summary>
        /// Clear the whole game field
        /// </summary>
        public static void clearWholeField(int startRow)
        {
            for (int row = startRow; row < GameHeight; row++)
            {
                for (int col = 1; col < GameWidth; col++)
                {
                    DrawAt(row, col, " ");
                }
            }
        }
    }
}