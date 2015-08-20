//-----------------------------------------------------------
/*
    If you want to test with 100mb file, CTRL-C,CTRL-V the
    text in the mghtmag2.txt until the file has around 
    2.5 million lines.
*/
//-----------------------------------------------------------

namespace _01.FindWordsInFile
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Text.RegularExpressions;

    class Program
    {
        static Dictionary<string,int> occurances = new Dictionary<string,int>();
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now.TimeOfDay + ": Reading file..");
            Stopwatch sw = Stopwatch.StartNew();
            int counter = 0;
            using (StreamReader sr = new StreamReader("mghtmag2.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    var words = Regex.Matches(line, @"(\b[\w-']+\b)", RegexOptions.Singleline);
                    foreach (Match word in words)
                    {
                        if (!occurances.ContainsKey(word.Value))
                        {
                            occurances[word.Value] = 0;
                        }
                        occurances[word.Value]++;

                    }
                    counter++;
                }
            }
            sw.Stop();

            Console.WriteLine(DateTime.Now.TimeOfDay + ": Reading finished!");
            Console.WriteLine("---Lines red:" + counter);
            Console.WriteLine("Elapsed time:" + sw.Elapsed + Environment.NewLine);
            bool running = true;
            do
            {
                Console.Write("Enter number of words you want to check:");
                string input = Console.ReadLine();
                int times;
                if (int.TryParse(input,out times))
                {
                    for (int i = 0; i < times; i++)
                    {
                        Console.Write("Enter the word:");
                        input = Console.ReadLine();
                        if (input == null)
                        {
                            i--;
                            Console.WriteLine("Invalid string try again:");
                            continue;
                        }
                        if (occurances.ContainsKey(input))
                        {
                            Console.WriteLine(input + "->" + occurances[input]);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid number, try again.");
                    continue;
                }
                running = false;
                Console.WriteLine("Goodbye!");

            }
            while (running);

            Console.ReadKey(true);
        }
    }
}
