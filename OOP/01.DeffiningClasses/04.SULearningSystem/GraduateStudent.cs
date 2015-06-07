using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.SULearningSystem
{
    public class GraduateStudent : Student
    {
        public GraduateStudent() { }

        public GraduateStudent(string name, string lname, int age) : base(name, lname, age) { }

        public GraduateStudent(string name, string lname, int age, int studentNumber)
            : base(name, lname, age, studentNumber) { }

        public GraduateStudent(string name, string lname, int age, int studentnumber, double avgrade)
            : base(name, lname, age,studentnumber,avgrade){ }
        

        public override string ToString()
        {
            return base.ToString() + "\nGraduate Student";
        }
    }
}
