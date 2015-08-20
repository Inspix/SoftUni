
namespace _02.ProductsInPriceRange
{
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;

    using Wintellect.PowerCollections;

    class Program
    {
        static Random rng = new Random();
        static void Main(string[] args)
        {
            OrderedBag<Product> products = PrepareData();
            Product lowerRange = new Product() {Name = "Mock", Price = 0};
            Product hiRange = new Product() { Name = "Mock", Price = 0 };
            Stopwatch sw = new Stopwatch();
            StreamWriter sr = new StreamWriter("../../Results.txt");
           
            for (int i = 0; i < 10000; i++)
            {
                lowerRange.Price = rng.Next(0, 9999);
                hiRange.Price = rng.Next((int)lowerRange.Price, 10001);
                sw.Restart();
                int counter = 0;
                // Enumerate through 20 products in the given range.
                foreach (var product in products.Range(lowerRange,true,hiRange,true))
                {
                    //Console.WriteLine(product);
                    
                    if (counter++ == 20)
                    {
                        break;
                    }
                }
                sw.Stop();
                sr.WriteLine(string.Format("{3}Search in price Range({0}-{1}) - Time: {2}",lowerRange.Price,hiRange.Price,sw.Elapsed, i));
            }
            sr.Close();
        }

        /// <summary>
        /// Load the MockData 50 times to make 500 000 entries.
        /// </summary>
        /// <returns><see cref="OrderedBag{Product}"/></returns>
        static OrderedBag<Product> PrepareData()
        {
            OrderedBag<Product> result = new OrderedBag<Product>();
            for (int i = 1; i <= 50; i++)
            {
                using (StreamReader sr = new StreamReader("MockData.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] data = line.Split('$').Select(s => s.Trim()).ToArray();
                        result.Add(new Product { Name = i + ":" + data[0], Price = decimal.Parse(data[1]) + i });
                    }
                } 
            }
            return result;
        }
    }

    public class Product : IComparable<Product>
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public int CompareTo(Product other)
        {
            return this.Price.CompareTo(other.Price);
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}", this.Name, this.Price);
        }
    }
}
