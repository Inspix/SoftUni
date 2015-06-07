using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.SULearningSystem
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;

        public Person()
        {
            
        }

        public Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }


        public string FirstName
        {
            get { return this.firstName; }
            set {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Student has to have a first name");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Student has to have a last name");
                }
                this.lastName = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            set {
                if (value < 10)
                {
                    throw new ArgumentException("The student has to be older than 11 years");
                }
                this.age = value;
            }
        }


        public override string ToString()
        {
            return string.Format("First Name: {0}\nLast Name: {1}\nAge:{2}", this.FirstName, this.LastName, this.age);
        }
    }
}
