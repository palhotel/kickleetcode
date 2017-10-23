using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kickleetcode.Problems.Algorithm
{
    /// <summary>
    /// Jump Game II
    /// </summary>
    class N45
    {
        public int Jump(int[] nums) {
            int jumps = 0, curEnd = 0, curFarthest = 0;
            for (int i = 0; i < nums.Length - 1; i++) {
                curFarthest = Math.Max(curFarthest, i + nums[i]);
                if (i == curEnd) {
                    jumps++;
                    curEnd = curFarthest;
                }
            }
            return jumps;
        }
    }
}
