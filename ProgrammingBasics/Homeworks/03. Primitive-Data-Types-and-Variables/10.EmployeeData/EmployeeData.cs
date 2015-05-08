/*A marketing company wants to keep record of its employees. Each record would have the 
 * following characteristics:
 * •	First name
 * •	Last name
 * •	Age (0...100)
 * •	Gender (m or f)
 * •	Personal ID number (e.g. 8306112507)
 * •	Unique employee number (27560000…27569999)
 * Declare the variables needed to keep the information for a single employee using 
 * appropriate primitive data types. Use descriptive names. Print the data at the console.
*/
using System;

namespace EmployeeData
{
    internal class EmployeeData
    {
        private static void Main(string[] args)
        {
            string firstName = "Plamen";
            string lastName = "Ignatov";
            int age = 25;
            char gender = 'm';
            long personalID = 8306112507;
            int employeeNum = 27560000;

            Console.WriteLine("{0,-23}{1}", "Name:", firstName);
            Console.WriteLine("{0,-23}{1}", "Last Name:", lastName);
            Console.WriteLine("{0,-23}{1}", "Age:", age);
            Console.WriteLine("{0,-23}{1}", "Gender:", gender);
            Console.WriteLine("{0,-23}{1}", "Personal ID number:", personalID);
            Console.WriteLine("{0,-23}{1}", "Unique employee Number:", employeeNum);
        }
    }
}