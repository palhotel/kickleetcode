using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kickleetcode.Problems.Algorithm
{
    /// <summary>
    /// Remove Nth Node From End of List
    /// </summary>
    class N19
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n) {
            if (n == 0) {
                return head;
            }
            ListNode p1 = head;
            ListNode p2 = p1;
            while (n > 0) {
                p2 = p2.next;
                n--;
                if (p2 == null) {
                    break;
                }
            }
            if (p2 == null && n == 0) {
                return p1.next;
            }
            while (p2.next != null) {
                p1 = p1.next;
                p2 = p2.next;
            }

            if (p1.next == null) {
                return null;
            } else {
                p1.next = p1.next.next;
            }

            return head;
        }
    }
}
