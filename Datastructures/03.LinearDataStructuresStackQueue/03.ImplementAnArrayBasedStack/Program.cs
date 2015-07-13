using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementAnArrayBasedStack
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayStack<int> bla = new ArrayStack<int>();
            for (int i = 0; i < 20; i++)
            {
                bla.Push(i);
            }

            while (bla.Count > 0)
            {
                Console.WriteLine(bla.Pop());
            }
        }
    }
}
