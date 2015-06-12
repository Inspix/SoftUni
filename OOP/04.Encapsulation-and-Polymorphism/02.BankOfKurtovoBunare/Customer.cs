using System;

namespace BankOfKurtovoKonare
{
    internal class Customer
    {
        public enum AccountType
        {
            Individual,
            Company
        }

        private string firstName;
        private string lastName;
        private AccountType type;

        public Customer(string firstName, string lastName, AccountType type)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.type = type;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("The first name should contain characters");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("The last name should contain characters");
                }
                this.lastName = value;
            }
        }

        public AccountType Type
        {
            get { return this.type; }
            set { this.type = value; }
        }
    }
}
