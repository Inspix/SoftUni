using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace Company
{
    public class Employee : Person,IEmployee
    {
        private double salary;
        private string department;

        public Employee()
        {
            
        }

        public Employee(int id, string fname, string lname, string department, double salary)
            : base(id,fname,lname)
        {
            this.Department = department;
            this.Salary = salary;
        }


        public double Salary
        {
            get { return this.salary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Salary must be greater than 0");
                }
                this.salary = value;
            }
        }

        public string Department
        {
            get { return this.department; }
            set
            {
                switch (value)
                {
                    case "Production":
                        this.department = value;
                        break;
                    case "Accounting":
                        this.department = value;
                        break;
                    case "Marketing":
                        this.department = value;
                        break;
                    case "Sales":
                        this.department = value;
                        break;
                    default:throw new ArgumentException("Invalid department");
                }
            }
        }

        public override string ToString()
        {
            return string.Format("{0}\n\n",this.Department) +  base.ToString() + string.Format("\nSalary:{0:C}", this.Salary);
        }
    }
}
