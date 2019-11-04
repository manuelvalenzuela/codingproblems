using System;
using CodingProblems;
using FluentAssertions;
using Xunit;

namespace CodingProblemsTests
{
    public class DivideLeetCodeProblemTests
    {
        [Fact]
        public void DivideByZero_ShouldThrowException()
        {
            Func<int> action = () =>
            DivideLeetCodeProblem.Divide(0, 0);
            action.Should().Throw<DivideByZeroException>();
        }

        [Fact]
        public void DivideWithDividendZero_ShouldReturnZero()
        {
            var result = DivideLeetCodeProblem.Divide(0, 1);
            result.Should().Be(0);
        }

        [Fact]
        public void OneDividedByOne_ShouldReturnOne()
        {
            var result = DivideLeetCodeProblem.Divide(1, 1);
            result.Should().Be(1);
        }

        [Fact]
        public void TwoDividedByOne_ShouldReturnTwo()
        {
            var result = DivideLeetCodeProblem.Divide(2, 1);
            result.Should().Be(2);
        }

        [Fact]
        public void OneDividedByTwo_ShouldReturnZero()
        {
            var result = DivideLeetCodeProblem.Divide(1, 2);
            result.Should().Be(0);
        }

        [Fact]
        public void TwoDividedByTwo_ShouldReturnOne()
        {
            var result = DivideLeetCodeProblem.Divide(2, 2);
            result.Should().Be(1);
        }

        [Fact]
        public void EightDividedByTwo_ShouldReturnFour()
        {
            var result = DivideLeetCodeProblem.Divide(8, 2);
            result.Should().Be(4);
        }

        [Fact]
        public void SixDividedByTwo_ShouldReturnThree()
        {
            var result = DivideLeetCodeProblem.Divide(6, 2);
            result.Should().Be(3);
        }

        [Fact]
        public void SevenDividedByTwo_ShouldReturnThree()
        {
            var result = DivideLeetCodeProblem.Divide(7, 2);
            result.Should().Be(3);
        }

        [Fact]
        public void SixtyDividedByFiftyNine_ShouldReturnOne()
        {
            var result = DivideLeetCodeProblem.Divide(60, 59);
            result.Should().Be(1);
        }

        [Fact]
        public void MaxInt32DividedByTwo_ShouldReturnDivision()
        {
            var result = DivideLeetCodeProblem.Divide(int.MaxValue, 2);
            result.Should().Be(int.MaxValue / 2);
        }

        [Fact]
        public void TwoDividedByNegativeOne_ShouldReturnNegativeTwo()
        {
            var result = DivideLeetCodeProblem.Divide(2, -1);
            result.Should().Be(-2);
        }

        [Fact]
        public void OneDividedByNegativeOne_ShouldReturnNegativeOne()
        {
            var result = DivideLeetCodeProblem.Divide(1, -1);
            result.Should().Be(-1);
        }

        [Fact]
        public void FourDividedByNegativeTwo_ShouldReturnNegativeTwo()
        {
            var result = DivideLeetCodeProblem.Divide(4, -2);
            result.Should().Be(-2);
        }

        [Fact]
        public void NegativeOneDividedByOne_ShouldReturnNegativeOne()
        {
            var result = DivideLeetCodeProblem.Divide(-1, 1);
            result.Should().Be(-1);
        }

        [Fact]
        public void NegativeOneDividedByTwo_ShouldReturnZero()
        {
            var result = DivideLeetCodeProblem.Divide(-1, 2);
            result.Should().Be(0);
        }

        [Fact]
        public void NegativeTwoDividedByOne_ShouldReturnNegativeTwo()
        {
            var result = DivideLeetCodeProblem.Divide(-2, 1);
            result.Should().Be(-2);
        }

        [Fact]
        public void FourDividedByNegativeOne_ShouldReturnNegativeFour()
        {
            var result = DivideLeetCodeProblem.Divide(4, -1);
            result.Should().Be(-4);
        }

        [Fact]
        public void NegativeFourDividedByTwo_ShouldReturnNegativeTwo()
        {
            var result = DivideLeetCodeProblem.Divide(-4, 2);
            result.Should().Be(-2);
        }

        [Fact]
        public void MinInt32DividedByTwo_ShouldReturnDivision()
        {
            var result = DivideLeetCodeProblem.Divide(int.MinValue, 2);
            result.Should().Be(int.MinValue / 2);
        }

        [Fact]
        public void NegativeOneDividedByNegativeOne_ShouldReturnOne()
        {
            var result = DivideLeetCodeProblem.Divide(-1, -1);
            result.Should().Be(1);
        }

        [Fact]
        public void NegativeOneDividedByNegativeTwo_ShouldReturnZero()
        {
            var result = DivideLeetCodeProblem.Divide(-1, -2);
            result.Should().Be(0);
        }

        [Fact]
        public void NegativeTwoDividedByNegativeOne_ShouldReturnNegativeTwo()
        {
            var result = DivideLeetCodeProblem.Divide(-2, -1);
            result.Should().Be(2);
        }

        [Fact]
        public void NegativeFourDividedByNegativeOne_ShouldReturnNegativeFour()
        {
            var result = DivideLeetCodeProblem.Divide(-4, -1);
            result.Should().Be(4);
        }

        [Fact]
        public void NegativeFourDividedByNegativeTwo_ShouldReturnNegativeTwo()
        {
            var result = DivideLeetCodeProblem.Divide(-4, -2);
            result.Should().Be(2);
        }

        [Fact]
        public void MinInt32DividedByNegativeTwo_ShouldReturnDivision()
        {
            var result = DivideLeetCodeProblem.Divide(int.MinValue, -2);
            result.Should().Be(int.MinValue / -2);
        }

        [Fact]
        public void MinInt32DividedByNegativeOne_ShouldReturnDivision()
        {
            var result = DivideLeetCodeProblem.Divide(int.MinValue, -1);
            result.Should().Be(int.MaxValue);
        }
    }
}