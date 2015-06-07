using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.SULearningSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            JuniorTrainer jt = new JuniorTrainer("Azis", "Pedro", 55);
            jt.CreateCourse("C#");
            SeniorTrainer st = new SeniorTrainer("Kalin","kolev",22);
            st.RemoveCourse("C#");
            List<Person> persons = new List<Person>();
            DropoutStudent ds = new DropoutStudent("Pesho", "Ivanov", 25);
            ds.DropoutReason = "sucks";
            ds.Reapply();
            persons.Add(jt);
            persons.Add(st);
            persons.Add(ds);
            persons.Add(new GraduateStudent("Asen","Marinov",53){AvgGrade = 5.5d});
            
            persons.Add(new OnlineStudent("Loki1","Thor",25,2554,5.4,"OOP"));
            persons.Add(new OnsiteStudent("Asen","Lazarov",25){ Age = 25, CurrentCourse = "C#" , AvgGrade = 4.5d});
            persons.Add(new CurrentStudent() { Age = 23, CurrentCourse = "C#", FirstName = "Ce", LastName = "Bq",AvgGrade = 6.0d});
            persons.Add(new CurrentStudent() { Age = 22, CurrentCourse = "C#", FirstName = "Loki3", LastName = "Thor",AvgGrade = 5.4d});


            var personz = persons.Select(s => s).OfType<CurrentStudent>().OrderBy(s => s.AvgGrade);


            foreach (var person in personz)
            {
                Console.WriteLine(person);
                Console.WriteLine(person.AvgGrade);
                Console.WriteLine();
            }
            
        }
    }
}
