using System;
using System.Globalization;
using System.Linq;
using System.Threading;
using Orders.Models;

namespace Orders
{
    class Program
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            var dataMapper = new DataMapper();
            var allCategories = dataMapper.GetAllCategories() as Category[] ?? dataMapper.GetAllCategories().ToArray();
            var allProducts = dataMapper.GetAllProducts() as Product[] ?? dataMapper.GetAllProducts().ToArray();
            var allOrders = dataMapper.GetAllOrders() as Order[] ?? dataMapper.GetAllOrders().ToArray();

            // Names of the 5 most expensive products
            var first = allProducts
                .OrderByDescending(p => p.UnitPrice)
                .Take(5)
                .Select(p => p.Name);
            Console.WriteLine(string.Join(Environment.NewLine, first));

            Console.WriteLine(new string('-', 10));

            // Number of products in each Category
            var second = allProducts
                .GroupBy(p => p.CategoryId)
                .Select(grp => new { Category = allCategories.First(c => c.Id == grp.Key).Name, Count = grp.Count() })
                .ToList();
            foreach (var item in second)
            {
                Console.WriteLine("{0}: {1}", item.Category, item.Count);
            }

            Console.WriteLine(new string('-', 10));

            // The 5 top products (by Order Quantity)
            var third = allOrders
                .GroupBy(group => group.ProductId)
                .Select(orders => new { Product = allProducts.First(p => p.Id == orders.Key).Name, Quantities = orders.Sum(s => s.Quantity) })
                .OrderByDescending(q => q.Quantities)
                .Take(5);
            foreach (var item in third)
            {
                Console.WriteLine("{0}: {1}", item.Product, item.Quantities);
            }

            Console.WriteLine(new string('-', 10));

            // The most profitable Category
            var category = allOrders
                .GroupBy(groupId => groupId.ProductId)
                .Select(pId => new { allProducts.First(p => p.Id == pId.Key).CategoryId, Price = allProducts.First(p => p.Id == pId.Key).UnitPrice, Quantity = pId.Sum(q => q.Quantity) })
                .GroupBy(groupCatId => groupCatId.CategoryId)
                .Select(catId => new { Category = allCategories.First(c => c.Id == catId.Key).Name, TotalQuantity = catId.Sum(g => g.Quantity * g.Price) })
                .OrderByDescending(g => g.TotalQuantity)
                .First();
            Console.WriteLine("{0}: {1}", category.Category, category.TotalQuantity);
        }
    }
}
