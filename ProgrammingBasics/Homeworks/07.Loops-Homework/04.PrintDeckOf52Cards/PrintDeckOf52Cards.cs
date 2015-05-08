using System;
using System.Text;

internal class PrintDeckOf52Cards
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.Unicode;
        char[] suites = { '\u2663', '\u2666', '\u2665', '\u2660' };

        for (int number = 2; number < 15; number++)
        {
            for (int suite = 0; suite < 4; suite++)
            {
                if (number > 10)
                {
                    Console.Write("{0}{1} ", JQKA(number), suites[suite]);
                }
                else
                {
                    Console.Write("{0}{1} ", number, suites[suite]);
                }
            }
            Console.WriteLine();
        }
    }

    private static char JQKA(int x)
    {
        switch (x)
        {
            case 11: return 'J';
            case 12: return 'Q';
            case 13: return 'K';
            case 14: return 'A';
            default: return ' ';
        }
    }
}