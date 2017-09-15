using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kickleetcode.Problems.Algorithm
{
    /// <summary>
    /// Search Insert Position
    /// </summary>
    class N35
    {
        public int SearchInsert(int[] nums, int target)
        {
            int lo = 0, hi = nums.Length - 1;
            int mid = 0;
            while (lo <= hi)
            {
                mid = (lo + hi)/2;
                if (nums[mid] > target)
                {
                    hi = mid - 1;
                }
                else if (nums[mid] < target)
                {
                    lo = mid + 1;
                }
                else
                {
                    return mid;
                }

            }
            return lo;
        }
    }
}
