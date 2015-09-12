namespace _01.StudentsAndCourses
{
    using System;

    public class Person : IComparable<Person>
    {
        private string firstName;

        private string lastName;

        public Person(string firstname, string lastname)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(this.FirstName),"The name should contain letters");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(this.LastName), "The name should contain letters");
                }
                this.lastName = value;
            }
        }


        public int CompareTo(Person other)
        {
            return String.Compare(this.FirstName, other.FirstName, StringComparison.Ordinal);
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", this.FirstName, this.LastName);
        }
    }
}