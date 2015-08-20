using System;
using System.Collections.Generic;

namespace _03.RideTheHorse
{
    class Program
    {
        static int[,] matrix;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            matrix = new int[n, m];

            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            matrix[x, y] = 1;

            Ride(x, y);

            Console.WriteLine("-----Result-----");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.WriteLine(matrix[i, matrix.GetLength(1) / 2]);
            }

        }
        static Queue<Tuple<int, int>> queue;
        static void Ride(int startx, int starty)
        {
            queue = new Queue<Tuple<int, int>>();
            Tuple<int, int> jump = new Tuple<int, int>(startx, starty);
            JumpDirections(jump);

            while (queue.Count> 0)
            {
                jump = queue.Dequeue();
                JumpDirections(jump);
            }                       
        }

        static void JumpDirections(Tuple<int,int> position)
        {
            int x = position.Item1;
            int y = position.Item2;
            int v = matrix[x, y];
            RideHelper(x + 1, y + 2,v);
            RideHelper(x - 1, y + 2,v);
            RideHelper(x + 1, y - 2,v);
            RideHelper(x - 1, y - 2,v);
            RideHelper(x + 2, y + 1,v);
            RideHelper(x - 2, y + 1,v);
            RideHelper(x + 2, y - 1,v);
            RideHelper(x - 2, y - 1,v);
        }

        static void RideHelper(int jumpx,int jumpy, int v)
        {
            if (IsValidCell(jumpx,jumpy))
            {
                if (matrix[jumpx,jumpy] == 0)
                {
                    queue.Enqueue(new Tuple<int, int>(jumpx, jumpy));
                    matrix[jumpx, jumpy] = v + 1;
                }
            }
        }

        static bool IsValidCell(int cx, int cy)
        {
            if (cx < matrix.GetLength(0) && cx >= 0 && cy < matrix.GetLength(1) && cy >= 0)
            {
                return true;
            }
            return false;
        }
    }
}
