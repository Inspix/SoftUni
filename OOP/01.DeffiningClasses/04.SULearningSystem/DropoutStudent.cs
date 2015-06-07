using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.SULearningSystem
{
    public class DropoutStudent : Student
    {
        private string dropoutReason;
        public DropoutStudent() { }

        public DropoutStudent(string name, string lname, int age) : base(name, lname, age) { }

        public DropoutStudent(string name, string lname, int age, int studentNumber)
            : base(name, lname, age, studentNumber) { }

        public DropoutStudent(string name, string lname, int age, int studentnumber, double avgrade)
            : base(name, lname, age,studentnumber,avgrade){ }

        public DropoutStudent(string name, string lname, int age, int studentnumber, double avgrade,
            string dropoutReason)
            : base(name, lname, age, studentnumber, avgrade)
        {
            this.DropoutReason = dropoutReason;
        }

        public string DropoutReason
        {
            get { return dropoutReason; }
            set {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("dropout reason has to contain characters...");
                }
                this.dropoutReason = value;
            }
        }

        public void Reapply()
        {
            Console.WriteLine(base.FirstName + " " + base.LastName +" " + base.Age + "| Reason:" + this.dropoutReason);
        }
    }
}
