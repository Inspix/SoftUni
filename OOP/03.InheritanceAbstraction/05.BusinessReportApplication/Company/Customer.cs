using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Company
{
    public class Customer : Person
    {
        private double netPurchase;

        public Customer()
        {
            
        }

        public Customer(int id, string fname, string lname, double netPurchase)
            : base(id,fname,lname)
        {
            this.NetPurchase = netPurchase;
        }

        public double NetPurchase { get; set; }

        public override string ToString()
        {
            return base.ToString() + " Net purchase amount: " + this.NetPurchase;
        }
    }
}
