using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kickleetcode.Problems.Algorithm
{
    /// <summary>
    /// Tow Sum
    /// </summary>
    class N1
    {
        public int[] TwoSum(int[] nums, int target) {
            if (nums.Length < 2) {
                return new int[] { };
            }

            for (int i = 0; i < nums.Length - 1; i++) {
                for (int j = i + 1; j < nums.Length; j++) {
                    if (nums[i] + nums[j] == target) {
                        return new int[] { i, j };
                    }
                }
            }
            return new int[] { };
        }
    }
}
