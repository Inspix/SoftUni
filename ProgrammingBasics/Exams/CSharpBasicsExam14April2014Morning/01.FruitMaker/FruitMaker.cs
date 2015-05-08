using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace _01.FruitMaker
{
    public class Product
    {
        public string Name { set; get; }

        public double Price { set; get; }

        public string Type { set; get; }

        public Product(string name, double price, string type)
        {
            Name = name;
            Price = price;
            Type = type;
        }
    }

    internal class FruitMaker
    {
        public static List<Product> products = new List<Product>();
        public static double check;

        private static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            products.Add(new Product("banana", 1.80, "Fruit"));
            products.Add(new Product("cucumber", 2.75, "Vegetable"));
            products.Add(new Product("tomato", 3.20, "Vegetable"));
            products.Add(new Product("orange", 1.60, "Fruit"));
            products.Add(new Product("apple", 0.86, "Fruit"));

            string day = Console.ReadLine();
            discount(day);
            double quantity1 = double.Parse(Console.ReadLine());
            string product1 = Console.ReadLine();
            addToCheck(quantity1, product1);
            double quantity2 = double.Parse(Console.ReadLine());
            string product2 = Console.ReadLine();
            addToCheck(quantity2, product2);
            double quantity3 = double.Parse(Console.ReadLine());
            string product3 = Console.ReadLine();
            addToCheck(quantity3, product3);
            Console.WriteLine(String.Format("{0:0.00}", Math.Round(check, 2)));
        }

        private static void addToCheck(double q, string product)
        {
            Product price = products.Find(x => x.Name == product);
            check += price.Price * q;
        }

        private static void discount(string day)
        {
            switch (day)
            {
                case "Friday": foreach (Product item in products)
                    {
                        item.Price -= item.Price * 0.10;
                    }
                    break;

                case "Sunday": foreach (Product item in products)
                    {
                        item.Price -= item.Price * 0.05;
                    }
                    break;

                case "Tuesday": foreach (Product item in products)
                    {
                        if (item.Type == "Fruit")
                        {
                            item.Price -= item.Price * 0.20;
                        }
                    }
                    break;

                case "Wednesday": foreach (Product item in products)
                    {
                        if (item.Type == "Vegetable")
                        {
                            item.Price -= item.Price * 0.10;
                        }
                    }
                    break;

                case "Thursday": foreach (Product item in products)
                    {
                        if (item.Name == "banana")
                        {
                            item.Price -= item.Price * 0.30;
                            break;
                        }
                    }
                    break;

                default:
                    break;
            }
        }
    }
}