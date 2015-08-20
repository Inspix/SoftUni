using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PriorityQueue
{
    class Program
    {
        static Random rng = new Random();
        static void Main(string[] args)
        {
            PriorityQueue<int> queue = new PriorityQueue<int>();

            for (int i = 0; i < 1000; i++)
            {
                queue.Enqueue(rng.Next());
            }

            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }
        }
    }
}
