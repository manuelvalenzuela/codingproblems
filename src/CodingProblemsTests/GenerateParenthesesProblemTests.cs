using CodingProblems;
using FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace CodingProblemsTests
{
    public class GenerateParenthesesProblemTests
    {
        [Fact]
        public void GenerateParenthesis_Example1()
        {
            GenerateParenthesesProblem generateParenthesesProblem = new();
            generateParenthesesProblem.GenerateParenthesis(3)
                .Should()
                .BeEquivalentTo(new List<string> { "((()))", "(()())", "(())()", "()(())", "()()()" });
        }
    }
}