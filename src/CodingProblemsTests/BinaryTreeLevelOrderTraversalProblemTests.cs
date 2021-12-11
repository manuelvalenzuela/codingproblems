using CodingProblems;
using FluentAssertions;
using System.Collections.Generic;
using Xunit;
using static CodingProblems.BinaryTreeLevelOrderTraversalProblem;

namespace CodingProblemsTests
{
    public class BinaryTreeLevelOrderTraversalProblemTests
    {
        [Fact]
        public void LevelOrder_Example1()
        {
            BinaryTreeLevelOrderTraversalProblem binaryTreeLevelOrderTraversalProblem = new ();
            binaryTreeLevelOrderTraversalProblem.LevelOrder(new(3, new(9), new(20,new(15),new(7))))
                .Should()
                .BeEquivalentTo(new List<List<int>>
                {
                    new List<int> { 3 },
                    new List<int> { 9, 20 },
                    new List<int> { 15, 7 }
                });
        }
    }
}