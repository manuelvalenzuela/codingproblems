using CodingProblems;
using FluentAssertions;
using Xunit;

namespace CodingProblemsTests
{
    public class LengthOfLongestSubstringProblemTests
    {
        [Fact]
        public void LengthOfLongestSubstring_Example1()
        {
            LengthOfLongestSubstringProblem problem = new();

            problem.LengthOfLongestSubstring("abcabcbb").Should().Be(3);
        }

        [Fact]
        public void LengthOfLongestSubstring_Example2()
        {
            LengthOfLongestSubstringProblem problem = new();

            problem.LengthOfLongestSubstring("bbbbb").Should().Be(1);
        }

        [Fact]
        public void LengthOfLongestSubstring_Example3()
        {
            LengthOfLongestSubstringProblem problem = new();

            problem.LengthOfLongestSubstring("pwwkew").Should().Be(3);
        }

        [Fact]
        public void LengthOfLongestSubstring_Example4()
        {
            LengthOfLongestSubstringProblem problem = new();

            problem.LengthOfLongestSubstring("").Should().Be(0);
        }

        [Fact]
        public void LengthOfLongestSubstring_Example5()
        {
            LengthOfLongestSubstringProblem problem = new();

            problem.LengthOfLongestSubstring(" ").Should().Be(1);
        }

        [Fact]
        public void LengthOfLongestSubstring_Example6()
        {
            LengthOfLongestSubstringProblem problem = new();

            problem.LengthOfLongestSubstring("au").Should().Be(2);
        }

        [Fact]
        public void LengthOfLongestSubstring_Example7()
        {
            LengthOfLongestSubstringProblem problem = new();

            problem.LengthOfLongestSubstring("dvdf").Should().Be(3);
        }

        [Fact]
        public void LengthOfLongestSubstring_Example8()
        {
            LengthOfLongestSubstringProblem problem = new();

            problem.LengthOfLongestSubstring("abcdcefgc").Should().Be(5);
        }
    }
}