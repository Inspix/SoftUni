using System;

namespace CheckForaPlayCard
{
    internal class CheckForaPlayCard
    {
        private static void Main(string[] args)
        {
            check();
        }

        private static void check()
        {
            string input = Console.ReadLine();
            char x;
            if (char.TryParse(input, out x))
            {
                if ((int)x >= 50 && (int)x <= 57) //Check for numbers 2 to 9
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    switch (input)
                    {
                        case "A": Console.WriteLine("Yes");
                            break;

                        case "J": Console.WriteLine("Yes");
                            break;

                        case "K": Console.WriteLine("Yes");
                            break;

                        case "Q": Console.WriteLine("Yes");
                            break;

                        default: Console.WriteLine("No");
                            break;
                    }
                }
            }
            else if (input == "10")
            {
                Console.WriteLine("Yes");
            }
        }
    }
}