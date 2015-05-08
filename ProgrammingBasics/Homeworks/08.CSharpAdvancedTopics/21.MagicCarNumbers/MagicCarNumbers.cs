using System;
using System.Collections.Generic;

class MagicCarNumbers
{
    public static char[] letters = { 'A', 'B', 'C', 'E', 'H', 'K', 'M', 'P', 'T', 'X' };
    public static int hasMatch;
    public static List<string> matches = new List<string>(); // Add values with only 1 number to help eliminate duplicates

    public static void Main(string[] args)
    {
        int magicWeight = int.Parse(Console.ReadLine());
        Generate(magicWeight);
        Console.WriteLine(hasMatch);
    }

    public static void Generate(int magicWeight)
    {
        for (int a = 0; a <= 9; a++)
        {
            for (int b = 0; b <= 9; b++)
            {
                for (int x = 0; x < letters.Length; x++)
                {
                    for (int y = 0; y < letters.Length; y++)
                    {
                        string aaaa = "CA" + a.ToString() + a.ToString() + a.ToString() + a.ToString() + letters[x] + letters[y];
                        if (CalcWeight(aaaa) == magicWeight)
                        {
                            if (matches.Contains(aaaa))
                            {
                                //do nothing
                            }
                            else
                            {
                                matches.Add(aaaa);
                                //Console.WriteLine(aaaa);
                                hasMatch++;
                            }
                        }
                        if (a != b)
                        {
                            string aaab = "CA" + a.ToString() + a.ToString() + a.ToString() + b.ToString() + letters[x] + letters[y];
                            string aabb = "CA" + a.ToString() + a.ToString() + b.ToString() + b.ToString() + letters[x] + letters[y];
                            string abbb = "CA" + a.ToString() + b.ToString() + b.ToString() + b.ToString() + letters[x] + letters[y];
                            //string abba = "CA" + a.ToString() + b.ToString() + b.ToString() + a.ToString() + letters[x] + letters[y];
                            //string abab = "CA" + a.ToString() + b.ToString() + a.ToString() + b.ToString() + letters[x] + letters[y];
                            if (CalcWeight(aaab) == magicWeight)
                            {
                                //Console.WriteLine(aaab);
                                hasMatch++;
                            }
                            if (CalcWeight(aabb) == magicWeight)
                            {
                                //Console.WriteLine(aabb);
                                hasMatch += 3; //abab and abba have same value and its not asked each one out so we can just add 3 when aabb has a match
                            }
                            if (CalcWeight(abbb) == magicWeight)
                            {
                                //Console.WriteLine(abbb);
                                hasMatch++;
                            }
                            //if (CalcWeight(abba) == magicWeight)
                            //{
                            //    //Console.WriteLine(abba);
                            //    hasMatch++;
                            //}

                            //if (CalcWeight(abab) == magicWeight)
                            //{
                            //    //Console.WriteLine(abab);
                            //    hasMatch++;
                            //}
                        }
                    }
                }
            }
        }
    }

    public static int CalcWeight(string x)
    {
        int result = 0;
        foreach (char c in x)
        {
            result += GetValue(c);
        }
        return result;
    }

    public static int GetValue(char x)
    {
        switch (x)
        {
            case '0': return 0;
            case '1': return 1;
            case '2': return 2;
            case '3': return 3;
            case '4': return 4;
            case '5': return 5;
            case '6': return 6;
            case '7': return 7;
            case '8': return 8;
            case '9': return 9;
            case 'A': return 10;
            case 'B': return 20;
            case 'C': return 30;
            case 'E': return 50;
            case 'H': return 80;
            case 'K': return 110;
            case 'M': return 130;
            case 'P': return 160;
            case 'T': return 200;
            case 'X': return 240;
            default: return 0;
        }
    }
}