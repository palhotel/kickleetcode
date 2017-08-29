using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kickleetcode.Problems.Algorithm
{
    /// <summary>
    /// Reverse Nodes in k-Group
    /// </summary>
    class N25
    {
        public ListNode ReverseKGroup(ListNode head, int k)
        {
            ListNode p1 = head, p2 = head;
            ListNode realHead = new ListNode(-1);
            realHead.next = head;
            ListNode pkhead= realHead;
            ListNode temp = null;


            while (isNeed(p1, k))
            {
                int n = k - 1;
                p2 = p1.next;

                while (n > 0)
                {
                    pkhead.next = p2;
                    temp = p2.next;
                    p2.next = p1;

                    p1 = p2;
                    p2 = temp;
                    n --;
                }

                p1 = p2;
                n = k;
                while (n-- > 0)
                {
                    pkhead = pkhead.next;
                }
                pkhead.next = p1;
            }
            return realHead.next;
        }

        public bool isNeed(ListNode head, int k)
        {
            while (k > 0)
            {
                if (head == null)
                {
                    return false;
                }
                head = head.next;
                k--;
            }
            return true;
        }
    }
}
