using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.SULearningSystem
{
    public class SeniorTrainer : Trainer
    {
        public SeniorTrainer(){}

        public SeniorTrainer(string name, string lname, int age)
            :base(name,lname,age)
        {
            base.FirstName = name;
            base.LastName = lname;
            base.Age = age;
        }

        public SeniorTrainer(string name, string lname, int age, List<string> courses)
            : base(name, lname, age, courses){}

        public void RemoveCourse(string cName)
        {
            base.Courses.Remove(cName);
            Console.WriteLine("Course {0} deleted",cName);
        }
    }
}
