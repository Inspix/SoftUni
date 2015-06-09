using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.EnterNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            for (int i = 0; i < 10; i++)
            {
                int number = ReadNumber(first, second);
                first = number;
            }
        }

        static int ReadNumber(int start, int end)
        {
            int number = int.Parse(Console.ReadLine());
            if (number < start || number > end)
            {
                throw new ArgumentException(string.Format("Your number was not in the range {0} - {1}",start,end));
            }else if (number == end - 1)
            {
                Console.WriteLine("The program entered an endless loop... Terminating");
                Environment.Exit(0);
            }
            return number;
        }
    }
}
