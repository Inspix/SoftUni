using _01.Dictionary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PhoneBook
{
    class Program
    {
        static HashTable<string, string> phoneBook = new HashTable<string, string>();
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a name and number(seperated by a dash) to add to the phonebook or type search to search in it:");

            string input = Console.ReadLine();
            while (input != "search")
            {
                string[] values = input.Split('-');
                if (values.Length != 2)
                {
                    Console.WriteLine("Invalid input format, try again");
                    input = Console.ReadLine();
                    continue;
                }
                phoneBook.Add(values[0], values[1]);
                input = Console.ReadLine();
            }
            Console.WriteLine("Enter the name you want to search for or 'end' to exit: \n");
            while(input != "end")
            {
                input = Console.ReadLine();
                string output;
                if (phoneBook.TryGetValue(input, out output))
                {
                    Console.WriteLine(input + "->" + output);
                }
                else
                {
                    Console.WriteLine("Contact " + input + " does not exist.");
                }
            }
            Console.WriteLine("Bye");
        }
    }
}
