/*Problem: Declare an integer variable and assign it with the value 254 in hexadecimal 
 * format (0x##). Use Windows Calculator to find its hexadecimal representation. 
 * Print the variable and ensure that the result is “254”.*/

using System;

namespace VariableInHex
{
    internal class VariableInHex
    {
        private static void Main(string[] args)
        {
            int x = 0xFE;

            Console.WriteLine(x);
        }
    }
}