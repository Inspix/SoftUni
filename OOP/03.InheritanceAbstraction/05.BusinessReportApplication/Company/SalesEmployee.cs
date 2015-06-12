using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Company
{
    public class SalesEmployee : RegularEmployee,ISalesEmployee
    {

        private List<Sale> sales;

        public SalesEmployee()
        {
            
        }

        public SalesEmployee(int id, string fname, string lname, string department, double salary, List<Sale> sales)
            : base(id,fname,lname,department,salary)
        {
            this.Sales = sales;
        }

        public List<Sale> Sales
        {
            get { return this.sales; }
            set {
                if (value == null)
                {
                    throw new ArgumentException("The sales list should countain sales");
                }
                this.sales = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "\n\nSales:" + string.Join("\n", Sales);
        }
    }
}
