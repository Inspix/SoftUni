/*Declare five variables choosing for each of them the most appropriate of the types
 *byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values:
 *52130, -115, 4825932, 97, -10000. Choose a large enough type for each number to ensure
 *it will fit in it. Try to compile the code.*/

using System;

namespace DeclareVariables
{
    internal class DeclareVariables
    {
        private static void Main(string[] args)
        {
            ushort uS = 52130;
            short s = -155;
            int i = 4825932;
            byte b2 = 97;
            int i2 = -10000;

            //Console.WriteLine("Unsigned Short: {0}\nShort:{1} \nInteger:{2} \nByte:{3} \nInteger #2:{4}", uS, s, i, b2, i2);
        }
    }
}