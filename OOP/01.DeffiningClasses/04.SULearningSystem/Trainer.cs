using System;
using System.Collections.Generic;

namespace _04.SULearningSystem
{
    public class Trainer : Person
    {
        private static List<string> courses;

        public Trainer()
        {
            
        }

        public Trainer(string name, string lname, int age)
            : base(name, lname, age)
        {
        }

        public Trainer(string name, string lname, int age, List<string> courseList) 
            : base(name, lname, age)
        {
            this.Courses = courseList;
        }

        public void CreateCourse(string cName)
        {
            if (courses == null)
            {
                courses = new List<string>();
            }
            courses.Add(cName);
            Console.WriteLine("Course {0} created!",cName);
        }

        public List<string> Courses
        {
            get { return courses;}
            set { courses = value;}
        }

        public override string ToString()
        {
            return string.Format("{1} : {0}", "Trainer", base.ToString());
        }
    }
}
