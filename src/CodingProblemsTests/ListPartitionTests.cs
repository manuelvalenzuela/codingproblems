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

            list[0].Should().BeLessOrEqualTo(3);
            list[1].Should().BeLessOrEqualTo(3);
            list[2].Should().BeLessOrEqualTo(3);
            list[3].Should().BeLessOrEqualTo(3);
            list[4].Should().BeGreaterOrEqualTo(3);
            list[5].Should().BeGreaterOrEqualTo(3);
        }


        [Fact]
        public void Partition_Derek()
        {
            var listPartition = new ListPartition();

            List<int> list = new() { 4, 0, 3, 2, 1, 5 };

            listPartition.Partition(list, 3);

            list[0].Should().BeLessOrEqualTo(3);
            list[1].Should().BeLessOrEqualTo(3);
            list[2].Should().BeLessOrEqualTo(3);
            list[3].Should().BeLessOrEqualTo(3);
            list[4].Should().BeGreaterOrEqualTo(3);
            list[5].Should().BeGreaterOrEqualTo(3);
        }
        
        [Fact]
        public void Partition_LastIsK()
        {
            var listPartition = new ListPartition();

            List<int> list = new() { 4, 0, 3, 2, 1, 5, 3 };

            listPartition.Partition(list, 3);

            list[0].Should().BeLessOrEqualTo(3);
            list[1].Should().BeLessOrEqualTo(3);
            list[2].Should().BeLessOrEqualTo(3);
            list[3].Should().BeLessOrEqualTo(3);
            list[4].Should().BeLessOrEqualTo(3);
            list[5].Should().BeGreaterOrEqualTo(3);
            list[6].Should().BeGreaterOrEqualTo(3);
        }

        [Fact]
        public void Partition_Repeated()
        {
            var listPartition = new ListPartition();

            List<int> list = new() { -4, 5, 3, 3, 2, 1, 7, -4, 3, 2, 0 };

            listPartition.Partition(list, 3);

            list[0].Should().BeLessOrEqualTo(3);
            list[1].Should().BeLessOrEqualTo(3);
            list[2].Should().BeLessOrEqualTo(3);
            list[3].Should().BeLessOrEqualTo(3);
            list[4].Should().BeLessOrEqualTo(3);
            list[5].Should().BeLessOrEqualTo(3);
            list[6].Should().BeLessOrEqualTo(3);
            list[7].Should().BeLessOrEqualTo(3);
            list[8].Should().BeLessOrEqualTo(3);
            list[9].Should().BeGreaterOrEqualTo(3);
            list[10].Should().BeGreaterOrEqualTo(3);
        }

        [Fact]
        public void Partition_RepeatedWhithoutK()
        {
            var listPartition = new ListPartition();

            List<int> list = new() { -4, 5, 2, 1, 7, -4, 2, 0 };

            listPartition.Partition(list, 3);

            list[0].Should().BeLessOrEqualTo(3);
            list[1].Should().BeLessOrEqualTo(3);
            list[2].Should().BeLessOrEqualTo(3);
            list[3].Should().BeLessOrEqualTo(3);
            list[4].Should().BeLessOrEqualTo(3);
            list[5].Should().BeLessOrEqualTo(3);
            list[6].Should().BeGreaterOrEqualTo(3);
            list[7].Should().BeGreaterOrEqualTo(3);
        }
    }
}