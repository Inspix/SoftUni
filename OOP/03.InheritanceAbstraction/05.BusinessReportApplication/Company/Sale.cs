using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    public class Sale
    {
        private string name;
        private DateTime date;
        private double price;

        public Sale(string name, DateTime date, double price)
        {
            this.Name = name;
            this.Date = date;
            this.Price = price;
        }

        public double Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price shoud be positive number");
                }
                this.price = value;
            }
        }

        public DateTime Date
        {
            get { return this.date; }
            set
            {
                if (value < DateTime.MinValue)
                {
                    throw new ArgumentException("The sale date should be valid");
                }
                this.date = value;
            }
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The sale name should contain characters");
                }
                this.name = value;
            }
        }

        public override string ToString()
        {
            return string.Format("\nProduct name: {0}\nSale date: {1}\nProduct price: {2:c}", this.Name, this.Date,
                this.Price);
        }
    }
}
