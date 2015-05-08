using System;

internal class Iluminati
{
    private static int sum = 0;
    private static int vowels = 0;

    private static void Main(string[] args)
    {
        string messege = Console.ReadLine();
        Decipher(messege);
        Console.WriteLine(vowels);
        Console.WriteLine(sum);
    }

    private static void Decipher(string input)
    {
        string check = input.ToUpper();
        foreach (char item in check)
        {
            switch (item)
            {
                case 'A': sum += 65; vowels++;
                    break;

                case 'E': sum += 69; vowels++;
                    break;

                case 'I': sum += 73; vowels++;
                    break;

                case 'O': sum += 79; vowels++;
                    break;

                case 'U': sum += 85; vowels++;
                    break;

                default:
                    break;
            }
        }
    }
}