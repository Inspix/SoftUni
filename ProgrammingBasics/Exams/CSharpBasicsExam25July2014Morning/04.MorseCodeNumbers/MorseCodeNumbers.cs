using System;

class MorseCodeNumbers
{
    public static bool hasMatch = false;
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        GenerateMorseCodeNumbers(CalcSum(n));
        if (!hasMatch)
        {
            Console.WriteLine("No");
        }

    }
    public static int CalcSum(int x)
    {
        int sum = 0;
        while (x != 0)
        {
            sum += x % 10;
            x /= 10;
        }
        return sum;
    }

    public static void GenerateMorseCodeNumbers(int weight)
    {
        for (int a = 0; a <= 5; a++)
        {
            for (int b = 0; b <=5; b++)
            {
                for (int c = 0; c <=5; c++)
                {
                    for (int d = 0; d <=5; d++)
                    {
                        for (int e = 0; e <= 5; e++)
                        {
                            for (int f = 0; f <= 5; f++)
                            {
                                string result = GetMorseRepresentation(a).Morse + "|" +
                                                GetMorseRepresentation(b).Morse + "|" +
                                                GetMorseRepresentation(c).Morse + "|" +
                                                GetMorseRepresentation(d).Morse + "|" +
                                                GetMorseRepresentation(e).Morse + "|" +
                                                GetMorseRepresentation(f).Morse + "|";
                                int Morseweight = GetMorseRepresentation(a).Weight *
                                                GetMorseRepresentation(b).Weight *
                                                GetMorseRepresentation(c).Weight *
                                                GetMorseRepresentation(d).Weight *
                                                GetMorseRepresentation(e).Weight *
                                                GetMorseRepresentation(f).Weight;
                                if (weight == Morseweight)
                                {
                                    if (!hasMatch)
                                    {
                                        hasMatch = true;
                                    }
                                    Console.WriteLine(result);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
        
    public static MorseWeight GetMorseRepresentation(int x)
    {
        switch (x)
        {
            case 0: return new MorseWeight { Morse = "-----", Weight = 0 };
            case 1: return new MorseWeight { Morse = ".----", Weight = 1 }; 
            case 2: return new MorseWeight { Morse = "..---", Weight = 2 }; 
            case 3: return new MorseWeight { Morse = "...--", Weight = 3 }; 
            case 4: return new MorseWeight { Morse = "....-", Weight = 4 }; 
            case 5: return new MorseWeight { Morse = ".....", Weight = 5 };
            default: return new MorseWeight { };
        }
    }
}
public class MorseWeight
{
    public string Morse { get; set; }
    public int Weight { get; set; }
}
