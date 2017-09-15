using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kickleetcode.Problems.Algorithm
{
    /// <summary>
    /// Search for a Range
    /// </summary>
    class N34
    {
        public int[] SearchRange(int[] nums, int target)
        {
            int lo = 0, hi = nums.Length - 1;
            while (lo < hi && nums[lo] != nums[hi])
            {
                int mid = (lo + hi) / 2;
                if (nums[lo] == target)
                {
                    mid = lo;
                } else if (nums[hi] == target)
                {
                    mid = hi;
                }
                
                if (nums[mid] > target)
                {
                    hi = mid - 1;
                } else if (nums[mid] < target)
                {
                    lo = mid + 1;
                }
                else
                {
                    lo = mid;
                    hi = mid;
                    while (lo > 1 && nums[lo - 1] == target)
                    {
                        lo --;
                    }
                    while (hi + 1 < nums.Length && nums[hi + 1] == target)
                    {
                        hi ++;
                    }
                    break;
                }
            }
            if (lo > hi || nums[lo] != target)
            {
                lo = -1;
                hi = -1;
            }
            return new int[] {lo, hi};
        }
    }
}
