using CodingProblems;
using FluentAssertions;
using System;
using System.Collections.Generic;
using Xunit;

namespace CodingProblemsTests
{
    public class MergeTwoSortedListsTests
    {
        [Fact]
        public void MergeTwoLists_Nulls_ShouldThrow()
        {
            Action action = () =>
            {
                MergeTwoSortedLists.Merge(null, null);
            };
            action.Should().Throw<ArgumentNullException>();
        }

        [Fact]
        public void MergeTwoLists_FirstNull_ShouldThrow()
        {
            Action action = () =>
            {
                MergeTwoSortedLists.Merge(
                    new List<int>(),
                    null);
            };
            action.Should().Throw<ArgumentNullException>();
        }

        [Fact]
        public void MergeTwoLists_SecondNull_ShouldThrow()
        {
            Action action = () =>
            {
                MergeTwoSortedLists.Merge(
                    null,
                    new List<int>());
            };
            action.Should().Throw<ArgumentNullException>();
        }

        [Fact]
        public void MergeTwoLists_BothEmpty_ShouldMerge()
        {
            var result = MergeTwoSortedLists.Merge(
                new List<int>(),
                new List<int>());
            result.Should().NotBeNull();
        }

        [Fact]
        public void MergeTwoLists_FirstEmpty_ShouldMerge()
        {
            var result = MergeTwoSortedLists.Merge(
                new List<int>(),
                new List<int>() { 1 });
            result.Should().HaveCount(1);
            result[0].Should().Be(1);
        }

        [Fact]
        public void MergeTwoLists_SecondEmpty_ShouldMerge()
        {
            var result = MergeTwoSortedLists.Merge(
                new List<int>() { 1 },
                new List<int>());
            result.Should().HaveCount(1);
            result[0].Should().Be(1);
        }

        [Fact]
        public void MergeTwoLists_BothWithSameElement_ShouldMerge()
        {
            var result = MergeTwoSortedLists.Merge(
                new List<int>() { 1 },
                new List<int>() { 1 });
            result.Should().HaveCount(2);
            result[0].Should().Be(1);
            result[1].Should().Be(1);
        }

        [Fact]
        public void MergeTwoLists_BothWithOneDistinctElement_ShouldMergeSorted()
        {
            var result = MergeTwoSortedLists.Merge(
                new List<int>() { 1 },
                new List<int>() { 2 });
            result.Should().HaveCount(2);
            result[0].Should().Be(1);
            result[1].Should().Be(2);
        }

        [Fact]
        public void MergeTwoLists_BothWithOneDistinctUnsortedElement_ShouldMergeSorted()
        {
            var result = MergeTwoSortedLists.Merge(
                new List<int>() { 2 },
                new List<int>() { 1 });
            result.Should().HaveCount(2);
            result[0].Should().Be(1);
            result[1].Should().Be(2);
        }

        [Fact]
        public void MergeTwoLists_DisctinctSizesFirstBigger_ShouldMergeSorted()
        {
            var result = MergeTwoSortedLists.Merge(
                new List<int>() { 1, 2 },
                new List<int>() { 1 });
            result.Should().HaveCount(3);
            result[0].Should().Be(1);
            result[1].Should().Be(1);
            result[2].Should().Be(2);
        }

        [Fact]
        public void MergeTwoLists_DisctinctSizesSecondBigger_ShouldMergeSorted()
        {
            var result = MergeTwoSortedLists.Merge(
                new List<int>() { 1 },
                new List<int>() { 1, 2 });
            result.Should().HaveCount(3);
            result[0].Should().Be(1);
            result[1].Should().Be(1);
            result[2].Should().Be(2);
        }

        [Fact]
        public void MergeTwoLists_FirstAreLast_ShouldMergeSorted()
        {
            var result = MergeTwoSortedLists.Merge(
                new List<int>() { 10 },
                new List<int>() { 1, 2 });
            result.Should().HaveCount(3);
            result[0].Should().Be(1);
            result[1].Should().Be(2);
            result[2].Should().Be(10);
        }

        [Fact]
        public void MergeTwoLists_SecondAreLast_ShouldMergeSorted()
        {
            var result = MergeTwoSortedLists.Merge(
                new List<int>() { 1, 2 },
                new List<int>() { 10 });
            result.Should().HaveCount(3);
            result[0].Should().Be(1);
            result[1].Should().Be(2);
            result[2].Should().Be(10);
        }

        [Fact]
        public void MergeTwoLists_RandomCase_ShouldMergeSorted()
        {
            var result = MergeTwoSortedLists.Merge(
                new List<int>() { -71, 2, 12345 },
                new List<int>() { -100, 1, 2, 12344 });
            result.Should().HaveCount(7);
            result[0].Should().Be(-100);
            result[1].Should().Be(-71);
            result[2].Should().Be(1);
            result[3].Should().Be(2);
            result[4].Should().Be(2);
            result[5].Should().Be(12344);
            result[6].Should().Be(12345);
        }
    }
}