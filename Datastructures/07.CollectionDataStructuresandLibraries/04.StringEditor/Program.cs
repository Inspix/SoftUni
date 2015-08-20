using System;

namespace _04.StringEditor
{
    using Wintellect.PowerCollections;

    class Program
    {
        static BigList<char> characters = new BigList<char>();
        static void Main()
        {
            string input = Console.ReadLine();
            while (input != "END")
            {
                if (input == String.Empty)
                {
                    input = Console.ReadLine();
                    continue;
                }

                string[] args = input.Split();
                // string[] args = input.Split('|'); replace to split on | so the strings can contain spaces

                switch (args[0])
                {
                    case "INSERT":
                        Insert(args);
                        break;
                    case "APPEND":
                        Append(args);
                        break;
                    case "DELETE":
                        Delete(args);
                        break;
                    case "REPLACE":
                        Replace(args);
                        break;
                    case "PRINT":
                        Print();
                        break;
                }

                input = Console.ReadLine();
            }
        }

        static void Insert(string[] args)
        {
            int position;
            if (int.TryParse(args[1], out position))
            {
                if (args[2].Length < 1 || position >= characters.Count)
                {
                    Console.WriteLine("Error");
                }
                else
                {
                    characters.InsertRange(position,args[2]);
                }
            }
        }

        static void Append(string[] args)
        {
            characters.AddRange(args[1]);
        }

        static void Delete(string[] args)
        {
            int index,count;
            if (int.TryParse(args[1],out index) && int.TryParse(args[2],out count))
            {
                if (index + count-1 < characters.Count)
                {
                   characters.RemoveRange(index,count);
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
        }

        static void Replace(string[] args)
        {
            int index, count;
            if (int.TryParse(args[1], out index) && int.TryParse(args[2], out count))
            {
                if (index + count < characters.Count && args[3].Length > 0)
                {
                    characters.RemoveRange(index, count);
                    characters.InsertRange(index,args[3]);
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
        }

        static void Print()
        {
            foreach (var character in characters)
            {
                Console.Write(character);
            }
            Console.WriteLine();
        }
    }
}
