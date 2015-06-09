using System;

namespace _01.SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double x;
                if ((x = double.Parse(Console.ReadLine())) < 0)
                {
                    throw new ArgumentException("the number shoud be positive");
                }
                Console.WriteLine(Math.Sqrt(x));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Good Bye!");
            }
        }
    }
}
