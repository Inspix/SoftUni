using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
/*Define a class Person that has name, age and email. The name and age are mandatory. 
 * The email is optional. Define properties that accept non-empty name and age in the range [1...100]. 
 * In case of invalid argument, throw an exception. Define a property for the email that accepts either null 
 * or non-empty string containing '@'. Define two constructors. The first constructor should take name, age and email.
 * The second constructor should take name and age only and call the first constructor. Implement the ToString() 
 * method to enable printing persons at the console.*/
namespace _01.Persons
{
    class Program
    {
        static void Main(string[] args)
        {
            Person x = new Person("Bobko",25);
            Console.WriteLine(x);
        }
    }

    class Person
    {
        private string name;
        private int age;
        private string email;

        #region fields

        public string Name
        {
            get { return this.name; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    name = value;
                }
                else
                {
                    throw new Exception("The person name, should contain letters..");
                }
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value > 0 && value < 100)
                {
                    this.age = value;
                }
                else
                {
                    throw new Exception("The person age, should be between 1 and 100..");
                }
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                if (value.Contains('@') || value == null) // "Perfect" mail checker but thats what the problem wants as condition
                {

                    email = value;
                }
                else
                {
                    throw new Exception("The person email should be valid..");
                }
            }
        } 
        #endregion

        public Person(string name, int age, string email)
        {
            this.name = name;
            this.age = age;
            this.email = email;
        }

        public Person(string name, int age) : this(name, age,null)
        {
        }

        public override string ToString()
        {
            return String.Format("Name: {0}, Age: {1}, Email: {2}", this.name, this.age,
                this.email ?? "None" );
        }
    }
}
