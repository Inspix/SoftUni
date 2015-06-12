using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Animals
{
    public abstract class Animal
    {
        private int age;
        private string name;
        private string gender;

        protected Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public int Age
        {
            get { return this.age; }
            set {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Animal age should be positive number");
                }
                this.age = value;
            }
        }

        public string Name
        {
            get { return this.name; }
            set {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Animal name should contain name...");
                }
                this.name = value;
            }
        }

        public string Gender
        {
            get { return this.gender; }
            set
            {
                if (value.ToLower() == "male" || value.ToLower() == "female")
                {
                    this.gender = value.ToLower();

                }
                else
                {
                    throw new ArgumentException("the gender should be male or female");
                }

            }
        }

        public override string ToString()
        {
            return string.Format("Name: {0}, Age: {1} Gender: {2}", this.Name, this.Age, this.Gender);
        }
    }
}
