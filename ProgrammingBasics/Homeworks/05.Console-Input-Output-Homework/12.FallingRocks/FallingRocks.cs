/* To fully experiance the whole project you must install DejaVu Sans Mono font
 * and hook it to the console. This is my first ever "Game" so any feedback is welcome.
 * 
 * check http://www.ambiera.com/irrklang/ - for the music library
 * check http://www.fileformat.info/info/unicode/font/dejavu_sans_mono/index.htm - for the DejaVu Sans Mono
 * check https://archive.org/details/Best_of_8_Bit_Collective-2006-2011 - for the song that i used 01 kenesis 1.mp3
 */

using System;
using System.Text;
using System.Threading;

namespace FallingRocks
{
    public class Game
    {
        public const int dSpeed = 150;
        public const int dFrequency = 6;

        public static Random rnd = new Random();
        public static int speed = dSpeed;
        public static int counter = 1;
        public static int frequency = dFrequency;
        public static bool menuThread = false;
        public static bool rules = false;
        public static bool cleared = true;

        public static AutoResetEvent _pauseEvent = new AutoResetEvent(false);
        public static Thread _thread;

        private static void Main(string[] args)
        {
            consoleInit();
            Draw.drawDisclaimer();
            Console.ReadKey();
            //uncomment for background music
            _thread = new Thread(GameObjects.music);
            _thread.Start();
            _thread = new Thread(startMenu);
            _thread.Start();
        }

        public static void startMenu()
        {
            Thread.Sleep(100);
            Console.Clear();
            Draw.DrawMenuLogo();

            while (true)
            {
                if (menuThread)
                {
                    _pauseEvent.WaitOne(); //pause menu thread when game starts
                    menuThread = false;
                    Console.Clear();
                    Draw.DrawMenuLogo();
                }
                if (Console.KeyAvailable)
                {
                    GameObjects.MenuMove(Console.ReadKey(true));
                }
                Draw.drawMenuItems();
                Thread.Sleep(100);
                while (rules)
                {
                    if (cleared)
                    {
                        Draw.clearWholeField(15);
                        Draw.drawRules();
                        cleared = false;
                    }
                    if (Console.KeyAvailable)
                    {
                        GameObjects.MenuMove(Console.ReadKey(true));
                    }
                    Thread.Sleep(100);
                }
            }
        }

        public static void GamePlay()
        {
            Console.Clear();
            Thread.Sleep(10);
            Draw.DrawBorders();
            Score.DrawScoreBoard();
            while (Score.lifes.Length != 0)
            {
                counter++;
                Score.initPowerUps();
                Score.difficulty();
                Draw.clearPlayingField();
                if (Console.KeyAvailable)
                {
                    GameObjects.MovePlayer(Console.ReadKey(true));
                    while (Console.KeyAvailable)
                    {
                        Console.ReadKey(true);//get rid of buffered keys
                    }
                }
                Draw.DrawPlayer();

                GameObjects.MoveRocks();
                Draw.DrawRocks();
                Score.RedrawScore();

                Thread.Sleep(speed);
                if (counter % frequency == 0)
                {
                    GameObjects.rocks.Add(Rock.randomRock());
                }
            } _pauseEvent.Set(); //resume menu thread
        }

        private static void consoleInit()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WindowWidth = Draw.GameWidth + 1;
            Console.WindowHeight = Draw.GameHeight + 2;
            Console.BufferWidth = Draw.GameWidth + 1;
            Console.BufferHeight = Draw.GameHeight + 2;
            Console.CursorVisible = false;
        }
    }
}