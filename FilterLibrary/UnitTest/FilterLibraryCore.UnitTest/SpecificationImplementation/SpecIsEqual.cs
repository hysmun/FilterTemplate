using System;
using System.Collections.Generic;
using System.Text;
using FilterLibrary.Interface;

namespace FilterLibraryCore.UnitTest.SpecificationImplementation
{
    public class IsZero : ISpecification<int>
    {
        public bool IsSatisfied(int item)
        {
            return item == 0;
        }
    }
}
