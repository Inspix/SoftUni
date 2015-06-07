using System;
using System.Reflection.Emit;

namespace _04.SULearningSystem
{
    public class Student : Person
    {
        private int studentNumber;
        private double avgGrade;

        public Student() { }

        public Student(string name, string lname, int age) : base(name, lname, age) { }

        public Student(string name, string lname, int age, int studentNumber)
            : base(name, lname, age)
        {
            this.StudentNumber = studentNumber;
        }

        public Student(string name, string lname, int age, int studentnumber, double avgrade)
            : this(name, lname, age,studentnumber)
        {
            this.AvgGrade = avgrade;
        }


        public int StudentNumber 
        {
            get { return studentNumber; }
            set {
                if (value < 0)
                {
                    throw new ArgumentException("student number has to be bigger than 0");
                }
                this.studentNumber = value;
            }
        }

        public double AvgGrade
        {
            get { return avgGrade; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("student grade has to be bigger than 0");
                }
                this.avgGrade = value;
            }
        }
    }
}
