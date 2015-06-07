using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.SULearningSystem
{
    public class OnlineStudent : CurrentStudent
    {
        public OnlineStudent() { }

        public OnlineStudent(string name, string lname, int age) : base(name, lname, age) { }

        public OnlineStudent(string name, string lname, int age, int studentNumber)
            : base(name, lname, age, studentNumber) { }

        public OnlineStudent(string name, string lname, int age, int studentnumber, double avgrade)
            : base(name, lname, age,studentnumber,avgrade){ }

        public OnlineStudent(string name, string lname, int age, int studentnumber, double avgrade,
            string currentCourse)
            : base(name, lname, age, studentnumber, avgrade,currentCourse){}

        public override string ToString()
        {
            return base.ToString() + "\nType: OnlineStudent";
            
        }
    }
}
