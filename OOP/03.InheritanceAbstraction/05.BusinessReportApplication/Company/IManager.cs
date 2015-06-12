using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Company
{
    public interface IManager
    {
        List<IEmployee> Employees { get; set; } 
    }
}
