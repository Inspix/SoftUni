using System;

namespace _02.Laptop
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop test = new Laptop("Lenovo Idea Pad","Lenovo","Intel Core 2 Duo",599.55m);
            Console.WriteLine(test);

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine(test.ToString(true));
        }
    }

    class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private string ram;
        private string graphicsCard;
        private string hdd;
        private string screen;
        private Battery battery;
        private decimal price;

        #region Fields
        public string Model
        {
            get { return this.model; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("laptop model must contain characters");
                }
                this.model = value;
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("laptop manufacturer must contain characters");
                }
                this.manufacturer = value;
            }
        }

        public string Processor
        {
            get { return this.processor; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("laptop processor must contain characters");
                }
                this.processor = value;
            }
        }

        public string Ram
        {
            get { return this.ram; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("laptop ram must contain characters");
                }
                this.ram = value;
            }
        }

        public string GraphicsCard
        {
            get { return this.graphicsCard; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("laptop graphics card must contain characters");
                }
                this.graphicsCard = value;
            }
        }

        public string Hdd
        {
            get { return this.hdd; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("laptop hdd must contain characters");
                }
                this.hdd = value;
            }
        }

        public string Screen
        {
            get { return this.screen; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("laptop screen must contain characters");
                }
                this.screen = value;
            }
        }

        public Battery Battery
        {
            get { return this.battery; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("battery can't be null");

                }
                this.battery = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("laptop price can not be negative");
                }
                this.price = value;
            }
        } 
        #endregion

        public Laptop(string model, decimal price)
        {
            this.Price = price;
            this.Model = model;
        }

        public Laptop(string model, string manufacturer, string processor, decimal price) : this(model, price)
        {
            this.Manufacturer = manufacturer;
            this.Processor = processor;
        }

        public Laptop(string model, string manufacturer, string processor, string ram, string graphicscard,
            decimal price) : this(model, manufacturer, processor, price)
        {
            this.Ram = ram;
            this.GraphicsCard = graphicscard;
        }

        public Laptop(string model, string manufacturer, string processor, string ram, string graphicscard, string hdd,
            string screen, string batteryType, double batterylife, decimal price)
            : this(model, manufacturer, processor, ram, graphicscard, price)
        {
            this.Hdd = hdd;
            this.Screen = screen;
            this.Battery = new Battery(batteryType,batterylife);
        }

        public override string ToString()
        {
            return string.Format("{0,-15}|{1,-15}\n{2,-15}|{3,-15}\n{4,-15}|{5,-15}\n{6,-15}|{7,-15}\n{8,-15}|{9,-15}\n{10,-15}|{11,-15}\n{12,-15}|{13,-15}\n{14,-15}|{15,-15}\n{16,-15}|{17,-15}\n{18,-15}|{19,-15:C}",
                "model", this.model ?? "missing", "manufacturer", this.manufacturer ?? "missing", "processor", this.processor ?? "missing", "RAM", this.ram ?? "missing", "graphics card", this.graphicsCard ?? "missing",
                "hdd", this.hdd ?? "missing", "screen", this.screen ?? "missing", "battery", this.battery == null ? "missing" : this.battery.BatteryType, "battery life", this.battery == null ? 0 : battery.BatteryLife, "price", this.price);
        }

        public string ToString(bool shortdesc)
        {
            if (shortdesc)
            {
                return String.Format("{0,-15}|{1,-15}\n{2,-15}|{3,-15:C}", "model",this.model, "price",this.price);
            }
            return this.ToString();
        }
    }

    class Battery
    {
        private string batteryType;
        private double batterylife;

        public string BatteryType
        {
            get { return this.batteryType; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("battery type cant be empty or null");
                }
                this.batteryType = value;
            }
        }

        public double BatteryLife
        {
            get { return batterylife; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("battery life cant be a negative number");
                }
                this.batterylife = value;
            }
        }


        public Battery(string batteryType, double batterylife)
        {
            this.BatteryType = batteryType;
            this.BatteryLife = batterylife;
        }
    }
}
