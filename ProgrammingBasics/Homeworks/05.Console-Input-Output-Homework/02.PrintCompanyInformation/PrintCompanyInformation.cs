using System;
using System.Collections.Generic;

namespace PrintCompanyInformation
{
    internal class PrintCompanyInformation
    {
        private static void Main(string[] args)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            Console.Write("Please enter\nCompany name:");
            data.Add("Company name: ", Console.ReadLine());
            Console.Write("Company address:");
            data.Add("Address: ", Console.ReadLine());
            Console.Write("Phone number:");
            data.Add("Tel: ", Console.ReadLine());
            Console.Write("Fax number:");
            data.Add("Fax: ", Console.ReadLine());
            Console.Write("Website:");
            data.Add("Website:", Console.ReadLine());
            Console.Write("Manager first name:");
            string managerName = Console.ReadLine();
            Console.Write("Manager last name:");
            string managerLName = Console.ReadLine();
            Console.Write("Manager age:");
            int managerAge = getInput();
            Console.Write("Manager phone:");
            string managerPhone = Console.ReadLine();

            foreach (KeyValuePair<string, string> item in data)
            {
                if (string.IsNullOrEmpty(item.Value))
                {
                    Console.WriteLine(item.Key + "Missing");
                }
                else
                {
                    Console.WriteLine(item.Key + item.Value);
                }
            }
            Console.WriteLine("Manager:{0} {1} (age:{2},tel:{3})", managerName, managerLName, managerAge, managerPhone);
        }

        private static int getInput()
        {
            int number;
            do
            {
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    break;
                }
                else
                {
                    Console.Write("Invalid input,try again: ");
                }
            } while (true);
            return number;
        }
    }
}