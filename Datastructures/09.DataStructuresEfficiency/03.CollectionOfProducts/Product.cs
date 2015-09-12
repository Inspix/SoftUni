namespace _03.CollectionOfProducts
{
    using System;

    public class Product : IComparable<Product>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Supplier { get; set; }
        public decimal Price { get; set; }

        public int CompareTo(Product other)
        {
            return this.Id.CompareTo(other.Id);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode() ^ Title.GetHashCode() ^ Supplier.GetHashCode() << 4 ^ Price.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("ID: {0,-15}|Title: {1,-15}|Supplier: {2,-15}|Price: {3}", this.Id, this.Title, this.Supplier, this.Price);
        }
    }
}