namespace CodingProblems
{
    public class MergeTwoSortedLists
    {
        public static ListNode Merge(ListNode l1, ListNode l2)
        {
            var newNode = new ListNode(int.MinValue);
            var root = newNode;
            while (true)
            {
                if (l1 == null && l2 == null)
                {
                    return root.next;
                }
                
                if (l1 != null && l2 == null)
                {
                    newNode.next = new ListNode(l1.val);
                    l1 = l1.next;
                }
                else if (l1 == null)
                {
                    newNode.next = new ListNode(l2.val);
                    l2 = l2.next;
                }
                else
                {
                    if (l1.val < l2.val)
                    {
                        newNode.next = new ListNode(l1.val);
                        l1 = l1.next;
                    }
                    else
                    {
                        newNode.next = new ListNode(l2.val);
                        l2 = l2.next;
                    }
                }

                newNode = newNode.next;
            }
        }

        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            var merged = new ListNode(int.MinValue);
            ListNode head = merged;

            while (true)
            {
                ListNode newNode;
                if (l1 != null && l2 != null)
                {
                    if (l1.val < l2.val)
                    {
                        newNode = GetValueAndIncrement(ref l1);
                    }
                    else
                    {
                        newNode = GetValueAndIncrement(ref l2);
                    }
                }
                else if (l1 != null)
                {
                    newNode = GetValueAndIncrement(ref l1);
                }
                else if (l2 != null)
                {
                    newNode = GetValueAndIncrement(ref l2);
                }
                else
                {
                    return head.next;
                }
                merged.next = newNode;
                merged = merged.next;
            }
        }

        private ListNode GetValueAndIncrement(ref ListNode node)
        {
            var newNode = new ListNode(node.val);
            node = node.next;
            return newNode;
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
    }
}