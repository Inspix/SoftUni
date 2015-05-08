/*Problem: Which of the following values can be assigned to a 
 * variable of type float and which to a variable of type 
 * double: 34.567839023, 12.345,8923.1234857, 3456.091? 
 * Write a program to assign the numbers in variables 
 * and print them to ensure no precision is lost.*/

using System;

namespace FloatOrDouble
{
    internal class FloatOrDouble
    {
        private static void Main(string[] args)
        {
            double d = 34.567839023;
            float f = 12.345F;
            double d2 = 8923.1234857;
            float f2 = 3456.091F;

            Console.WriteLine(d);
            Console.WriteLine(f);
            Console.WriteLine(d2);
            Console.WriteLine(f2);
        }
    }
}