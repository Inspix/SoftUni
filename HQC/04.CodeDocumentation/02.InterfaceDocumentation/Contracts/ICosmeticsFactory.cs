namespace Cosmetics.Contracts
{
    using System.Collections.Generic;
    using Common;

    public interface ICosmeticsFactory
    {
        /// <summary>
        /// Method for Category object creation.
        /// </summary>
        /// <param name="name">The name of the category.</param>
        /// <returns>New instance of a <see cref="ICategory"/> object.</returns>
        ICategory CreateCategory(string name);

        /// <summary>
        /// Method for Shampoo object creation.
        /// </summary>
        /// <param name="name">Name.</param>
        /// <param name="brand">Brand.</param>
        /// <param name="price">Price.</param>
        /// <param name="gender"><see cref="GenderType"/>.</param>
        /// <param name="milliliters">Quantity in milliliters.</param>
        /// <param name="usage">Usage Type.</param>
        /// <returns>New instance of a <see cref="IShampoo"/> object.</returns>
        IShampoo CreateShampoo(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usage);

        /// <summary>
        /// Method for Toothpaste object creation.
        /// </summary>
        /// <param name="name">Name.</param>
        /// <param name="brand">Brand.</param>
        /// <param name="price">Price.</param>
        /// <param name="gender"><see cref="GenderType"/>.</param>
        /// <param name="ingredients"><see cref="IList{T}"/> with ingredients</param>
        /// <returns>New instance of a <see cref="IToothpaste"/> object.</returns>
        IToothpaste CreateToothpaste(string name, string brand, decimal price, GenderType gender, IList<string> ingredients);

        /// <summary>
        /// Method for Shopping Cart object creation.
        /// </summary>
        /// <returns>New instance of a <see cref="IShoppingCart"/> object.</returns>
        IShoppingCart ShoppingCart();
    }
}
