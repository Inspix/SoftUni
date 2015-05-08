using System;

class LettersSymbolsNumbers
{
    public static int letters = 0;
    public static int numbers = 0;
    public static int characters = 0;
    static void Main(string[] args)
    {

        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            CalcValue(input);
        }

        Console.WriteLine(letters);
        Console.WriteLine(numbers);
        Console.WriteLine(characters);
    }

    public static void CalcValue(string x)
    {
        x = x.Replace(" ", "");
        foreach (char item in x)
        {
            CharValue(item);
        }
    }

    public static void CharValue(char x)
    {
        if ((int)x >=97 && (int)x <= 122)
        {
            letters += ((int)x - 96) * 10;
        }
        else if ((int)x >= 65 && (int)x <= 90)
        {
            letters += ((int)x - 64) * 10;
        }
        else if ((int)x >= 48 && (int)x <= 57)
        {
            numbers += ((int)x - 48) * 20;
        }
        else if (x == ' ' || x == '\t' || x == '\r' || x == 'n')
        {
            return;
        }
        else
        {
            characters += 200;
        }
    }
}
