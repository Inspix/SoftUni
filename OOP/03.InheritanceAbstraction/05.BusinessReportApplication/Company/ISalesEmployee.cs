using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    interface ISalesEmployee
    {
        List<Sale> Sales { get; set; }
    }
}
