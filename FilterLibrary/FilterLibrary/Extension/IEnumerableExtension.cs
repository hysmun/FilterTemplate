using System.Collections.Generic;
using System.Linq;
using FilterLibrary.Interface;

namespace FilterLibrary.Extension
{
    public static class IEnumerableExtension
    {
        public static IEnumerable<T> Filter<T>(this IEnumerable<T> list, ISpecification<T> spec)
        {
            return list.Where(x => spec.IsSatisfied(x));
        }
    }
}
