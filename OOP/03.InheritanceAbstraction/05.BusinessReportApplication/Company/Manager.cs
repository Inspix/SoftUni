using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Company
{
    public class Manager : Employee,IManager
    {
        private List<IEmployee> employees;

        public Manager()
        {
            this.employees = new List<IEmployee>();
        }

        public Manager(int id, string fname, string lname, double salary, string department, List<IEmployee> employees)
            : base(id,fname,lname,department,salary)
        {
            this.Employees = employees;
        }

        public List<IEmployee> Employees
        {
            get { return this.employees; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("The list of employees has to contain something");
                }
                this.employees = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "\nEmployees:" + string.Join("\n", this.Employees);
        }
    }
}
