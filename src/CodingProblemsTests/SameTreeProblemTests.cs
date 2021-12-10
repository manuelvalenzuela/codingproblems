using CodingProblems;
using FluentAssertions;
using Xunit;
using static CodingProblems.SameTreeProblem;

namespace CodingProblemsTests
{
    public class SameTreeProblemTests
    {
        [Fact]
        public void IsSameTree_Example1()
        {
            SameTreeProblem sut = new();
            TreeNode p = new (1, new (2), new (3));
            TreeNode q = new (1, new (2), new (3));
            sut.IsSameTree(p, q)
                .Should()
                .BeTrue();
        }

        [Fact]
        public void IsSameTree_Example2()
        {
            SameTreeProblem sut = new();
            TreeNode p = new (1, new (2));
            TreeNode q = new (1, null, new (2));
            sut.IsSameTree(p, q)
                .Should()
                .BeFalse();
        }

        [Fact]
        public void IsSameTree_Example3()
        {
            SameTreeProblem sut = new();
            TreeNode p = new (1, new (2), new (1));
            TreeNode q = new (1, new (1), new (2));
            sut.IsSameTree(p, q)
                .Should()
                .BeFalse();
        }
    }
}