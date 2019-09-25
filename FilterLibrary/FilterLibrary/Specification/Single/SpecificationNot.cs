using FilterLibrary.Interface;

namespace FilterLibrary.Specification.Single
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SpecificationNot<T> : SpecificationSingleBase<T>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public override bool IsSatisfied(T item)
        {
            return !_specification.IsSatisfied(item);
        }

        public SpecificationNot(ISpecification<T> specification) : base(specification)
        {
        }
    }
}
