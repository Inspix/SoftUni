namespace _03.CollectionOfProducts
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    using Wintellect.PowerCollections;

    public class ProductCollection
    {
        private Dictionary<int, Product> productsById;
        private OrderedMultiDictionary<decimal, Product> productsByPrice;
        private Dictionary<string, SortedSet<Product>> productsByTitle;
        private Dictionary<string, OrderedMultiDictionary<decimal,Product>> productsByTitlePrice;
        private Dictionary<string, OrderedMultiDictionary<decimal, Product>> productsBySupplierPrice;

        public ProductCollection()
        {
            this.productsById = new Dictionary<int, Product>();
            this.productsByPrice = new OrderedMultiDictionary<decimal, Product>(true);
            this.productsByTitle = new Dictionary<string, SortedSet<Product>>();
            this.productsByTitlePrice = new Dictionary<string, OrderedMultiDictionary<decimal,Product>>();
            this.productsBySupplierPrice = new Dictionary<string, OrderedMultiDictionary<decimal, Product>>();

        }

        public int Count { get; set; } = 0;

        public void Add(Product product)
        {
            if (!this.productsById.ContainsKey(product.Id))
            {
                this.productsById.Add(product.Id,product);
            }
            else
            {
                this.productsById[product.Id] = product;
            }

            this.productsByPrice.Add(product.Price,product);

            if (!this.productsByTitle.ContainsKey(product.Title))
            {
                this.productsByTitle.Add(product.Title,new SortedSet<Product>() {product});
            }
            else
            {
                this.productsByTitle[product.Title].Add(product);
            }

            if (!this.productsByTitlePrice.ContainsKey(product.Title))
            {
                var dict = new OrderedMultiDictionary<decimal, Product>(true);
                dict.Add(product.Price, product);

                this.productsByTitlePrice.Add(
                    product.Title,dict);
            }
            else
            {
                this.productsByTitlePrice[product.Title].Add(product.Price,product);
            }

            if (!this.productsBySupplierPrice.ContainsKey(product.Supplier))
            {
                var dict = new OrderedMultiDictionary<decimal, Product>(true);
                dict.Add(product.Price, product);

                this.productsBySupplierPrice.Add(
                    product.Supplier, dict);
            }
            else
            {
                this.productsBySupplierPrice[product.Supplier].Add(product.Price, product);
            }

            this.Count++;
        }

        public bool Remove(int id)
        {
            Product product;
            bool exists = this.productsById.TryGetValue(id, out product);

            if (!exists)
            {
                return false;
            }

            this.productsById.Remove(id);
            this.productsByPrice[product.Price].Remove(product);
            this.productsByTitle[product.Title].Remove(product);
            this.productsByTitlePrice[product.Title][product.Price].Remove(product);
            this.productsBySupplierPrice[product.Supplier][product.Price].Remove(product);

            this.Count--;
            return true;
        }

        public Product Find(int id)
        {
            Product product;
            bool result = this.productsById.TryGetValue(id, out product);

            return product;
        }

        public IEnumerable<Product> FindByTitle(string title)
        {
            SortedSet<Product> output;
            bool result = this.productsByTitle.TryGetValue(title, out output);

            return output;
        }

        public IEnumerable<Product> FindByTitleAndPrice(string title, decimal price)
        {
            OrderedMultiDictionary<decimal,Product> output;
            bool result = this.productsByTitlePrice.TryGetValue(title, out output);

            if (output != null)
            {
                IEnumerable<Product> toReturn = output.ContainsKey(price) ? output[price] : Enumerable.Empty<Product>(); 
                return toReturn;
            }
            else
            {
                return Enumerable.Empty<Product>();
            }
        }

        public IEnumerable<Product> FindByTitleAndPriceRange(string supplier, decimal pricemin, decimal pricemax)
        {
            OrderedMultiDictionary<decimal, Product> output;
            bool result = this.productsByTitlePrice.TryGetValue(supplier, out output);

            if (output != null)
            {
                return output.Range(pricemin, true, pricemax, true).Values;
            }
            else
            {
                return Enumerable.Empty<Product>();
            }
        }

        public IEnumerable<Product> FindBySupplierAndPrice(string supplier, decimal price)
        {
            OrderedMultiDictionary<decimal, Product> output;
            bool result = this.productsBySupplierPrice.TryGetValue(supplier, out output);

            if (output != null)
            {
                IEnumerable<Product> toReturn = output.ContainsKey(price) ? output[price] : Enumerable.Empty<Product>();
                return toReturn;
            }
            else
            {
                return Enumerable.Empty<Product>();
            }
        }

        public IEnumerable<Product> FindBySupplierAndPriceRange(string supplier, decimal pricemin, decimal pricemax)
        {
            OrderedMultiDictionary<decimal, Product> output;
            bool result = this.productsBySupplierPrice.TryGetValue(supplier, out output);

            if (output != null)
            {
                return output.Range(pricemin,true,pricemax,true).Values;
            }
            else
            {
                return Enumerable.Empty<Product>();
            }
        }
    }
}