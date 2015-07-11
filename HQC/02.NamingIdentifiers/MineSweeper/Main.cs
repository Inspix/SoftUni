namespace Minesweeper
{
    using System;

    using Game;

    public class Minesweeper
    {
        private static void Main(string[] args)
        {
            new Engine().Start();
            Console.Read();
            
        }
    }
}
