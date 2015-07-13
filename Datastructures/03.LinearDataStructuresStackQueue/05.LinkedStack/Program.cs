using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.LinkedStack
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedStack<int> newStack = new LinkedStack<int>();
            for (int i = 0; i < 100; i++)
            {
                newStack.Push(i);
            }
            
            int[] array = newStack.ToArray();

            foreach (var i in array)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Stack pop");
            for (int i = 100; i >= 1; i--)
            {
                Console.WriteLine(newStack.Pop());
            }
        }
    }
}
