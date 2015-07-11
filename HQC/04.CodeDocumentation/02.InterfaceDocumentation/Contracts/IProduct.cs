namespace Cosmetics.Contracts
{
    using Common;

    public interface IProduct
    {
        /// <summary>
        /// Gets the <see cref="IProduct"/> Name.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets the <see cref="IProduct"/> Brand.
        /// </summary>
        string Brand { get; }

        /// <summary>
        /// Gets the <see cref="IProduct"/> Price.
        /// </summary>
        decimal Price { get; }

        /// <summary>
        /// Gets the <see cref="IProduct"/> Gender. See <seealso cref="GenderType"/> enumeration.
        /// </summary>
        GenderType Gender { get; }

        /// <summary>
        /// Method that creates the <see cref="IProduct"/> info as a string.
        /// </summary>
        /// <returns>Returns the result string.</returns>
        string Print();
    }
}
