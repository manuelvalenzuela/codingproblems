using CodingProblems;
using FluentAssertions;
using Xunit;

namespace CodingProblemsTests
{
    public class MergeTwoSortedListsTests
    {
        [Fact]
        public void MergeNullLists_ShouldReturnNull()
        {
            var mergedLists = MergeTwoSortedLists.Merge(null, null);
            mergedLists.Should().BeNull();
        }

        [Fact]
        public void MergeNullAndNonEmptyLists_ShouldReturnNonEmptyList()
        {
            var mergedLists = MergeTwoSortedLists.Merge(null, GetList2());
            mergedLists.Should().BeEquivalentTo(GetList2());
        }

        [Fact]
        public void MergeNonEmptyAndNullLists_ShouldReturnNonEmptyList()
        {
            var mergedLists = MergeTwoSortedLists.Merge(GetList1(), null);
            mergedLists.Should().BeEquivalentTo(GetList1());
        }

        [Fact]
        public void MergeOneItemWithOneItemLists_ShouldReturnTwoSortedItemsList()
        {
            var mergedLists = MergeTwoSortedLists.Merge(new MergeTwoSortedLists.ListNode(2), new MergeTwoSortedLists.ListNode(1));
            mergedLists.Should().BeEquivalentTo(
                new MergeTwoSortedLists.ListNode(1)
                {
                    next = new MergeTwoSortedLists.ListNode(2)
                });
        }

        [Fact]
        public void MergeList1AndList2_ShouldReturnMergedList1And2()
        {
            var mergedLists = MergeTwoSortedLists.Merge(GetList1(), GetList2());
            mergedLists.Should().BeEquivalentTo(GetMergedList1And2());
        }

        private static MergeTwoSortedLists.ListNode GetList1()
        {
            var root = new MergeTwoSortedLists.ListNode(1)
            {
                next = new MergeTwoSortedLists.ListNode(2)
                {
                    next = new MergeTwoSortedLists.ListNode(4)
                }
            };
            return root;
        }

        private static MergeTwoSortedLists.ListNode GetList2()
        {
            var root = new MergeTwoSortedLists.ListNode(1)
            {
                next = new MergeTwoSortedLists.ListNode(3)
                {
                    next = new MergeTwoSortedLists.ListNode(4)
                }
            };
            return root;
        }

        private static MergeTwoSortedLists.ListNode GetMergedList1And2()
        {
            var root = new MergeTwoSortedLists.ListNode(1)
            {
                next = new MergeTwoSortedLists.ListNode(1)
                {
                    next = new MergeTwoSortedLists.ListNode(2)
                    {
                        next = new MergeTwoSortedLists.ListNode(3)
                        {
                            next = new MergeTwoSortedLists.ListNode(4)
                            {
                                next = new MergeTwoSortedLists.ListNode(4)
                            }
                        }
                    }
                }
            };
            return root;
        }
    }
}