using System;
using System.Collections.Generic;

namespace Problem8.DistanceinLabyrinth
{
    struct Coords
    {
        public int X;
        public int Y;

        public Coords(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }

    class Program
    {
        public static string[,] labirinth = 
        {
            {"0", "0", "0", "X", "0", "X"},
            {"0", "X", "0", "X", "0", "X"},
            {"0", "*", "X", "0", "X", "0"},
            {"0", "X", "0", "0", "0", "0"},
            {"0", "0", "0", "X", "X", "0"},
            {"0", "0", "0", "X", "0", "X"}
        };

        private static int digit = 1;
        private static Queue<Coords> currentQueue;
        private static Queue<Coords> resultQueue; 

        static void Main(string[] args)
        {
            Coords crd = new Coords();

            GetStartIndex(ref crd.X, ref crd.Y);
            
            currentQueue = new Queue<Coords>();
            resultQueue = new Queue<Coords>();
            resultQueue.Enqueue(crd);

            while (resultQueue.Count > 0)
            {
                currentQueue = resultQueue;
                resultQueue = new Queue<Coords>();
                while (currentQueue.Count > 0)
                {
                    Coords cords = currentQueue.Dequeue();
                    CheckNeighbours(cords.X, cords.Y);
                }
                digit++;
            }

            CheckForZeros();
            Print(labirinth);
        }


        static void Print(string[,] array)
        {
            for (int i = 0; i <= array.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= array.GetUpperBound(1); j++)
                {
                    Console.Write("{0,2}", array[i,j]);
                }
                Console.WriteLine();
            }
        }

        static void CheckForZeros()
        {
            for (int i = 0; i <= labirinth.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= labirinth.GetUpperBound(1); j++)
                {
                    if (labirinth[i,j] == "0")
                    {
                        labirinth[i, j] = "u";
                    }
                }
            }
        }

        static void GetStartIndex(ref int x, ref int y)
        {
            for (int i = 0; i <= labirinth.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= labirinth.GetUpperBound(1); j++)
                {
                    if (labirinth[i,j] == "*")
                    {
                        x = i;
                        y = j;
                        labirinth[i, j] = "0";
                        return;
                    }
                }
            }
        }


        static void CheckNeighbours(int tx, int ty)
        {
            for (int i = 0; i <= 3; i++)
            {
                try
                {
                    CheckDirection(i,tx,ty);

                }
                catch (Exception)
                {
                    // Neighbour outside of bounds
                } 
            }
        }

        static void CheckDirection(int dir, int tx, int ty)
        {
            switch (dir)
            {
                case 0:
                    if (labirinth[tx, ty-1] == "0")
                    {
                        resultQueue.Enqueue(new Coords(tx,ty - 1));
                        labirinth[tx, ty - 1] = digit.ToString();
                    }
                    break;
                case 1:
                    if (labirinth[tx, ty + 1] == "0")
                    {
                        resultQueue.Enqueue(new Coords(tx, ty + 1));
                        labirinth[tx, ty + 1] = digit.ToString();
                    }
                    break;

                case 2:
                    if (labirinth[tx - 1, ty] == "0")
                    {
                        resultQueue.Enqueue(new Coords(tx - 1, ty));
                        labirinth[tx - 1, ty] = digit.ToString();
                    }
                    break;
                case 3:
                    if (labirinth[tx + 1, ty] == "0")
                    {
                        resultQueue.Enqueue(new Coords(tx + 1, ty ));
                        labirinth[tx + 1, ty] = digit.ToString();
                    }
                    break;

            }
        }
    }
}
