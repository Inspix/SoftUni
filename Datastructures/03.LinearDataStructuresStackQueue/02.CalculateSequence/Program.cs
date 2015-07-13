using System;

namespace CalculateSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberToTest = int.Parse(Console.ReadLine());
            Console.WriteLine(string.Join(" ", Calculations.QueueSequence(numberToTest)));
        }
    }
}
