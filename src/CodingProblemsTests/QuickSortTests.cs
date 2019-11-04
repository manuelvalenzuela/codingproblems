using CodingProblems;
using Xunit;

namespace CodingProblemsTests
{
    public class QuickSortTests
    {
        [Fact]
        public void QuickSort_EmptyArray_ShouldReturnEmptyArray()
        {
            var sorter = new QuickSort();
            var a = new int[] { };

            Assert.Equal(new int[] { }, sorter.Sort(a));
        }

        [Fact]
        public void QuickSort_ArrayWithOneElement_ShouldReturnSame()
        {
            var sorter = new QuickSort();
            var a = new int[] { 4 };

            Assert.Equal(new int[] { 4 }, sorter.Sort(a));
        }

        [Fact]
        public void QuickSort_Array_ShouldReturnSorted()
        {
            var sorter = new QuickSort();
            var a = new int[] { 3, 2, 8, 5, 1, 4, 7, 6 };

            Assert.Equal(new int[] { 1,2,3,4,5,6,7,8 }, sorter.Sort(a));
        }

        [Fact]
        public void QuickSort_ArrayCourseraExample_ShouldReturnSorted()
        {
            var sorter = new QuickSort();
            var a = new int[] { 2, 20, 1, 15, 3, 11, 13, 6, 16, 10, 19, 5, 4, 9, 8, 14, 18, 17, 7, 12 };

            Assert.Equal(
                new [] { 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20 },
                sorter.Sort(a));
        }
    }
}