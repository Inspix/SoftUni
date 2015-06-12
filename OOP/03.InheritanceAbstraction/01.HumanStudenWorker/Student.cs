using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.HumanStudenWorker
{
    internal class Student : Human
    {
        private long facultyNumber;

        public Student(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public Student(string firstname, string lastname, int facultyN) : base(firstname, lastname)
        {
            this.FacultyNumber = facultyN;
        }

        public long FacultyNumber
        {
            get { return this.facultyNumber; }
            set
            {
                if (value < 9999 || value > 10000000000)
                {
                    throw new ArgumentOutOfRangeException("The faculty number must be between 5 and 10 digits long(10000 - 9999999999");
                }
                this.facultyNumber = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "\nFaculty number: " + this.FacultyNumber;
        }
    }
}
