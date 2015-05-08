/*Do you know that the next solar eclipse will occur on April 29, 2014? 
 * It will be observable from South Asia, Australia, the Pacific and the 
 * Indian Oceans and Antarctica. Spiro is an entrepreneur who wants to 
 * cash in on this natural phenomenon. Help him produce protective sunglasses 
 * of different sizes. You will get 5% of the profit.
 * 
Input
 * •	The input data should be read from the console.
 * •	You have an integer number N (always an odd number) specifying the height of sunglasses.
Output
 * The output should be printed on the console.
 * You should print the sunglasses on the console. The sunglasses consist of three parts: 
 * frames, lenses and a bridge (the connection between the two frames).
 * Each frame's width is double the height N and should be printed using the character '*' 
 * (asterisk). Print the lenses with the character '/'. Finally, connect the two frames with
 * a bridge that is of size N, using the character '|'. Leave the rest of the space between 
 * the frames blank.*/
//Examples
//Input	Output	
//3	    ******   ******
//      *////*|||*////*
//      ******   ******	
//	
//5	    **********     **********
//      *////////*     *////////*
//      *////////*|||||*////////*
//      *////////*     *////////*
//      **********     **********

using System;
using System.Text;

namespace Sunglasses
{
    internal class Sunglasses
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            TopBottom(n);
            for (int i = 2; i < n; i++)
            {
                if ((n / 2) + 1 == i)
                {
                    Console.WriteLine(MiddlePart(n).Replace(' ', '|'));
                }
                else
                {
                    Console.WriteLine(MiddlePart(n));
                }
            }
            TopBottom(n);
        }

        private static void TopBottom(int x)
        {
            StringBuilder draw = new StringBuilder();
            draw.Append('*', x * 2);
            draw.Append(' ', x);
            draw.Append('*', x * 2);
            Console.WriteLine(draw.ToString());
        }

        private static string MiddlePart(int x)
        {
            StringBuilder draw = new StringBuilder();
            draw.Append('*');
            draw.Append('/', (x - 1) * 2);
            draw.Append('*');
            draw.Append(' ', x);
            draw.Append('*');
            draw.Append('/', (x - 1) * 2);
            draw.Append('*');
            return draw.ToString();
        }
    }
}