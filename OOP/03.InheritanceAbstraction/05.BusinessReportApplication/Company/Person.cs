using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Company
{
    public class Person : IPerson
    {
        private int id;
        private string firstName;
        private string lastName;

        public Person()
        {
            
        }

        public Person(int id, string fname, string lname)
        {
            this.ID = id;
            this.FirstName = fname;
            this.LastName = lname;
        }

        public int ID
        {
            get { return this.id; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("ÏD shoud be positive");
                }
                this.id = value;
            }
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                     throw new ArgumentException("First name should countain characters");
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
                    throw new ArgumentException("Last name should countain characters");
                }
                this.lastName = value;
            }
        }

        public override string ToString()
        {
            return string.Format("ID:{0}, First name:{1}, Last Name:{2}", this.ID, this.FirstName, this.LastName);
        }
    }
}
