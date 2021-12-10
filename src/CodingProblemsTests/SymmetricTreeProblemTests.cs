using CodingProblems;
using FluentAssertions;
using Xunit;
using static CodingProblems.SymmetricTreeProblem;

namespace CodingProblemsTests
{
    public class SymmetricTreeProblemTests
    {
        [Fact]
        public void IsSymmetric_Example1()
        {
            SymmetricTreeProblem symmetricTreeProblem = new();
            symmetricTreeProblem.IsSymmetric(new TreeNode(1, new TreeNode(2, new TreeNode(3), new TreeNode(4)), new TreeNode(2, new TreeNode(4), new TreeNode(3))))
                .Should()
                .BeTrue();
        }

        [Fact]
        public void IsSymmetric_Example2()
        {
            SymmetricTreeProblem symmetricTreeProblem = new();
            symmetricTreeProblem.IsSymmetric(new TreeNode(2, new TreeNode(3, new TreeNode(4), new TreeNode(5)), new TreeNode(3, new TreeNode(5), null)))
                .Should()
                .BeFalse();
        }
    }
}