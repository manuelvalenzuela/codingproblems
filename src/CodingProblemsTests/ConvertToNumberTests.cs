using System;
using CodingProblems;
using FluentAssertions;
using Xunit;

namespace CodingProblemsTests
{
    public class ConvertToNumberTests
    {
        [Fact]
        public void UsingNullString_ShouldReturnFalse()
        {
            var canConvert = ConvertToNumberClass.ConvertToNumber(null);
            canConvert.Should().BeFalse();
        }

        [Fact]
        public void UsingEmptyString_ShouldReturnFalse()
        {
            var canConvert = ConvertToNumberClass.ConvertToNumber("");
            canConvert.Should().BeFalse();
        }

        [Fact]
        public void UsingSpace_ShouldReturnFalse()
        {
            var canConvert = ConvertToNumberClass.ConvertToNumber(" ");
            canConvert.Should().BeFalse();
        }

        [Fact]
        public void UsingOneNonNumber_ShouldReturnFalse()
        {
            var canConvert = ConvertToNumberClass.ConvertToNumber("a");
            canConvert.Should().BeFalse();
        }

        [Fact]
        public void UsingManyNonNumber_ShouldReturnFalse()
        {
            var canConvert = ConvertToNumberClass.ConvertToNumber("abc!#$%");
            canConvert.Should().BeFalse();
        }

        //[Fact]
        //public void UsingNumberZero_ShouldReturnTrue()
        //{
        //    var canConvert = ConvertToNumberClass.ConvertToNumber("0");
        //    canConvert.Should().BeTrue();
        //}

        [Fact]
        public void UsingNegativeSign_ShouldReturnFalse()
        {
            var canConvert = ConvertToNumberClass.ConvertToNumber("-");
            canConvert.Should().BeFalse();
        }

        [Fact]
        public void UsingNumberOne_ShouldReturnTrue()
        {
            var canConvert = ConvertToNumberClass.ConvertToNumber("1");
            canConvert.Should().BeTrue();
        }

        [Fact]
        public void UsingNegativeOne_ShouldReturnTrue()
        {
            var canConvert = ConvertToNumberClass.ConvertToNumber("-1");
            canConvert.Should().BeTrue();
        }

        [Fact]
        public void UsingNumberZeroOne_ShouldReturnTrue()
        {
            var canConvert = ConvertToNumberClass.ConvertToNumber("01");
            canConvert.Should().BeTrue();
        }

        [Fact]
        public void UsingNumberTen_ShouldReturnTrue()
        {
            var canConvert = ConvertToNumberClass.ConvertToNumber("10");
            canConvert.Should().BeTrue();
        }

        //[Fact]
        //public void UsingDecimalNumberSeparatedByComma_ShouldReturnTrue()
        //{
        //    var canConvert = ConvertToNumberClass.ConvertToNumber("0,1");
        //    canConvert.Should().BeTrue();
        //}

        //[Fact]
        //public void UsingDecimalNumberSeparatedByPoint_ShouldReturnTrue()
        //{
        //    var canConvert = ConvertToNumberClass.ConvertToNumber("0.1");
        //    canConvert.Should().BeTrue();
        //}

        //[Fact]
        //public void UsingDecimalNegativeNumberSeparatedByComma_ShouldReturnTrue()
        //{
        //    var canConvert = ConvertToNumberClass.ConvertToNumber("-0,1");
        //    canConvert.Should().BeTrue();
        //}

        //[Fact]
        //public void UsingDecimalNegativeNumberSeparatedByPoint_ShouldReturnTrue()
        //{
        //    var canConvert = ConvertToNumberClass.ConvertToNumber("-0.1");
        //    canConvert.Should().BeTrue();
        //}

        [Fact]
        public void UsingTwoNumbersSeparatedBySpace_ShouldReturnFalse()
        {
            var canConvert = ConvertToNumberClass.ConvertToNumber("0 1");
            canConvert.Should().BeFalse();
        }

        [Fact]
        public void UsingMax16BitValue_ShouldReturnTrue()
        {
            var canConvert = ConvertToNumberClass.ConvertToNumber(Int16.MaxValue.ToString());
            canConvert.Should().BeTrue();
        }

        [Fact]
        public void UsingMin16BitValue_ShouldReturnTrue()
        {
            var canConvert = ConvertToNumberClass.ConvertToNumber(Int16.MinValue.ToString());
            canConvert.Should().BeTrue();
        }

        //[Fact]
        //public void UsingMax16BitValuePlusOne_ShouldReturnTrue()
        //{
        //    var canConvert = ConvertToNumberClass.ConvertToNumber((Int16.MaxValue + 1).ToString());
        //    canConvert.Should().BeTrue();
        //}


        //[Fact]
        //public void UsingMin16BitValueMinusOne_ShouldReturnTrue()
        //{
        //    var canConvert = ConvertToNumberClass.ConvertToNumber((Int16.MinValue - 1).ToString());
        //    canConvert.Should().BeTrue();
        //}

        //[Fact]
        //public void UsingMax32BitValue_ShouldReturnTrue()
        //{
        //    var canConvert = ConvertToNumberClass.ConvertToNumber(Int32.MaxValue.ToString());
        //    canConvert.Should().BeTrue();
        //}

        //[Fact]
        //public void UsingMin32BitValue_ShouldReturnTrue()
        //{
        //    var canConvert = ConvertToNumberClass.ConvertToNumber(Int32.MinValue.ToString());
        //    canConvert.Should().BeTrue();
        //}

        //[Fact]
        //public void UsingMax64BitValue_ShouldReturnTrue()
        //{
        //    var canConvert = ConvertToNumberClass.ConvertToNumber(Int64.MaxValue.ToString());
        //    canConvert.Should().BeTrue();
        //}

        //[Fact]
        //public void UsingMin64BitValue_ShouldReturnTrue()
        //{
        //    var canConvert = ConvertToNumberClass.ConvertToNumber(Int64.MinValue.ToString());
        //    canConvert.Should().BeTrue();
        //}

        //[Fact]
        //public void UsingDoubleTypeValue_ShouldReturnTrue()
        //{
        //    double number = 5.3;
        //    var canConvert = ConvertToNumberClass.ConvertToNumber(number.ToString());
        //    canConvert.Should().BeTrue();
        //}
    }
}