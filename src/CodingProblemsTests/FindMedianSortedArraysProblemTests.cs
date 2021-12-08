using CodingProblems;
using FluentAssertions;
using Xunit;

namespace CodingProblemsTests
{
    public class FindMedianSortedArraysProblemTests
    {
        [Fact]
        public void FindMedianSortedArrays_Example1()
        {
            FindMedianSortedArraysProblem problem = new();
            problem.FindMedianSortedArrays_Brutforce(new int[] { 1, 3 }, new int[] { 2 }).Should().Be(2.0);
        }

        [Fact]
        public void FindMedianSortedArrays_Example2()
        {
            FindMedianSortedArraysProblem problem = new();
            problem.FindMedianSortedArrays_Brutforce(new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 2, 3, 4 }).Should().Be(2.0);
        }

        [Fact]
        public void FindMedianSortedArrays_Example3()
        {
            FindMedianSortedArraysProblem problem = new();
            problem.FindMedianSortedArrays_Brutforce(new int[] { 1, 2 }, new int[] { 1, 2 }).Should().Be(1.5);
        }

        [Fact]
        public void FindMedianSortedArrays_Example4()
        {
            FindMedianSortedArraysProblem problem = new();
            problem.FindMedianSortedArrays_Brutforce(new int[] { 1, 3, 4, 5, 6, 7, 8 }, new int[] { 1, 2 }).Should().Be(4.0);
        }
    }
}