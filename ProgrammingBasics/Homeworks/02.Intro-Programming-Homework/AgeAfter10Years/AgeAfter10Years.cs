/* Write a program to read your birthday from the console and print 
 * how old you are now and how old you will be after 10 years.*/
using System;

namespace AgeAfter10Years
{
    internal class AgeAfter10Years
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Input date of birth:");
            Console.Write("Day:");
            int inputDay = int.Parse(Console.ReadLine());
            Console.Write("Month:");
            int inputMonth = int.Parse(Console.ReadLine());
            Console.Write("Year:");
            int inputYear = int.Parse(Console.ReadLine());

            DateTime input = new DateTime(inputYear, inputMonth, inputDay);
            float i = float.Parse(input.ToString("yyyy,MMdd"));
            float x = float.Parse(DateTime.Now.ToString("yyyy,MMdd"));
            float age = x - i;
            Console.WriteLine("Age now: " + (int)age);
            Console.WriteLine("Age after 10 years:" + (int)(age + 10));
        }
    }
}