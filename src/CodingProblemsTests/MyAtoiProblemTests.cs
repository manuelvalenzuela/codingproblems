using CodingProblems;
using FluentAssertions;
using Xunit;

namespace CodingProblemsTests
{
    public class MyAtoiProblemTests
    {
        [Fact]
        public void Null_ShouldReturnZero()
        {
            var result = MyAtoiProblem.MyAtoi(null);
            result.Should().Be(0);
        }

        [Fact]
        public void OnlySpaces_ShouldReturnZero()
        {
            var result = MyAtoiProblem.MyAtoi("   ");
            result.Should().Be(0);
        }

        [Fact]
        public void NotValidFirstCharAfterTrim_ShouldReturnZero()
        {
            var result = MyAtoiProblem.MyAtoi("  e ");
            result.Should().Be(0);
        }

        [Fact]
        public void One_ShouldReturnOne()
        {
            var result = MyAtoiProblem.MyAtoi("1");
            result.Should().Be(1);
        }

        [Fact]
        public void MinusOne_ShouldReturnMinusOne()
        {
            var result = MyAtoiProblem.MyAtoi("-1");
            result.Should().Be(-1);
        }

        [Fact]
        public void SpacesMinusOne_ShouldReturnMinusOne()
        {
            var result = MyAtoiProblem.MyAtoi("   -1");
            result.Should().Be(-1);
        }

        [Fact]
        public void MinusOneNotNumbers_ShouldReturnMinusOne()
        {
            var result = MyAtoiProblem.MyAtoi("-1   s");
            result.Should().Be(-1);
        }

        [Fact]
        public void Example42_ShouldReturn42()
        {
            var result = MyAtoiProblem.MyAtoi("42");
            result.Should().Be(42);
        }

        [Fact]
        public void ExampleSpacesMinus42_ShouldReturnMinus42()
        {
            var result = MyAtoiProblem.MyAtoi("   -42");
            result.Should().Be(-42);
        }

        [Fact]
        public void SignMinus_ShouldReturnZero()
        {
            var result = MyAtoiProblem.MyAtoi("   -");
            result.Should().Be(0);
        }

        [Fact]
        public void SignPlus_ShouldReturnZero()
        {
            var result = MyAtoiProblem.MyAtoi("   +");
            result.Should().Be(0);
        }

        [Fact]
        public void Example4193WithWords_ShouldReturnMinus4193()
        {
            var result = MyAtoiProblem.MyAtoi("4193 with words");
            result.Should().Be(4193);
        }

        [Fact]
        public void ExampleWordsAnd987_ShouldReturnMinus987()
        {
            var result = MyAtoiProblem.MyAtoi("words and 987");
            result.Should().Be(0);
        }

        [Fact]
        public void ExampleMinus91283472332_ShouldReturnMinus987()
        {
            var result = MyAtoiProblem.MyAtoi("-91283472332");
            result.Should().Be(-2147483648);
        }

        [Fact]
        public void Example91283472332_ShouldReturnMinus987()
        {
            var result = MyAtoiProblem.MyAtoi("91283472332");
            result.Should().Be(2147483647);
        }
    }
}