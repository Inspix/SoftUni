/* Problem: Declare two string variables and assign them with following value:
 * 
 * The "use" of quotations causes difficulties.
 * 
 * Do the above in two different ways: with and without using quoted strings. 
 * Print the variables to ensure that their value was correctly defined.
*/

using System;

namespace QuotesInStrings
{
    internal class QuotesInStrings
    {
        private static void Main(string[] args)
        {
            string normalString = "The \"use\" of quotations causes difficulties.";

            string quotedString = @"The ""use"" of quotations causes difficulties.";

            Console.WriteLine(normalString);
            Console.WriteLine(quotedString);
        }
    }
}