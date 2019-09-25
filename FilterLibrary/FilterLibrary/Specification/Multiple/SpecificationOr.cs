using System.Collections.Generic;
using System.Linq;
using FilterLibrary.Interface;

namespace FilterLibrary.Specification.Multiple
{
    /// <summary>
    /// Class used to merge specifications with a OR operator between them
    /// </summary>
    /// <typeparam name="T">The class used to apply filter on</typeparam>
    public class SpecificationOr<T>: SpecificationMultipleBase<T>
    {
        /// <summary>
        /// Method that determine if the item satisfy one of the specification
        /// </summary>
        /// <param name="item"></param>
        /// <returns>True if the item satisfy one of the specification</returns>
        public override bool IsSatisfied(T item)
        {
            return _specifications.Any(x => x.IsSatisfied(item));
        }

        public SpecificationOr(ISpecification<T> spec1, ISpecification<T> spec2, ISpecification<T>[] specifications) : base(spec1, spec2, specifications)
        {
        }

        public SpecificationOr(IEnumerable<ISpecification<T>> specification) : base(specification)
        {
        }
    }
}