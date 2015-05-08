/* Problem: Declare two string variables and assign them with “Hello” and “World”. 
 * Declare an object variable and assign it with the concatenation of the first 
 * two variables (mind adding an interval between). Declare a third string variable 
 * and initialize it with the value of the object variable (you should perform type casting).*/
using System;

namespace StringsAndObjects
{
    internal class StringsAndObjects
    {
        private static void Main(string[] args)
        {
            string x = "Hello";
            string y = "World";
            object xy = x + " " + y;
            string result = (string)xy;

            Console.WriteLine(result);
        }
    }
}