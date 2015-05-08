using System;

internal class MagicStrings
{
    private static char[] letters = new char[] { 'k', 'n', 'p', 's' };
    private static int diff;
    private static bool hasMatch;

    private static void Main(string[] args)
    {
        diff = int.Parse(Console.ReadLine());

        left();

        if (!hasMatch)
        {
            Console.WriteLine("No");
        }
    }

    private static void left()
    {
        ;
        for (int a = 0; a <= letters.GetUpperBound(0); a++)
        {
            for (int b = 0; b <= letters.GetUpperBound(0); b++)
            {
                for (int c = 0; c <= letters.GetUpperBound(0); c++)
                {
                    for (int d = 0; d <= letters.GetUpperBound(0); d++)
                    {
                        string left = "" + letters[a] + letters[b] + letters[c] + letters[d];
                        right(left);
                    }
                }
            }
        }
    }

    private static void right(string left)
    {
        for (int a = 0; a <= letters.GetUpperBound(0); a++)
        {
            for (int b = 0; b <= letters.GetUpperBound(0); b++)
            {
                for (int c = 0; c <= letters.GetUpperBound(0); c++)
                {
                    for (int d = 0; d <= letters.GetUpperBound(0); d++)
                    {
                        string right = "" + letters[a] + letters[b] + letters[c] + letters[d];
                        if (Math.Abs(calcWeight(left) - calcWeight(right)) == diff)
                        {
                            Console.WriteLine(string.Format("{0}{1}", left, right));
                            hasMatch = true;
                        }
                    }
                }
            }
        }
    }

    private static int calcWeight(string x)
    {
        int weight = 0;
        foreach (char item in x)
        {
            switch (item)
            {
                case 's': weight += 3;
                    break;

                case 'n': weight += 4;
                    break;

                case 'k': weight += 1;
                    break;

                case 'p': weight += 5;
                    break;

                default:
                    break;
            }
        }
        return weight;
    }
}