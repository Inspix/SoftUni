using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Company
{
    public interface IPerson
    {
        int ID { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
 
    }
}
