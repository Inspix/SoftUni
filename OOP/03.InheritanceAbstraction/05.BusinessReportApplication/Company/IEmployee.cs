using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Company
{
    public interface IEmployee : IPerson
    {
        double Salary { get; set; }
        string Department { get; set; }
    }
}
