using CodingProblems;
using FluentAssertions;
using Xunit;

namespace CodingProblemsTests
{
    public class ZigzagConversionProblemTests
    {
        [Fact]
        public void Convert_Example1()
        {
            ZigzagConversionProblem zigzagConversionProblem = new();
            zigzagConversionProblem
                .Convert("PAYPALISHIRING", 3)
                .Should()
                .Be("PAHNAPLSIIGYIR");
        }

        [Fact]
        public void Convert_Example2()
        {
            ZigzagConversionProblem zigzagConversionProblem = new();
            zigzagConversionProblem
                .Convert("PAYPALISHIRING", 4)
                .Should()
                .Be("PINALSIGYAHRPI");
        }

        [Fact]
        public void Convert_Example3()
        {
            ZigzagConversionProblem zigzagConversionProblem = new();
            zigzagConversionProblem
                .Convert("ABCD", 2)
                .Should()
                .Be("ACBD");
        }
    }
}