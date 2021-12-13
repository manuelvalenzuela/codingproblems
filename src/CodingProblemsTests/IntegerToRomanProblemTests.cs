using CodingProblems;
using FluentAssertions;
using Xunit;

namespace CodingProblemsTests
{
    public class IntegerToRomanProblemTests
    {
        [Fact]
        public void IntToRoman_Example1()
        {
            IntegerToRomanProblem integerToRomanProblem = new();
            integerToRomanProblem.IntToRoman(3)
                .Should()
                .Be("III");
        }

        [Fact]
        public void IntToRoman_Example2()
        {
            IntegerToRomanProblem integerToRomanProblem = new();
            integerToRomanProblem.IntToRoman(4)
                .Should()
                .Be("IV");
        }
        
        [Fact]
        public void IntToRoman_Example3()
        {
            IntegerToRomanProblem integerToRomanProblem = new();
            integerToRomanProblem.IntToRoman(9)
                .Should()
                .Be("IX");
        }
        
        [Fact]
        public void IntToRoman_Example4()
        {
            IntegerToRomanProblem integerToRomanProblem = new();
            integerToRomanProblem.IntToRoman(58)
                .Should()
                .Be("LVIII");
        }
        
        [Fact]
        public void IntToRoman_Example5()
        {
            IntegerToRomanProblem integerToRomanProblem = new();
            integerToRomanProblem.IntToRoman(1994)
                .Should()
                .Be("MCMXCIV");
        }

        [Fact]
        public void IntToRoman_Example6()
        {
            IntegerToRomanProblem integerToRomanProblem = new();
            integerToRomanProblem.IntToRoman(1981)
                .Should()
                .Be("MCMLXXXI");
        }
    }
}