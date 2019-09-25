using System.Collections.Generic;
using System.Linq;
using FilterLibrary.Interface;

namespace FilterLibrary
{
    /// <summary>
    /// base class for filter function on list
    /// </summary>
    /// <typeparam name="T">The class used to apply filter on</typeparam>
    public class BaseFilter<T> : IFilter<T>, IFilterAnd<T>, IFilterOr<T>
    {
        /// <summary>
        /// Filter the list based on the specification
        /// </summary>
        /// <param name="list">The list to filter</param>
        /// <param name="specification">The specification to use</param>
        /// <returns>a sub list with item that satisfy the specification</returns>
        public IEnumerable<T> Filter(IEnumerable<T> list, ISpecification<T> specification)
        {
            return list.Where( x => specification.IsSatisfied(x));
        }

        /// <summary>
        /// Filter the list that satisfy all specification
        /// </summary>
        /// <param name="list">The list to filter</param>
        /// <param name="specifications">The specification to use</param>
        /// <returns>a sub list with item that satisfy all the specification</returns>
        public IEnumerable<T> FiltersAnd(IEnumerable<T> list, IEnumerable<ISpecification<T>> specifications)
        {
            foreach (T item in list)
            {
                if (specifications.All(x => x.IsSatisfied(item)))
                {
                    yield return item;
                }
            }
        }

        /// <summary>
        /// Filter the list that satisfy all specification
        /// </summary>
        /// <param name="list">The list to filter</param>
        /// <param name="specifications">The specification to use</param>
        /// <returns>a sub list with item that satisfy all the specification</returns>
        public IEnumerable<T> FiltersAnd(IEnumerable<T> list, params ISpecification<T>[] specifications)
        {
            IEnumerable<ISpecification<T>> lSpecifications = specifications;
            
            return FiltersAnd(list, lSpecifications);
        }

        /// <summary>
        /// Filter the list that satisfy one specification
        /// </summary>
        /// <param name="list">The list to filter</param>
        /// <param name="specifications">The specification to use</param>
        /// <returns>a sub list with item that satisfy one of the specification</returns>
        public IEnumerable<T> FiltersOr(IEnumerable<T> list, IEnumerable<ISpecification<T>> specifications)
        {
            foreach (T item in list)
            {
                if (specifications.Any(x => x.IsSatisfied(item)))
                {
                    yield return item;
                }
            }
        }

        /// <summary>
        /// Filter the list that satisfy one specification
        /// </summary>
        /// <param name="list">The list to filter</param>
        /// <param name="specifications">The specification to use</param>
        /// <returns>a sub list with item that satisfy one of the specification</returns>
        public IEnumerable<T> FiltersOr(IEnumerable<T> list, params ISpecification<T>[] specifications)
        {
            IEnumerable<ISpecification<T>> lSpecifications = specifications;
            
            return FiltersOr(list, lSpecifications);
        }
    }
}