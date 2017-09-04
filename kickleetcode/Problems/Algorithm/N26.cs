using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kickleetcode.Problems.Algorithm
{
    /// <summary>
    /// Remove Duplicates from Sorted Array
    /// </summary>
    class N26
    {
        public int RemoveDuplicates(int[] nums)
        {
            int length = nums.Length;
            int last = 1;
            int count = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > nums[i - 1])
                {
                    nums[last++] = nums[i];
                }
                else
                {
                    count ++;
                }
            }
            return length - count;
        }
    }
}
