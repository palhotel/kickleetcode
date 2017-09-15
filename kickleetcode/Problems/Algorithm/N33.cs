using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kickleetcode.Problems.Algorithm
{
    /// <summary>
    /// Search in Rotated Sorted Array
    /// </summary>
    class N33
    {
        public int Search(int[] nums, int target) {
            for (int i = 0; i < nums.Length; i++)
            {
                if (target == nums[i])
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
