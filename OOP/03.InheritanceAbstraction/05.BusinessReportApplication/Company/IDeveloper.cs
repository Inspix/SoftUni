using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company;

namespace Company
{
    interface IDeveloper
    {
        List<Project> Projects { get; set; }
    }
}
