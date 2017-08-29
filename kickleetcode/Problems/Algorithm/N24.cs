using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kickleetcode.Problems.Algorithm
{
    /// <summary>
    /// Swap Nodes in Pairs
    /// </summary>
    class N24
    {
        public ListNode SwapPairs(ListNode head)
        {
            ListNode p1 = head, p2 = head;
            ListNode realHead = new ListNode(-1);
            realHead.next = head;
            ListNode ptemp = realHead;

            while (p1 != null && p1.next != null)
            {
                p2 = p1.next;

                p1.next = p2.next;
                p2.next = p1;
                ptemp.next = p2;

                ptemp = p1;
                p1 = p1.next;
            }

            return realHead.next;
        }
    }
}
