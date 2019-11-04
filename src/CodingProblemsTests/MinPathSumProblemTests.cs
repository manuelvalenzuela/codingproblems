using CodingProblems;
using Xunit;

namespace CodingProblemsTests
{
    public class MinPathSumProblemTests
    {

        [Fact]
        public void MinPathSum_BasicTest()
        {
            var minPathSum = new MinPathSumProblem();
            var area = new[]
            {
                new []{0}
            };
            Assert.Equal(0, minPathSum.MinPathSum(area));
        }

        [Fact]
        public void MinPathSum_FirstExampple()
        {
            var minPathSum = new MinPathSumProblem();
            var area = new[]
            {
                new []{1,3,1},
                new []{1,5,1},
                new []{4,2,1}
            };
            Assert.Equal(7, minPathSum.MinPathSum(area));
        }
    }
}