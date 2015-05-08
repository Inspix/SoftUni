using System;

namespace WorkHours
{
    internal class WorkHours
    {
        private static void Main(string[] args)
        {

            #region Tests
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Testing with the example variables!");
            int[] rHV = new int[] { 60, 1, 240, 10, 21 };
            int[] dNV = new int[] { 6, 1, 10, 10, 10 };
            int[] pV = new int[] { 75, 100, 100, 10, 10 };
            for (int i = 0; i <= rHV.GetUpperBound(0); i++)
            {
                Console.WriteLine("\nInput: Required hours:{0} Days Available:{1} Productivity:{2}",rHV[i],dNV[i],pV[i]);
                Console.WriteLine("Result:");
                result(calcHours(dNV[i], pV[i]), rHV[i]);
            }
            Console.WriteLine("\nTest end!\n");
            Console.ForegroundColor = ConsoleColor.White;

            #endregion

            int requiredHours = int.Parse(Console.ReadLine());
            int daysNeeded = int.Parse(Console.ReadLine());
            int productivity = int.Parse(Console.ReadLine());

            result(calcHours(daysNeeded, productivity), requiredHours);
            
        }

        private static double calcHours(int daysN, int prod)
        {
            double result = (((double)daysN * 0.9) * 12) * prod / 100;
            return result;
        }

        private static void result(double hoursA, double reqH)
        {
            if (hoursA < reqH)
            {
                Console.WriteLine("No");
                Console.WriteLine((int)(hoursA - reqH));           
            }
            else
            {
                Console.WriteLine("Yes");
                Console.WriteLine((int)(hoursA - reqH));
            }
        }
    }
}