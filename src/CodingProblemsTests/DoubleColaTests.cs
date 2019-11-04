using System;
using CodingProblems;
using FluentAssertions;
using Xunit;

namespace CodingProblemsTests
{
    public class DoubleColaTests
    {
        private readonly string[] _names;
        public DoubleColaTests()
        {
            _names = new[] { "Sheldon", "Leonard", "Penny", "Rajesh", "Howard" };
        }
        
        [Fact]
        public void InputNumberLowerThanOneShouldThrowException()
        {
            var action = new Action(() =>
            {
                DoubleCola.WhoIsNext(_names, 0);
            });
            action.Should().Throw<ArgumentException>();
        }

        [Fact]
        public void InputNumberGreaterThanMaxValueShouldThrowException()
        {
            var action = new Action(() =>
            {
                var asdf = _names.Length * (long)Math.Pow(2, 61);
                DoubleCola.WhoIsNext(_names, asdf);
            });
            action.Should().Throw<ArgumentException>();
        }

        [Fact]
        public void Input1ShouldReturnExpected()
        {
            var result = DoubleCola.WhoIsNext(_names, 1);
            result.Should().Be("Sheldon");
        }

        [Fact]
        public void Input2ShouldReturnExpected()
        {
            var result = DoubleCola.WhoIsNext(_names, 2);
            result.Should().Be("Leonard");
        }

        [Fact]
        public void Input6ShouldReturnExpected()
        {
            var result = DoubleCola.WhoIsNext(_names, 6);
            result.Should().Be("Sheldon");
        }

        [Fact]
        public void Input52ShouldReturnExpected()
        {
            var result = DoubleCola.WhoIsNext(_names, 52);
            result.Should().Be("Penny");
        }

        [Fact]
        public void Input7230702951ShouldReturnExpected()
        {
            var result = DoubleCola.WhoIsNext(_names, 7230702951);
            result.Should().Be("Leonard");
        }
    }
}