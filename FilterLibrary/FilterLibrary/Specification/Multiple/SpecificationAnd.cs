using System.Collections.Generic;
using System.Linq;
using FilterLibrary.Interface;

namespace FilterLibrary.Specification.Multiple
{
    /// <summary>
    /// Class used to merge specifications with a AND operator between them
    /// </summary>
    /// <typeparam name="T">The class used to apply filter on</typeparam>
    public class SpecificationAnd<T>: SpecificationMultipleBase<T>
    {
        /// <summary>
        /// Method that determine if the item satisfy all the specification
        /// </summary>
        /// <param name="item"></param>
        /// <returns>True if the item satisfy all the specification</returns>
        public override bool IsSatisfied(T item)
        {
            return _specifications.All(x => x.IsSatisfied(item));
        }

        public SpecificationAnd(ISpecification<T> spec1, ISpecification<T> spec2, params ISpecification<T>[] specifications ) : base(spec1, spec2, specifications)
        {
        }

        public SpecificationAnd(IEnumerable<ISpecification<T>> specification) : base(specification)
        {
        }
    }
}