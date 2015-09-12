using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.StudentsAndCourses
{
    class Program
    {

        static string[] input = new[] {
                "Stela    | Mineva   | Java",
                "Yasen    | Ivanov   | C#",
                "Stefka   | Nikolova | SQL",
                "Miroslav | Tsenov   | SQL",
                "Milena   | Petrova  | C#",
                "Asya     | Yankova  | SQL",
                "Ivan     | Grigorov | C#",
                "Ivan     | Kolev    | SQL",
                "Vanya    | Angelova | Java",
                "Todor    | Georgiev | SQL" };

        static Dictionary<string, SortedSet<Person>> courseInfo = new Dictionary<string, SortedSet<Person>>(); 
        static void Main(string[] args)
        {
            foreach (var line in input)
            {
                string[] tokens = line.Split('|').Select(s => s.Trim()).ToArray();
                string firstName = tokens[0];
                string lastName = tokens[1];
                string courseName = tokens[2];

                Person toAdd = new Person(firstName, lastName);
                if (!courseInfo.ContainsKey(courseName))
                {
                    courseInfo[courseName] = new SortedSet<Person>() {toAdd};
                }
                else
                {
                    courseInfo[courseName].Add(toAdd);
                }

            }


            Print();

        }

        static void Print()
        {
            foreach (var course in courseInfo)
            {
                Console.WriteLine(course.Key);
                foreach (var person in course.Value)
                {
                    Console.WriteLine(" - " + person);
                }
            }
        }
    }
}
