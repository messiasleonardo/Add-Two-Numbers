using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTwoNumbers
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

    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int load = 0, sum;
            ListNode head = new ListNode(0);
            ListNode ln1 = l1, ln2 = l2, node = head;

            while (load != 0 || ln1 != null || ln2 != null)
            {
                sum = load; 

                if (ln1 != null)
                {
                    sum += ln1.val;
                    ln1 = ln1.next;
                }
                if (ln2 != null)
                {
                    sum += ln2.val;
                    ln2 = ln2.next;
                }

                load = sum / 10;
                node.next = new ListNode(sum % 10);
                node = node.next;
            }
            return head.next;
        }
    }
}
