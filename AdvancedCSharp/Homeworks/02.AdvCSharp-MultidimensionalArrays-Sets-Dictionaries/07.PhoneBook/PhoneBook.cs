using System;
using System.Collections.Generic;

class PhoneBook
{
    static Dictionary<string, List<string>> phoneBook = new Dictionary<string, List<string>>();

    static void Main()
    {
        string command = "";
        do
        {
            command = Console.ReadLine();
            string[] number = command.Split(' ');
            if (number.Length == 2)
            {
                if (phoneBook.ContainsKey(number[0]))
                {
                    phoneBook[number[0]].Add(number[1]);

                }
                else
                {
                    phoneBook.Add(number[0], new List<string>{number[1]});
                }
            }
            else if (command == "search")
            {
                break;
            }
            else
            {
                Console.WriteLine("Please enter a valid name/number...");
                continue;
            }
        } while (true);

        do
        {
            command = Console.ReadLine();
            if (phoneBook.ContainsKey(command))
            {
                Console.Write(command+ " ");
                foreach (string str in phoneBook[command])
                {
                    Console.Write("\n  Number:" + str);
                }
            }
            else if (command == "END")
            {
                break;
            }
            else
            {
                Console.WriteLine("Contact does not exist!");
            }
        } while (true);
    }
}
