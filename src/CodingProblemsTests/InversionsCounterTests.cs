using CodingProblems;
using Xunit;

namespace CodingProblemsTests
{
    public class InversionsCounterTests
    {
        [Fact]
        public void InversionCount_SimpleExample()
        {
            var sorter = new InversionsCounter();
            var a = new[] { 1,3,5,2,4,6 };

            Assert.Equal(3, sorter.CountSplitInversions(a));
        }

        [Fact]
        public void InversionCount_ReversedSixNumbers()
        {
            var sorter = new InversionsCounter();
            var a = new[] { 6,5,4,3,2,1 };

            Assert.Equal(15, sorter.CountSplitInversions(a));
        }
    }
}
