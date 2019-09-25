using FilterLibrary.Interface;
using FilterLibrary.Specification.Multiple;
using FilterLibraryCore.UnitTest.SpecificationImplementation;
using NUnit.Framework;

namespace FilterLibraryCore.UnitTest
{
    [TestFixture]
    public class SpecificationAndTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(10)]
        [TestCase(100)]
        [TestCase(1000)]
        public void TestConstructorWithEnum(int nbrParam)
        {
            ISpecification<int>[] spectab = new ISpecification<int>[nbrParam];
            for (int i = 0; i < spectab.Length; i++)
            {
                spectab[i] = new IsZero();
            }
            SpecificationAnd<int> spec = new SpecificationAnd<int>(spectab);
        }
    }
}