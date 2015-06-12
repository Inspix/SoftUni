using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.HumanStudenWorker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            List<Worker> workers = new List<Worker>();

            students.Add(new Student("Matey", "Mihaylov", 11453));
            students.Add(new Student("Yasen", "Asenov", 91453));
            students.Add(new Student("Todor", "Yasenov", 81453));
            students.Add(new Student("Zdravko", "Todorov", 13453));
            students.Add(new Student("Mihayl", "Zdravkov", 150453));
            students.Add(new Student("Asen", "Vanev", 167453));
            students.Add(new Student("Iliana", "Mihaylov", 065453));
            students.Add(new Student("Polina", "Vaneva", 114453));
            students.Add(new Student("Marta", "Genkova", 404453));
            students.Add(new Student("Teodora", "Mihaylova", 156453));
            students.Add(new Student("Denica", "Genkova", 124453));
            students.Add(new Student("Ioana", "Todorova", 1113453));

            workers.Add(new Worker("Matey", "Mihaylov", 24.5f,2000));
            workers.Add(new Worker("Yasen", "Asenov", 60,90453));
            workers.Add(new Worker("Todor", "Yasenov",12, 453));
            workers.Add(new Worker("Zdravko", "Todorov", 80, 6453));
            workers.Add(new Worker("Mihayl", "Zdravkov", 100,50453));
            workers.Add(new Worker("Asen", "Vanev", 14,6453));
            workers.Add(new Worker("Iliana", "Mihaylov",25.4f, 65453));
            workers.Add(new Worker("Polina", "Vaneva", 35.5f, 1453));
            workers.Add(new Worker("Marta", "Genkova", 40,4453));
            workers.Add(new Worker("Teodora", "Mihaylova",30,5453));
            workers.Add(new Worker("Denica", "Genkova", 2,53));
            workers.Add(new Worker("Ioana", "Todorova",10,3453));

            var orderedStudents = students.OrderBy(s => s.FacultyNumber);
            var orderedWorkers = workers.Select(s => new { worker = s, salary = s.MoneyPerHour()}).OrderByDescending(s => s.salary);
            var orderedHumans = students.Cast<Human>().Concat(workers).OrderBy(s => s.FirstName).ThenBy(s => s.LastName);

            Console.WriteLine("Students ----------------");

            foreach (var student in orderedStudents)
            {
                Console.WriteLine(student);
                Console.WriteLine();
            }
            Console.WriteLine("Workers ----------------");
            foreach (var worker in orderedWorkers)
            {
                Console.WriteLine(worker.worker);
                Console.WriteLine("Money per hour: {0:C}",worker.salary);
                Console.WriteLine();
            }
            Console.WriteLine("Workers/Students Sorted----");
            foreach (var orderedHuman in orderedHumans)
            {
                Console.WriteLine(orderedHuman.FirstName + " " + orderedHuman.LastName);
                Console.WriteLine();
            }


        }
    }
}
