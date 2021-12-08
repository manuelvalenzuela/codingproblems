using CodingProblems;
using FluentAssertions;
using Xunit;

namespace CodingProblemsTests
{
    public class ShuffleStringProblemTests
    {
        [Fact]
        public void RestoreString_Example1()
        {
            ShuffleStringProblem shuffleStringProblem = new();
            shuffleStringProblem
                .RestoreString("codeleet", new int[] { 4, 5, 6, 7, 0, 2, 1, 3 })
                .Should()
                .Be("leetcode");
        }
    }
}