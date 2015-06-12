using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.HumanStudenWorker
{
    abstract class Human
    {
        protected string firstName;
        protected string lastName;

        protected Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("The first name should contain characters..");
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
                    throw new ArgumentNullException("The last name should contain characters..");
                }
                this.lastName = value;
            }
        }

        public override string ToString()
        {
            return string.Format("First name: {0}\nLast name: {1}", this.FirstName, this.LastName);
        }
    }
}
