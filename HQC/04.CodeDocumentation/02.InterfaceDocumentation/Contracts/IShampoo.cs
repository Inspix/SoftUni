namespace Cosmetics.Contracts
{
    using Common;

    public interface IShampoo : IProduct
    {
        /// <summary>
        /// Gets the milliliters of the <see cref="IShampoo"/>.
        /// </summary>
        uint Milliliters { get; }

        /// <summary>
        /// Gets the <see cref="UsageType"/> of the <see cref="IShampoo"/>.
        /// </summary>
        UsageType Usage { get; }
    }
}
