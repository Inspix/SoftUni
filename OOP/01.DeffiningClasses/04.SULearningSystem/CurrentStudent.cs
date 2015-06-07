using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.SULearningSystem
{
    public class CurrentStudent : Student
    {
        private string currentCourse;
        
        public CurrentStudent() { }

        public CurrentStudent(string name, string lname, int age) : base(name, lname, age) { }

        public CurrentStudent(string name, string lname, int age, int studentNumber)
            : base(name, lname, age, studentNumber) {}

        public CurrentStudent(string name, string lname, int age, int studentnumber, double avgrade)
            : base(name, lname, age,studentnumber,avgrade){}

        public CurrentStudent(string name, string lname, int age, int studentnumber, double avgrade,
            string currentCourse)
            : base(name, lname, age, studentnumber, avgrade)
        {
            this.CurrentCourse = currentCourse;
        }

        public string CurrentCourse
        {
            get { return currentCourse; }
            set {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The course has to contain characters...");
                }
                this.currentCourse = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}\nCurrent course: {1}\nStatus: {2}", base.ToString(), this.CurrentCourse, "Current Student");
        }
    }
}
