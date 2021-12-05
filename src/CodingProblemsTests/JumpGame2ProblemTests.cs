using Xunit;
using FluentAssertions;
using CodingProblems;

namespace CodingProblemsTests
{
    public class JumpGame2ProblemTests
    {
        [Fact]
        public void Jump_Example1()
        {
            JumpGame2Problem problem = new();
            problem
                .Jump(new int[] { 2, 3, 1, 1, 4 })
                .Should().Be(2);
        }

        [Fact]
        public void Jump_Example2()
        {
            JumpGame2Problem problem = new();
            problem
                .Jump(new int[] { 2, 3, 0, 1, 4 })
                .Should().Be(2);
        }

        [Fact]
        public void Jump_Example3()
        {
            JumpGame2Problem problem = new();
            problem
                .Jump(new int[] { 2, 1, 2, 3, 2, 2, 0, 9 })
                .Should().Be(4);
        }
    }
}