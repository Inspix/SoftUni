namespace Cosmetics.Contracts
{
    using System.Collections.Generic;

    interface ICommand
    {
        /// <summary>
        /// Gets the command name.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets the <see cref="IList{T}"/> with command parameters.
        /// </summary>
        IList<string> Parameters { get; }
    }
}
