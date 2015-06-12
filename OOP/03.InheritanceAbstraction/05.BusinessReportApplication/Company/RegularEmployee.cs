using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Company
{
    public class RegularEmployee : Employee
    {
        public RegularEmployee()
        {
            
        }

        public RegularEmployee(int id, string fname, string lname, string department, double salary)
            : base(id,fname,lname,department,salary)
        {
        }


    }
}
