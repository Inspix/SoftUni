using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.LinkedQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedQueue<string> numbers = new LinkedQueue<string>();
            for (int i = 0; i < 100; i++)
            {
                numbers.Enqueue(i.ToString());
            }

            Console.WriteLine("To array");
            Console.WriteLine(string.Join(", ", numbers.ToArray()));

            Console.WriteLine("Dequeue");

            while (numbers.Count > 0)
            {
                Console.Write(numbers.Dequeue() + (numbers.Count != 0 ? ", " : String.Empty));
            }
            Console.WriteLine();

        }
    }
}
