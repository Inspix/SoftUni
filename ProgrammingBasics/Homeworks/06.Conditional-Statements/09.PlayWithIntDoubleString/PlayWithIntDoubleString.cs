using System;
using System.Globalization;
using System.Threading;

namespace PlayWithIntDoubleString
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("Please choose a type:\n1 --> int\n2 --> double\n3 --> string\n");

            while (true)
            {
                switch (getIntInput())
                {
                    case 1:
                        Console.Write("Please enter a int: ");
                        Console.WriteLine("{0}", getIntInput() + 1);
                        break;

                    case 2:
                        Console.Write("Please enter a double: ");
                        Console.WriteLine("{0}", getDoubleInput() + 1);
                        break;

                    case 3:
                        Console.Write("Please enter a string: ");
                        Console.WriteLine("{0}*", Console.ReadLine());
                        break;
                    //start over on wrong input
                    default: Console.Write("Invalid input,try again: ");
                        continue;
                }
                break;
            }
        }

        private static int getIntInput()
        {
            int number;
            do
            {
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    break;
                }
                else
                {
                    Console.Write("Invalid input,try again: ");
                }
            } while (true);
            return number;
        }

        private static double getDoubleInput()
        {
            double number;
            do
            {
                if (double.TryParse(Console.ReadLine().Replace(',', '.'), out number))
                {
                    break;
                }
                else
                {
                    Console.Write("Invalid input,try again: ");
                }
            } while (true);
            return number;
        }
    }
}