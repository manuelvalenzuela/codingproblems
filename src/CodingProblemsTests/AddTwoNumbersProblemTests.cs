using CodingProblems;
using FluentAssertions;
using Xunit;

namespace CodingProblemsTests
{
    public class AddTwoNumbersProblemTests
    {
        [Fact]
        public void AddTwoNumbers_Basic()
        {
            AddTwoNumbersProblem.ListNode l1 = new(2, new(4, new(3)));
            AddTwoNumbersProblem.ListNode l2 = new(5, new(6, new(4)));

            AddTwoNumbersProblem addTwoNumbersProblem = new();
            var result = addTwoNumbersProblem.AddTwoNumbers(l1, l2);

            result.Should().BeEquivalentTo(new AddTwoNumbersProblem.ListNode(7, new(0, new(8))));
        }

        [Fact]
        public void AddTwoNumbers_Basic2()
        {
            AddTwoNumbersProblem.ListNode l1 = new(0);
            AddTwoNumbersProblem.ListNode l2 = new(0);

            AddTwoNumbersProblem addTwoNumbersProblem = new();
            var result = addTwoNumbersProblem.AddTwoNumbers(l1, l2);

            result.Should().BeEquivalentTo(new AddTwoNumbersProblem.ListNode(0));
        }

        [Fact]
        public void AddTwoNumbers_Basic3()
        {
            AddTwoNumbersProblem.ListNode l1 = new(9, new(9, new(9, new(9, new(9, new(9,new(9)))))));
            AddTwoNumbersProblem.ListNode l2 = new(9, new(9, new(9, new(9))));

            AddTwoNumbersProblem addTwoNumbersProblem = new();
            var result = addTwoNumbersProblem.AddTwoNumbers(l1, l2);

            result.Should().BeEquivalentTo(new AddTwoNumbersProblem.ListNode(8, new(9, new(9, new(9, new(0, new(0, new(0, new(1)))))))));
        }
    }
}