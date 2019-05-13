using System.Collections.Generic;
using System.Linq;

namespace Filter
{
    /// <summary>
    /// Class used to merge specifications with a OR operator between them
    /// </summary>
    /// <typeparam name="T">The class used to apply filter on</typeparam>
    public class SpecificationOr<T>: ISpecification<T>
    {
        private readonly ISpecification<T>[] _specification;

        /// <summary>
        /// Construct a specification with a set of specification
        /// </summary>
        /// <param name="specification"></param>
        public SpecificationOr(ISpecification<T>[] specification)
        {
            _specification = specification;
        }

        /// <summary>
        /// Construct a specification with a list of specification
        /// </summary>
        /// <param name="specification"></param>
        public SpecificationOr(List<ISpecification<T>> specification)
        {
            _specification = specification.ToArray();
        }

        /// <summary>
        /// Method that determine if the item satisfy one of the specification
        /// </summary>
        /// <param name="item"></param>
        /// <returns>True if the item satisfy one of the specification</returns>
        public bool IsSatisfied(T item)
        {
            return _specification.Any(x => x.IsSatisfied(item));
        }
    }
}