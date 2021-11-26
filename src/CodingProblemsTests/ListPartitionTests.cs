using CodingProblems;
using FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace CodingProblemsTests
{
    public class ListPartitionTests
    {
        [Fact]
        public void Partition_EmptyList()
        {
            var listPartition = new ListPartition();

            List<int> list = new() { };

            listPartition.Partition(list, 3);

            list.Should().BeEquivalentTo(new List<int>() { });
        }

        [Fact]
        public void Partition_OneElement()
        {
            var listPartition = new ListPartition();

            List<int> list = new() { 4 };

            listPartition.Partition(list, 3);

            list.Should().BeEquivalentTo(new List<int>() { 4 });
        }

        [Fact]
        public void Partition_BasicCase()
        {
            var listPartition = new ListPartition();

            List<int> list = new() { 4, 5, 3, 2, 1, 0 };

            listPartition.Partition(list, 3);

            list.Should().BeEquivalentTo(new List<int>() { 2, 1, 0, 3, 4, 5 });
        }

        [Fact]
        public void Partition_Repeated()
        {
            var listPartition = new ListPartition();

            List<int> list = new() { -4, 5, 3, 3, 2, 1, 7, -4, 3, 2, 0 };

            listPartition.Partition(list, 3);

            list.Should().BeEquivalentTo(new List<int>() { -4, 2, 1, 2, 0, -4, 3, 3, 3, 5, 7 });
        }

        [Fact]
        public void Partition_RepeatedWhithoutK()
        {
            var listPartition = new ListPartition();

            List<int> list = new() { -4, 5, 2, 1, 7, -4, 2, 0 };

            listPartition.Partition(list, 3);

            list.Should().BeEquivalentTo(new List<int>() { -4, 2, 1, 2, 0, -4, 5, 7 });
        }
    }
}