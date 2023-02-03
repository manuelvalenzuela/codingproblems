using CodingProblems;
using FluentAssertions;
using Xunit;

namespace CodingProblemsTests
{
    public class MergeThreeSortedArraysTests
    {
        [Fact]
        public void MergeThreeNullArrays_ShouldReturnEmptyArray()
        {
            var merged = MergeThreeSortedArrays.Merge(null, null, null);
            merged.Should().BeNull();
        }

        [Fact]
        public void MergeThreeEmptyArrays_ShouldReturnEmptyArray()
        {
            var a = new int[] { };
            var b = new int[] { };
            var c = new int[] { };

            var merged = MergeThreeSortedArrays.Merge(a, b, c);
            merged.Should().NotBeNull().And.BeEmpty();
        }

        [Fact]
        public void MergeFirstNonEmptyWithOtherTwoNullArrays_ShouldReturnNotEmptyArray()
        {
            int[] a = new[] { 1, 2, 3, 4, 7, 8 };
            int[] b = null;
            int[] c = null;

            var merged = MergeThreeSortedArrays.Merge(a, b, c);
            merged.Should().BeEquivalentTo(a, options => options.WithStrictOrdering());
        }

        [Fact]
        public void MergeSecondNonEmptyWithOtherTwoNullArrays_ShouldReturnNotEmptyArray()
        {
            int[] a = null;
            int[] b = new[] { 1, 2, 3, 4, 7, 8 };
            int[] c = null;

            var merged = MergeThreeSortedArrays.Merge(a, b, c);
            merged.Should().BeEquivalentTo(b, options => options.WithStrictOrdering());
        }

        [Fact]
        public void MergeThirdNonEmptyWithOtherTwoNullArrays_ShouldReturnNotEmptyArray()
        {
            int[] a = null;
            int[] b = null;
            int[] c = new[] { 1, 2, 3, 4, 7, 8 };

            var merged = MergeThreeSortedArrays.Merge(a, b, c);
            merged.Should().BeEquivalentTo(c, options => options.WithStrictOrdering());
        }

        [Fact]
        public void MergeFirstNonEmptyWithOtherTwoEmptyArrays_ShouldReturnNotEmptyArray()
        {
            var a = new[] { 1, 2, 3, 4, 7, 8 };
            var b = new int[] { };
            var c = new int[] { };

            var merged = MergeThreeSortedArrays.Merge(a, b, c);
            merged.Should().BeEquivalentTo(a, options => options.WithStrictOrdering());
        }

        [Fact]
        public void MergeSecondNonEmptyWithOtherTwoEmptyArrays_ShouldReturnNotEmptyArray()
        {
            var a = new int[] { };
            var b = new[] { 1, 2, 3, 4, 7, 8 };
            var c = new int[] { };

            var merged = MergeThreeSortedArrays.Merge(a, b, c);
            merged.Should().BeEquivalentTo(b, options => options.WithStrictOrdering());
        }

        [Fact]
        public void MergeThirdNonEmptyWithOtherTwoEmptyArrays_ShouldReturnNotEmptyArray()
        {
            var a = new int[] { };
            var b = new int[] { };
            var c = new[] { 1, 2, 3, 4, 7, 8 };

            var merged = MergeThreeSortedArrays.Merge(a, b, c);
            merged.Should().BeEquivalentTo(c, options => options.WithStrictOrdering());
        }

        [Fact]
        public void MergeTwoNonEmptyArrays_ShouldReturnNotEmptyArray()
        {
            var a = new int[] { 1, 2 };
            var b = new int[] { 3 };
            var c = new int[] { };

            var merged = MergeThreeSortedArrays.Merge(a, b, c);
            merged.Should().BeEquivalentTo(new[] { 1, 2, 3 }, options => options.WithStrictOrdering());
        }

        [Fact]
        public void MergeThreeNonEmptyArrays_ShouldReturnNotEmptyArray()
        {
            var a = new int[] { 1, 2 };
            var b = new int[] { 3 };
            var c = new int[] { 4 };

            var merged = MergeThreeSortedArrays.Merge(a, b, c);
            merged.Should().BeEquivalentTo(new[] { 1, 2, 3, 4 }, options => options.WithStrictOrdering());
        }

        [Fact]
        public void MergeThreeNonEmptyArraysWithDuplicated_ShouldReturnNotEmptyArray()
        {
            var a = new int[] { 1, 2 };
            var b = new int[] { 3, 4 };
            var c = new int[] { 4 };

            var merged = MergeThreeSortedArrays.Merge(a, b, c);
            merged.Should().BeEquivalentTo(new[] { 1, 2, 3, 4 }, options => options.WithStrictOrdering());
        }

        [Fact]
        public void MergeThreeNonEmptyArraysWithManyDuplicated_ShouldReturnNotEmptyArray()
        {
            var a = new int[] { -1, 1, 2, 3, 3 };
            var b = new int[] { -2, 0, 1, 5, 7, 10, 10, 10, 10, 10, 10 };
            var c = new int[] { -200, 1, 1, 4, 5, 7, 10 };

            var merged = MergeThreeSortedArrays.Merge(a, b, c);
            merged.Should().BeEquivalentTo(new[] { -200, -2, -1, 0, 1, 2, 3, 4, 5, 7, 10 }, options => options.WithStrictOrdering());
        }
    }
}