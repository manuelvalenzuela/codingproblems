using CodingProblems;
using FluentAssertions;
using Xunit;

namespace CodingProblemsTests
{
    public class TopKFrequentProblemTests
    {
        [Fact]
        public void TopKFrequent_Example1()
        {
            TopKFrequentProblem topKFrequentProblem = new();
            topKFrequentProblem
                .TopKFrequent(new int[] { 1, 1, 1, 2, 2, 3 }, 2)
                .Should()
                .BeEquivalentTo(new int[] { 1, 2 });
        }

        [Fact]
        public void TopKFrequent_Example2()
        {
            TopKFrequentProblem topKFrequentProblem = new();
            topKFrequentProblem
                .TopKFrequent(new int[] { 1 }, 1)
                .Should()
                .BeEquivalentTo(new int[] { 1 });
        }
    }
}