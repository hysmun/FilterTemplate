using System;
using System.Collections.Generic;
using System.Text;
using FilterLibrary.Interface;

namespace FilterLibrary.Specification.Single
{
    public abstract class SpecificationSingleBase<T> : ISpecification<T>
    {/// <summary>
        /// 
        /// </summary>
        protected readonly ISpecification<T> _specification;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="specification"></param>
        public SpecificationSingleBase(ISpecification<T> specification)
        {
            this._specification = specification;
        }

        public abstract bool IsSatisfied(T item);
    }
}
