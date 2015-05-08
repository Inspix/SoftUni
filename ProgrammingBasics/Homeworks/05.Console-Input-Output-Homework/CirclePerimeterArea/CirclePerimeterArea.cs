using System;
using System.Globalization;
using System.Threading;

namespace CirclePerimeterArea
{
    internal class CirclePerimeterArea
    {
        private static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            #region Tests

            //Tests from the homework file
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Testing with example variables from the Homework!\n");
            Console.WriteLine("Radius 2   , Area {0,-5} , Perimeter {1}", area(2), perimeter(2));
            Console.WriteLine("Radius 3.5 , Area {0,-5} , Perimeter {1}", area(3.5), perimeter(3.5));
            Console.WriteLine("\nTest end!\n");
            Console.ForegroundColor = ConsoleColor.White;

            #endregion Tests

            Console.Write("Please enter the radius of the circle:");
            double input = getInput();
            Console.WriteLine("The area of circle is: {0}", area(input));
            Console.WriteLine("The perimeter of circle is:{0}", perimeter(input));
        }

        //Calculate area and round it down to 2 decimal digits
        private static double area(double x)
        {
            return Math.Round(Math.PI * Math.Pow(x, 2), 2);
        }

        //Calculate perimeter and round it down to 2 decimal digits
        private static double perimeter(double x)
        {
            return Math.Round((2 * Math.PI * x), 2);
        }

        //Get correct input from console.
        private static double getInput()
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