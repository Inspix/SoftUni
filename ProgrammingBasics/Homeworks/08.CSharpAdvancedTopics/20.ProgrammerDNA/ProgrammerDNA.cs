using System;

class ProgrammerDNA
{
    public static int C;
    public static int startingC;
    public static int index = 1;

    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        startingC = Console.Read();
        C = startingC - 1;
        int indexToPrint = 1;
        while (index <= n)
        {
            PrintRest(indexToPrint);
            indexToPrint++;
            if (indexToPrint == 5)
            {
                indexToPrint--;
                while (indexToPrint != 1 && index <= n)
                {
                    indexToPrint--;
                    PrintRest(indexToPrint);
                }
            }
        }
    }

    public static void PrintRest(int i)
    {
        switch (i)
        {
            case 1: char[] a = new char[7];
                a[7 / 2] = GetLetter();
                index++;
                Console.WriteLine(new string(a).Replace((char)0, '.'));
                break;

            case 2: char[] x = new char[7];
                x[2] = GetLetter();
                x[3] = GetLetter();
                x[4] = GetLetter();
                Console.WriteLine(new string(x).Replace((char)0, '.'));
                index++;
                break;

            case 3: char[] y = new char[7];
                y[1] = GetLetter();
                y[2] = GetLetter();
                y[3] = GetLetter();
                y[4] = GetLetter();
                y[5] = GetLetter();
                Console.WriteLine(new string(y).Replace((char)0, '.'));
                index++;
                break;

            case 4: char[] z = new char[7];
                z[0] = GetLetter();
                z[1] = GetLetter();
                z[2] = GetLetter();
                z[3] = GetLetter();
                z[4] = GetLetter();
                z[5] = GetLetter();
                z[6] = GetLetter();
                Console.WriteLine(new string(z).Replace((char)0, '.'));
                index++;
                break;

            default:
                break;
        }
    }

    public static char GetLetter()
    {
        if (C > 70)
        {
            C = 64;
        }
        C++;
        return (char)C;
    }
}