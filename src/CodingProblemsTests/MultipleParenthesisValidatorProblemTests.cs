using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentAssertions;
using Xunit;
using CodingProblems;

namespace CodingProblemsTests
{
    public class MultipleParenthesisValidatorProblemTests
    {
        [Fact]
        public void IsValid_Example1()
        {
            MultipleParenthesisValidatorProblem multipleParenthesisValidatorProblem = new();
            multipleParenthesisValidatorProblem
                .IsValid(new char[] { '}' })
                .Should().BeFalse();
        }
        
        [Fact]
        public void IsValid_Example2()
        {
            MultipleParenthesisValidatorProblem multipleParenthesisValidatorProblem = new();
            multipleParenthesisValidatorProblem
                .IsValid(new char[] { '{' })
                .Should().BeFalse();
        }

        [Fact]
        public void IsValid_Example3()
        {
            MultipleParenthesisValidatorProblem multipleParenthesisValidatorProblem = new();
            multipleParenthesisValidatorProblem
                .IsValid(new char[] { ')', '(' })
                .Should()
                .BeFalse();
        }

        [Fact]
        public void IsValid_Example4()
        {
            MultipleParenthesisValidatorProblem multipleParenthesisValidatorProblem = new();
            multipleParenthesisValidatorProblem
                .IsValid(new char[] { '(', '(', ')', '(', ')', ')' })
                .Should()
                .BeTrue();
        }

        [Fact]
        public void IsValid_Example5()
        {
            MultipleParenthesisValidatorProblem multipleParenthesisValidatorProblem = new();
            multipleParenthesisValidatorProblem
                .IsValid(new char[] { '(', ')', '(', '(', ')', ')' })
                .Should()
                .BeTrue();
        }

        [Fact]
        public void IsValid_Example6()
        {
            MultipleParenthesisValidatorProblem multipleParenthesisValidatorProblem = new();
            multipleParenthesisValidatorProblem
                .IsValid(new char[] { '(', ')', '(', ')', '(', '(', '(', ')', '(', ')', '(', ')', ')', '(', ')', ')' })
                .Should()
                .BeTrue();
        }

        [Fact]
        public void IsValid_Example7()
        {
            MultipleParenthesisValidatorProblem multipleParenthesisValidatorProblem = new();
            multipleParenthesisValidatorProblem
                .IsValid(new char[] { '(', '{', ')', '(', '}', ')' })
                .Should()
                .BeFalse();
        }

        [Fact]
        public void IsValid_Example8()
        {
            MultipleParenthesisValidatorProblem multipleParenthesisValidatorProblem = new();
            multipleParenthesisValidatorProblem
                .IsValid(new char[] { '(', ')', '(', ')', '(', '[', '(', ')', '(', ')', '(', ')', ']', '{', '}', ')' })
                .Should()
                .BeTrue();
        }
    }
}