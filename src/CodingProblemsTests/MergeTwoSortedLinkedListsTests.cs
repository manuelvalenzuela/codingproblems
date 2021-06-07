using CodingProblems;
using FluentAssertions;
using Xunit;

namespace CodingProblemsTests
{
    public class MergeTwoSortedLinkedListsTests
    {
        [Fact]
        public void MergeNullLists_ShouldReturnNull()
        {
            var mergedLists = MergeTwoSortedLinkedLists.Merge(null, null);
            mergedLists.Should().BeNull();
        }

        [Fact]
        public void MergeNullAndNonEmptyLists_ShouldReturnNonEmptyList()
        {
            var mergedLists = MergeTwoSortedLinkedLists.Merge(null, GetList2());
            mergedLists.Should().BeEquivalentTo(GetList2());
        }

        [Fact]
        public void MergeNonEmptyAndNullLists_ShouldReturnNonEmptyList()
        {
            var mergedLists = MergeTwoSortedLinkedLists.Merge(GetList1(), null);
            mergedLists.Should().BeEquivalentTo(GetList1());
        }

        [Fact]
        public void MergeOneItemWithOneItemLists_ShouldReturnTwoSortedItemsList()
        {
            var mergedLists = MergeTwoSortedLinkedLists.Merge(new MergeTwoSortedLinkedLists.ListNode(2), new MergeTwoSortedLinkedLists.ListNode(1));
            mergedLists.Should().BeEquivalentTo(
                new MergeTwoSortedLinkedLists.ListNode(1)
                {
                    next = new MergeTwoSortedLinkedLists.ListNode(2)
                });
        }

        [Fact]
        public void MergeList1AndList2_ShouldReturnMergedList1And2()
        {
            var mergedLists = MergeTwoSortedLinkedLists.Merge(GetList1(), GetList2());
            mergedLists.Should().BeEquivalentTo(GetMergedList1And2());
        }

        private static MergeTwoSortedLinkedLists.ListNode GetList1()
        {
            var root = new MergeTwoSortedLinkedLists.ListNode(1)
            {
                next = new MergeTwoSortedLinkedLists.ListNode(2)
                {
                    next = new MergeTwoSortedLinkedLists.ListNode(4)
                }
            };
            return root;
        }

        private static MergeTwoSortedLinkedLists.ListNode GetList2()
        {
            var root = new MergeTwoSortedLinkedLists.ListNode(1)
            {
                next = new MergeTwoSortedLinkedLists.ListNode(3)
                {
                    next = new MergeTwoSortedLinkedLists.ListNode(4)
                }
            };
            return root;
        }

        private static MergeTwoSortedLinkedLists.ListNode GetMergedList1And2()
        {
            var root = new MergeTwoSortedLinkedLists.ListNode(1)
            {
                next = new MergeTwoSortedLinkedLists.ListNode(1)
                {
                    next = new MergeTwoSortedLinkedLists.ListNode(2)
                    {
                        next = new MergeTwoSortedLinkedLists.ListNode(3)
                        {
                            next = new MergeTwoSortedLinkedLists.ListNode(4)
                            {
                                next = new MergeTwoSortedLinkedLists.ListNode(4)
                            }
                        }
                    }
                }
            };
            return root;
        }
    }
}