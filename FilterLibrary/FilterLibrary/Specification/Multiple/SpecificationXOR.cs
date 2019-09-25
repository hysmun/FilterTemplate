using System.Collections.Generic;
using System.Linq;
using FilterLibrary.Interface;

namespace FilterLibrary.Specification.Multiple
{
    public class SpecificationXOR<T> : SpecificationMultipleBase<T>
    {

        public override bool IsSatisfied(T item)
        {
            return _specifications.Where(x => x.IsSatisfied(item)).Count() == 1;
        }

        public SpecificationXOR(ISpecification<T> spec1, ISpecification<T> spec2, ISpecification<T>[] specifications) : base(spec1, spec2, specifications)
        {
        }

        public SpecificationXOR(IEnumerable<ISpecification<T>> specification) : base(specification)
        {
        }
    }
}
