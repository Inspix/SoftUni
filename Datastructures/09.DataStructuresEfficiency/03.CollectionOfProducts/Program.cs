using System;

namespace _03.CollectionOfProducts
{
    class Program
    {
        static Random rng = new Random();
        static void Main(string[] args)
        {
            ProductCollection collection = new ProductCollection();

            for (int i = 0; i < 1000; i++)
            {
                collection.Add(new Product() {Id = i, Price = rng.Next(1,150000),Supplier = "Lenovo",Title = "ThinkPad " + i});
            }

            for (int i = 1000; i < 2000; i++)
            {
                collection.Add(new Product() { Id = i, Price = rng.Next(1, 150000), Supplier = "IBM" + i, Title = "Product " + i });
            }



            var product = collection.Find(2);
            Console.WriteLine(product);

            var products = collection.FindBySupplierAndPriceRange("Lenovo", 100m, 110m);
            Console.WriteLine(string.Join("\n",products));
            Console.WriteLine(collection.Count);

            for (int i = 0; i < 500; i++)
            {
                collection.Remove(rng.Next(0, 2000));
            }

            products = collection.FindBySupplierAndPriceRange("Lenovo", 1m, 5000m);
            Console.WriteLine(string.Join("\n", products));
            Console.WriteLine(collection.Count);
        }
    }
}
