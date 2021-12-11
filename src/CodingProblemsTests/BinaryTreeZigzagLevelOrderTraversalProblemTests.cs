using CodingProblems;
using FluentAssertions;
using Xunit;

namespace CodingProblemsTests
{
    public class BinaryTreeZigzagLevelOrderTraversalProblemTests
    {
        [Fact]
        public void ZigzagLevelOrder_Example1()
        {
            BinaryTreeZigzagLevelOrderTraversalProblem binaryTreeZigzagLevelOrderTraversalProblem = new();
            var result = binaryTreeZigzagLevelOrderTraversalProblem.ZigzagLevelOrder(new(1, new(2, new(4), new(5)), new(3, new(6), new(7))));

            result[0][0].Should().Be(1);
            result[1][0].Should().Be(3);
            result[1][1].Should().Be(2);
            result[2][0].Should().Be(4);
            result[2][1].Should().Be(5);
            result[2][2].Should().Be(6);
            result[2][3].Should().Be(7);
        }
    }
}