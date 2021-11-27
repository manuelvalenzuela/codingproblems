using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems
{
    public class AddTwoNumbersProblem
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

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode resultNode = new ListNode(0);
            ListNode pointer = resultNode;
            int carryOver = 0;
            while (true)
            {
                int num1 = GetNodeValue(ref l1);

                int num2 = GetNodeValue(ref l2);

                int res = (num1 + num2 + carryOver) % 10;
                carryOver = (num1 + num2 + carryOver) / 10;

                pointer.next = new ListNode(res);
                pointer = pointer.next;
                
                if (l1 == null && l2 == null && carryOver == 0)
                {
                    resultNode = resultNode.next;
                    return resultNode;
                }
            }
        }

        private int GetNodeValue(ref ListNode node)
        {
            if (node != null)
            {
                int val = node.val;
                node = node.next;
                return val;
            }
            return 0;
        }
    }
}