using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kickleetcode.Problems.Algorithm
{
    /// <summary>
    /// Merge k Sorted Lists
    /// </summary>
    class N23
    {
        public ListNode MergeKLists(ListNode[] lists)
        {
            ListNode head = new ListNode(-1);
            ListNode p = head;
            int n = 1;
            while (n != 0)
            {
                int min = int.MaxValue;
                int minNode = -1;
                n = 0;
                for (int i = 0; i < lists.Length; i++)
                {
                    if (lists[i] != null)
                    {
                        if (lists[i].val < min)
                        {
                            min = lists[i].val;
                            minNode = i;
                        }
                        n++;
                        
                    }
                }

                if (p != null && minNode >= 0)
                {
                    p.next = lists[minNode];
                    lists[minNode] = lists[minNode].next;
                    p = p.next;
                }
            }
            return head.next;
        }
    }
}
