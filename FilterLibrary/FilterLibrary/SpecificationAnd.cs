using System.Collections.Generic;
using System.Linq;

namespace Filter
{
    /// <summary>
    /// Class used to merge specifications with a AND operator between them
    /// </summary>
    /// <typeparam name="T">The class used to apply filter on</typeparam>
    public class SpecificationAnd<T>: ISpecification<T>
    {
        private readonly ISpecification<T>[] _specification;

        /// <summary>
        /// Construct a specification with a set of specification
        /// </summary>
        /// <param name="specification"></param>
        public SpecificationAnd(params ISpecification<T>[] specification)
        {
            _specification = specification;
        }

        /// <summary>
        /// Construct a specification with a list of specification
        /// </summary>
        /// <param name="specification"></param>
        public SpecificationAnd(List<ISpecification<T>> specification)
        {
            _specification = specification.ToArray();
        }

        /// <summary>
        /// Method that determine if the item satisfy all the specification
        /// </summary>
        /// <param name="item"></param>
        /// <returns>True if the item satisfy all the specification</returns>
        public bool IsSatisfied(T item)
        {
            return _specification.All(x => x.IsSatisfied(item));
        }
    }
}