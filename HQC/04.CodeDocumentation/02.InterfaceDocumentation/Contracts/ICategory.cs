namespace Cosmetics.Contracts
{
    public interface ICategory
    {
        /// <summary>
        /// Gets the name of the category
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Method to add cosmetics to the category.
        /// </summary>
        /// <param name="cosmetics"><see cref="IProduct"/> cosmetic item to add.</param>
        void AddCosmetics(IProduct cosmetics);

        /// <summary>
        /// Method to remove cosmetics to the category.
        /// </summary>
        /// <param name="cosmetics"><see cref="IProduct"/> cosmetic item to remove.</param>
        void RemoveCosmetics(IProduct cosmetics);

        /// <summary>
        /// Method to return the category info.
        /// </summary>
        /// <returns>Returns the string representation of the category.</returns>
        string Print();
    }
}
