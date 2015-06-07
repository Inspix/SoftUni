using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.SULearningSystem
{
    public class OnsiteStudent : CurrentStudent
    {
        private int numberOfVisits;
        public OnsiteStudent() { }

        public OnsiteStudent(string name, string lname, int age) : base(name, lname, age) { }

        public OnsiteStudent(string name, string lname, int age, int studentNumber)
            : base(name, lname, age, studentNumber) { }

        public OnsiteStudent(string name, string lname, int age, int studentnumber, double avgrade)
            : base(name, lname, age,studentnumber,avgrade){ }

        public OnsiteStudent(string name, string lname, int age, int studentnumber, double avgrade,
            string currentCourse)
            : base(name, lname, age, studentnumber, avgrade,currentCourse){ }

        public OnsiteStudent(string name, string lname, int age, int studentnumber, double avgrade,
            string currentCourse, int numberofvisits)
            : base(name, lname, age, studentnumber, avgrade, currentCourse)
        {
            this.NumberOfVisits = numberofvisits;
        }

        public int NumberOfVisits
        {
            get { return numberOfVisits; }
            set {
                if (numberOfVisits < 0)
                {
                    throw new ArgumentException("Number of visits has to be positive number...");
                }
                this.numberOfVisits = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "\nType: Onsite Student";
        }
    }
}
