using CodingProblems;
using FluentAssertions;
using Xunit;

namespace CodingProblemsTests
{
    public class SingleParenthesisValidatorProblemTests
    {
        [Fact]
        public void IsValid_Example1()
        {
            SingleParenthesisValidatorProblem singleParenthesisValidatorProblem = new();
            singleParenthesisValidatorProblem
                .IsValid(new char[] { '(' })
                .Should()
                .BeFalse();
        }

        [Fact]
        public void IsValid_Example2()
        {
            SingleParenthesisValidatorProblem singleParenthesisValidatorProblem = new();
            singleParenthesisValidatorProblem
                .IsValid(new char[] { ')' })
                .Should()
                .BeFalse();
        }

        [Fact]
        public void IsValid_Example3()
        {
            SingleParenthesisValidatorProblem singleParenthesisValidatorProblem = new();
            singleParenthesisValidatorProblem
                .IsValid(new char[] { ')', '(' })
                .Should()
                .BeFalse();
        }

        [Fact]
        public void IsValid_Example4()
        {
            SingleParenthesisValidatorProblem singleParenthesisValidatorProblem = new();
            singleParenthesisValidatorProblem
                .IsValid(new char[] { '(', '(', ')', '(', ')', ')' })
                .Should()
                .BeTrue();
        }

        [Fact]
        public void IsValid_Example5()
        {
            SingleParenthesisValidatorProblem singleParenthesisValidatorProblem = new();
            singleParenthesisValidatorProblem
                .IsValid(new char[] { '(', ')', '(', '(', ')', ')' })
                .Should()
                .BeTrue();
        }

        [Fact]
        public void IsValid_Example6()
        {
            SingleParenthesisValidatorProblem singleParenthesisValidatorProblem = new();
            singleParenthesisValidatorProblem
                .IsValid(new char[] { '(', ')', '(', ')', '(', '(', '(', ')', '(', ')', '(', ')', ')', '(', ')', ')' })
                .Should()
                .BeTrue();
        }
    }
}