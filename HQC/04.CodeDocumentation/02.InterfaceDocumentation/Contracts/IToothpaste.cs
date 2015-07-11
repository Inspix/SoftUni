namespace Cosmetics.Contracts
{
    public interface IToothpaste : IProduct
    {
        /// <summary>
        /// Gets the ingredients string of the <see cref="IToothpaste"/>.
        /// </summary>
        string Ingredients { get; }
    }
}
