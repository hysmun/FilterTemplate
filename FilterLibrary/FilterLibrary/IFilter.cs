using System.Collections.Generic;

namespace Filter
{
    /// <summary>
    /// interface to implement for filter class
    /// </summary>
    /// <typeparam name="T">The class used to apply filter on</typeparam>
    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> list, ISpecification<T> specification);
    }

    /// <summary>
    /// interface to implement for filter class
    /// </summary>
    /// <typeparam name="T">The class used to apply filter on</typeparam>
    public interface IFilterAnd<T>
    {
        IEnumerable<T> FiltersAnd(IEnumerable<T> list, List<ISpecification<T>> specifications);
        IEnumerable<T> FiltersAnd(IEnumerable<T> list, params  ISpecification<T>[] specifications);
    }

    /// <summary>
    /// interface to implement for filter class
    /// </summary>
    /// <typeparam name="T">The class used to apply filter on</typeparam>
    public interface IFilterOr<T>
    {
        IEnumerable<T> FiltersOr(IEnumerable<T> list, List<ISpecification<T>> specifications);
        IEnumerable<T> FiltersOr(IEnumerable<T> list, params  ISpecification<T>[] specifications);
    }
}
