using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _08.UseYourChainsBuddy
{
    class UseYourChainsBuddy
    {
        static void Main()
        {
            string pattern = @"<p>([^<]*)<\/p>";
            string unnecesaryChars = @"[^a-z0-9]";
            string unnecesaryWhiteSpaces = @"[\s]{2,}";
            string input = Console.ReadLine();
            List<string> results = new List<string>();
            Match m = Regex.Match(input, pattern);
            while (m.Success)
            {
                results.Add(m.Groups[1].ToString());
                m = m.NextMatch();
            }

            for (int i = 0; i < results.Count; i++)
            {
                results[i] = Regex.Replace(results[i], unnecesaryChars, " ");
                results[i] = Regex.Replace(results[i], unnecesaryWhiteSpaces, " ");
                results[i] = Decript(results[i]);
            }

            Console.WriteLine(string.Join("", results));
        }

        public static string Decript(string input)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= 48 && input[i] <=57)
                {
                    sb.Append(input[i]);
                }else if (input[i] != ' ')
                {
                    sb.Append(CharacterDecript(input[i]));
                }
                else
                {
                    sb.Append(' ');
                }
                
            }
            return sb.ToString();
        }

        public static char CharacterDecript(char c)
        {
            int value = c;
            if (value >= 97 && value <= 109)
            {
                return (char)(value + 13);
            }
            else
            {
                return (char)(value - 13);
            }
        }
    }
}
