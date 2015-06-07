using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.PCCatalog
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Computer> comps = new List<Computer>();
            Computer pc = new Computer("PC 1");
            pc.AddComponent("Graphics Card",555.3m);
            pc.AddComponent("RAM",100m);
            pc.AddComponent("Mouse",55.5m,"Razer Naga");
            comps.Add(pc);

            Computer pc2 = new Computer("PC 2", new List<Components>{new Components("Graphics Card",543.99m), new Components("CPU",340.5m)});
            comps.Add(pc2);

            foreach (var computer in comps.OrderByDescending(s => s.TotalPrice))
            {
                computer.DisplayConfiguration();
            }
        }
    }

    class Computer
    {
        private string name;
        private decimal totalPrice;
        private List<Components> components;

        public Computer(string name)
        {
            this.Name = name;
        }

        public Computer(string name, List<Components> components) : this(name)
        {
            this.Components = components;
            CalculatePrice();
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Computer name should contain characters");
                }
                this.name = value;
            }
        }

        public decimal TotalPrice
        {
            get
            {
                if (this.totalPrice <= 0)
                {
                    this.CalculatePrice();
                }
                return totalPrice;
            }
        }

        public List<Components> Components
        {
            get { return this.components; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Component list shoud contain entries..");
                }
                this.components = value;
            }
        }

        public void AddComponent(string cName, decimal cPrice, string details = "No details")
        {
            if (this.components == null)
            {
                components = new List<Components>();
            }
            this.components.Add(new Components(cName, details, cPrice));
        }

        public void CalculatePrice()
        {
            this.totalPrice = components.Select(s => s.Price).Sum();
        }

        public void DisplayConfiguration()
        {
            Console.WriteLine("\nComputer name:{0}", this.name);
            foreach (var component in components)
            {
                Console.WriteLine(component);
            }
            Console.WriteLine("{0:C}",this.TotalPrice);
        }
}

    class Components
    {
        private string name;
        private string details;
        private decimal price;

        public Components(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public Components(string name, string details, decimal price) : this(name,price)
        {
            this.Details = details;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("component name should contain characters");
                }
                this.name = value;
            }
        }

        public string Details
        {
            get { return this.details; }
            set {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("component details should contain characters");
                }
                this.details = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            set {
                if (value < 0)
                {
                    throw new ArgumentException("The price should be positive number");
                }
                this.price = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Component:{0}, Details:{1}, Price:{2:C}", this.name, this.details ?? "No details", this.price);
        }
    }
}
