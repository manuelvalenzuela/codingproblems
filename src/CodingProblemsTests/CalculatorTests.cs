using System;
using CodingProblems;
using Xunit;

namespace CodingProblemsTests
{
    public class CalculatorTests
    {
        [Fact]
        public void SumOfEmpty()
        {
            var calc = new Calculator();
            Assert.Throws<ArgumentException>(() => calc.Sum("", ""));
        }

        [Fact]
        public void SumOfZerosShouldReturnZero()
        {
            var calc = new Calculator();
            var sum = calc.Sum("0", "0");
            Assert.Equal("0", sum);
        }

        [Fact]
        public void SumOnePlusZeroShouldReturnOne()
        {
            var calc = new Calculator();
            var sum = calc.Sum("1", "0");
            Assert.Equal("1", sum);
        }

        [Fact]
        public void SumOfAnyTwoNumbersShouldReturnAsExpected()
        {
            var calc = new Calculator();
            var sum = calc.Sum("8974587956", "58794879");
            Assert.Equal("9033382835", sum);
        }

        [Fact]
        public void SumOfTwoReallyBigNumbersShouldReturnAsExpected()
        {
            var calc = new Calculator();
            var sum = calc.Sum(
                "1111111111111111111111111111111111111111111111111111111111111111",
                "2222222222222222222222222222222222222222222222222222222222222222");
            Assert.Equal(
                "3333333333333333333333333333333333333333333333333333333333333333", sum);
        }
    }
}