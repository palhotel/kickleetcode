using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kickleetcode.Problems.Algorithm
{
    /// <summary>
    /// Add Two Numbers
    /// </summary>
    class N2
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
            //模拟加法
            ListNode p1 = l1, p2 = l2;
            ListNode retList = new ListNode(-1), pRet = retList;
            int nAdd = 0;
            while (p1 != null || p2 != null)
            {
                int num1 = 0, num2 = 0;
                if (p1 != null)
                {
                    num1 = p1.val;
                }
                if (p2 != null)
                {
                    num2 = p2.val;
                }
                int nBit = (num1 + num2);

                nBit += nAdd;
                if (nBit >= 10)
                {
                    nBit = nBit - 10;
                    nAdd = 1;
                }
                else
                {
                    nAdd = 0;
                }

                pRet.next = new ListNode(nBit);
                pRet = pRet.next;

                if (p1 != null && p2 != null)
                {
                    p1 = p1.next;
                    p2 = p2.next;
                } else if (p1 != null)
                {
                    p1 = p1.next;
                }
                else
                {
                    p2 = p2.next;
                }
            }
            if (nAdd == 1)
            {
                pRet.next = new ListNode(1);
                pRet = pRet.next;
            }

            return retList.next;

        }

        public ListNode CreateList(int[] nums)
        {
            ListNode retList = new ListNode(-1), pRet = retList;
            for (int i = 0; i < nums.Length; i++)
            {
                pRet.next = new ListNode(nums[i]);
                pRet = pRet.next;
            }
            return retList.next;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}
