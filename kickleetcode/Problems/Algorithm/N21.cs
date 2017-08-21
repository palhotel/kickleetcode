using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kickleetcode.Problems.Algorithm
{
    /// <summary>
    /// Merge Two Sorted Lists
    /// </summary>
    class N21
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
            ListNode p = new ListNode(-1);
            ListNode q = p;
            while (l1 != null || l2 != null) {
                if (l1 == null) {
                    q.next = l2;
                    break;
                } else if (l2 == null) {
                    q.next = l1;
                    break;
                } else {
                    if (l1.val < l2.val) {
                        q.next = l1;
                        q = q.next;
                        l1 = l1.next;
                    } else {
                        q.next = l2;
                        q = q.next;
                        l2 = l2.next;
                    }
                }
            }
            return p.next;
        }
    }
}
