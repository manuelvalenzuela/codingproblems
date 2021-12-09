using CodingProblems;
using FluentAssertions;
using Xunit;

namespace CodingProblemsTests
{
    public class ContainerWithMostWaterProblemTests
    {
        [Fact]
        public void MaxArea_Example1()
        {
            ContainerWithMostWaterProblem containerWithMostWaterProblem = new();
            containerWithMostWaterProblem.MaxArea(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 })
                .Should()
                .Be(49);
        }

        [Fact]
        public void MaxArea_Example2()
        {
            ContainerWithMostWaterProblem containerWithMostWaterProblem = new();
            containerWithMostWaterProblem.MaxArea(new int[] { 1, 1 })
                .Should()
                .Be(1);
        }

        [Fact]
        public void MaxArea_Example3()
        {
            ContainerWithMostWaterProblem containerWithMostWaterProblem = new();
            containerWithMostWaterProblem.MaxArea(new int[] { 4, 3, 2, 1, 4 })
                .Should()
                .Be(16);
        }

        [Fact]
        public void MaxArea_Example4()
        {
            ContainerWithMostWaterProblem containerWithMostWaterProblem = new();
            containerWithMostWaterProblem.MaxArea(new int[] { 1, 2, 1 })
                .Should()
                .Be(2);
        }
    }
}