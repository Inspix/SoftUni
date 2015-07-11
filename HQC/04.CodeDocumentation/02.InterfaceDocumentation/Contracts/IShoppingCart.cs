namespace Cosmetics.Contracts
{
    public interface IShoppingCart
    {
        /// <summary>
        /// Method to add a product to a <see cref="IShoppingCart"/>.
        /// </summary>
        /// <param name="product"><see cref="IProduct"/> to add.</param>
        void AddProduct(IProduct product);

        /// <summary>
        /// Method to remove a product from a <see cref="IShoppingCart"/>.
        /// </summary>
        /// <param name="product"><see cref="IProduct"/> to remove.</param>
        void RemoveProduct(IProduct product);

        /// <summary>
        /// Checks if a given <see cref="IProduct"/> is in the <see cref="IShoppingCart"/>.
        /// </summary>
        /// <param name="product">The <see cref="IProduct"/> to check for.</param>
        /// <returns>If the product is in the <see cref="IShoppingCart"/></returns>
        bool ContainsProduct(IProduct product);

        /// <summary>
        /// Calculates the total price of the <see cref="IShoppingCart"/>.
        /// </summary>
        /// <returns>The result of the calculation.</returns>
        decimal TotalPrice();
    }
}
