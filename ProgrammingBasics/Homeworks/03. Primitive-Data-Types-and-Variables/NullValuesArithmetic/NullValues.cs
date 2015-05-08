/* Problem: Create a program that assigns null values to an integer and to a double 
 * variable. Try to print these variables at the console. Try to add some number or 
 * the null literal to these variables and print the result.*/
using System;

namespace NullValuesArithmetic
{
    internal class NullValues
    {
        private static void Main(string[] args)
        {
            int? x = null;
            double? y = null;
            Console.WriteLine("Nullable Integer x with null value: {0}", x);
            Console.WriteLine("Nullable Double y with null value: {0}", y);
            // Try to add a number to a nullable int x
            x += 10;
            Console.WriteLine("Nullable Integer x + 10: {0}", x);
        }
    }
}