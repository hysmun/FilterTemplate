using System;
using System.Collections.Generic;
using System.Linq;
using FilterLibrary.Interface;

namespace FilterLibrary.Specification.Multiple
{
    public abstract class SpecificationMultipleBase<T> : ISpecification<T>
    {
        protected readonly ISpecification<T>[] _specifications;

        /// <summary>
        /// Construct a specification with a set of specification
        /// </summary>
        /// <param name="specifications"></param>
        public SpecificationMultipleBase(ISpecification<T> spec1, ISpecification<T> spec2, ISpecification<T>[] specifications) 
        {
            _specifications = new ISpecification<T>[2+specifications.Length];
            _specifications[0] = spec1;
            _specifications[1] = spec2;
            for (var index = 0; index < specifications.Length; index++)
            {
                _specifications[index + 2] = specifications[index];
            }
        }

        /// <summary>
        /// Construct a specification with a list of specification
        /// </summary>
        /// <param name="specification"></param>
        public SpecificationMultipleBase(IEnumerable<ISpecification<T>> specification)
        {
            if (specification.Count() < 2)
            {
                throw new ArgumentOutOfRangeException(nameof(specification));
            }
            _specifications = specification.ToArray();
        }

        public abstract bool IsSatisfied(T item);
    }
}
