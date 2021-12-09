using CodingProblems;
using FluentAssertions;
using Xunit;

namespace CodingProblemsTests
{
    public class EulerMultiplesProblemTests
    {
        [Fact]
        public void LimitToZero_ShouldSumZero()
        {
            var calculator = CreateIntance();
            var eulerSum = calculator.SumOnlyMultiplesBelow(0);
            eulerSum.Should().Be(0);
        }

        [Fact]
        public void LimitToOne_ShouldSumZero()
        {
            var calculator = CreateIntance();
            var eulerSum = calculator.SumOnlyMultiplesBelow(1);
            eulerSum.Should().Be(0);
        }

        [Fact]
        public void LimitToTwo_ShouldSumZero()
        {
            var calculator = CreateIntance();
            var eulerSum = calculator.SumOnlyMultiplesBelow(2);
            eulerSum.Should().Be(0);
        }

        [Fact]
        public void LimitToThree_ShouldSumThree()
        {
            var calculator = CreateIntance();
            var eulerSum = calculator.SumOnlyMultiplesBelow(3);
            eulerSum.Should().Be(0);
        }

        [Fact]
        public void LimitToFour_ShouldSumThree()
        {
            var calculator = CreateIntance();
            var eulerSum = calculator.SumOnlyMultiplesBelow(4);
            eulerSum.Should().Be(3);
        }

        [Fact]
        public void LimitToFive_ShouldSumEight()
        {
            var calculator = CreateIntance();
            var eulerSum = calculator.SumOnlyMultiplesBelow(5);
            eulerSum.Should().Be(3);
        }

        [Fact]
        public void LimitToSix_ShouldSumEight()
        {
            var calculator = CreateIntance();
            var eulerSum = calculator.SumOnlyMultiplesBelow(6);
            eulerSum.Should().Be(8);
        }

        private static EulerMultiplesProblem CreateIntance()
        {
            return new EulerMultiplesProblem();
        }
    }
}