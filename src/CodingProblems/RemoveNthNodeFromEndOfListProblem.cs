using System.Collections.Generic;

namespace CodingProblems
{
    internal class RemoveNthNodeFromEndOfListProblem
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode current = head;

            Stack<ListNode> nodesStack = new();
            long count = 0;
            while (current != null)
            {
                nodesStack.Push(current);
                current = current.next;
                count++;
            }

            if (n == count) return head.next;

            ListNode target = null;
            for (int i = 0; i <= n; i++)
            {
                target = nodesStack.Pop();
            }

            target.next = target.next.next;

            return head;
        }
    }
}