using CodingProblems;
using FluentAssertions;
using Xunit;

namespace CodingProblemsTests
{
    public class RemovingIslandsProblemTests
    {
        [Fact]
        public void RemoveIslands_Example1()
        {
            RemovingIslandsProblem removingIslandsProblem = new();
            removingIslandsProblem.RemoveIslands(null)
                .Should()
                .BeNull();
        }

        [Fact]
        public void RemoveIslands_Example2()
        {
            RemovingIslandsProblem removingIslandsProblem = new();

            int[][] matrix = new int[][]
            {
                new int[] { 1, 0, 1, 0, 0, 1 },
                new int[] { 1, 0, 0, 0, 1, 1 },
                new int[] { 1, 0, 1, 0, 0, 1 },
                new int[] { 0, 0, 1, 0, 0, 1 },
                new int[] { 0, 0, 0, 1, 0, 1 },
                new int[] { 1, 1, 1, 0, 0, 1 }
            };

            int[][] expectedResult = new int[][]
            {
                new int[] { 1, 0, 1, 0, 0, 1 },
                new int[] { 1, 0, 0, 0, 1, 1 },
                new int[] { 1, 0, 0, 0, 0, 1 },
                new int[] { 0, 0, 0, 0, 0, 1 },
                new int[] { 0, 0, 0, 0, 0, 1 },
                new int[] { 1, 1, 1, 0, 0, 1 }
            };

            int[][] result = removingIslandsProblem.RemoveIslands(matrix);
            result.Should().BeEquivalentTo(expectedResult, options => options.WithStrictOrdering());
        }

        [Fact]
        public void RemoveIslands_Example3()
        {
            RemovingIslandsProblem removingIslandsProblem = new();

            int[][] matrix = new int[][]
            {
                new int[] { 1, 0, 1, 0, 0, 1 },
                new int[] { 0, 0, 0, 0, 1, 1 },
                new int[] { 0, 0, 1, 0, 0, 1 },
                new int[] { 0, 1, 1, 0, 0, 1 },
                new int[] { 0, 0, 0, 1, 0, 1 },
                new int[] { 1, 1, 1, 0, 0, 1 }
            };

            int[][] expectedResult = new int[][]
            {
                new int[] { 1, 0, 1, 0, 0, 1 },
                new int[] { 0, 0, 0, 0, 1, 1 },
                new int[] { 0, 0, 0, 0, 0, 1 },
                new int[] { 0, 0, 0, 0, 0, 1 },
                new int[] { 0, 0, 0, 0, 0, 1 },
                new int[] { 1, 1, 1, 0, 0, 1 }
            };

            int[][] result = removingIslandsProblem.RemoveIslands(matrix);
            result.Should().BeEquivalentTo(expectedResult, options => options.WithStrictOrdering());
        }

        [Fact]
        public void RemoveIslands_Example4()
        {
            RemovingIslandsProblem removingIslandsProblem = new();

            int[][] matrix = new int[][]
            {
                new int[] { 1, 0, 1, 0, 0, 1 },
                new int[] { 0, 0, 0, 0, 1, 1 },
                new int[] { 0, 0, 1, 0, 0, 1 },
                new int[] { 1, 1, 1, 0, 0, 1 },
                new int[] { 0, 0, 0, 1, 0, 1 },
                new int[] { 1, 1, 1, 0, 0, 1 }
            };

            int[][] expectedResult = new int[][]
            {
                new int[] { 1, 0, 1, 0, 0, 1 },
                new int[] { 0, 0, 0, 0, 1, 1 },
                new int[] { 0, 0, 1, 0, 0, 1 },
                new int[] { 1, 1, 1, 0, 0, 1 },
                new int[] { 0, 0, 0, 0, 0, 1 },
                new int[] { 1, 1, 1, 0, 0, 1 }
            };

            int[][] result = removingIslandsProblem.RemoveIslands(matrix);
            result.Should().BeEquivalentTo(expectedResult, options => options.WithStrictOrdering());
        }
    }
}