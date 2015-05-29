using System.Collections.Generic;

namespace EZMetrology.Collections.Generic
{
    /// <summary>
    /// Allows the adding or removing of a collection of items as a single operation.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IBulkCollection<T>
    {
        /// <summary>
        /// Adds a range of items to the collection.
        /// </summary>
        /// <param name="items"></param>
        void AddRange(IEnumerable<T> items);

        /// <summary>
        /// Removes a range of items to the collection.
        /// </summary>
        /// <param name="items"></param>
        void RemoveRange(IEnumerable<T> items);
    }
}
