
namespace Filter
{
    /// <summary>
    /// interface to implement for new specification
    /// </summary>
    /// <typeparam name="T">The class used to apply filter on</typeparam>
    public interface ISpecification<T>
    {
        /// <summary>
        /// Method that determine if the item satisfy the specification
        /// </summary>
        /// <param name="item"></param>
        /// <returns>True if the item satisfy the specification</returns>
        bool IsSatisfied(T item);
    }
}
