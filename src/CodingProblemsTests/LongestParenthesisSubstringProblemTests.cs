using CodingProblems;
using FluentAssertions;
using Xunit;

namespace CodingProblemsTests
{
    public class LongestParenthesisSubstringProblemTests
    {
        [Fact]
        public void LongestParenthesisSubstring_Example1()
        {
            LongestParenthesisSubstringProblem longestParenthesisSubstringProblem = new();
            longestParenthesisSubstringProblem.LongestParenthesisSubstring("(()")
                .Should()
                .Be(2);
        }

        [Fact]
        public void LongestParenthesisSubstring_Example2()
        {
            LongestParenthesisSubstringProblem longestParenthesisSubstringProblem = new();
            longestParenthesisSubstringProblem.LongestParenthesisSubstring(")()())")
                .Should()
                .Be(4);
        }

        [Fact]
        public void LongestParenthesisSubstring_Example3()
        {
            LongestParenthesisSubstringProblem longestParenthesisSubstringProblem = new();
            longestParenthesisSubstringProblem.LongestParenthesisSubstring("()(()))))")
                .Should()
                .Be(6);
        }

        [Fact]
        public void LongestParenthesisSubstring_Example4()
        {
            LongestParenthesisSubstringProblem longestParenthesisSubstringProblem = new();
            longestParenthesisSubstringProblem.LongestParenthesisSubstring("(((()()))()")
                .Should()
                .Be(10);
        }

        [Fact]
        public void LongestParenthesisSubstring_Example5()
        {
            LongestParenthesisSubstringProblem longestParenthesisSubstringProblem = new();
            longestParenthesisSubstringProblem.LongestParenthesisSubstring(")()(())))))(((()()))())(")
                .Should()
                .Be(12);
        }

        [Fact]
        public void LongestParenthesisSubstring_Example6()
        {
            LongestParenthesisSubstringProblem longestParenthesisSubstringProblem = new();
            longestParenthesisSubstringProblem.LongestParenthesisSubstring(")()())()()((()()())()))((()")
                .Should()
                .Be(16);
        }

        [Fact]
        public void LongestParenthesisSubstring_Example7()
        {
            LongestParenthesisSubstringProblem longestParenthesisSubstringProblem = new();
            longestParenthesisSubstringProblem.LongestParenthesisSubstring("())")
                .Should()
                .Be(2);
        }
    }
}