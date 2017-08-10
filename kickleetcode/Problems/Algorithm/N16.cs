using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kickleetcode.Problems.Algorithm
{
    /// <summary>
    /// 3Sum Closest
    /// </summary>
    class N16
    {
        public int ThreeSumClosest(int[] nums, int target) {
            int min = int.MaxValue;
            int retsum = 0;
            if (nums.Length >= 3) {
                Array.Sort(nums);
                for (int i = 0; i < nums.Length - 2; i++) {
                    if (i == 0 || (i > 0 && nums[i] != nums[i - 1])) {
                        int lo = i + 1, hi = nums.Length - 1;
                        while (lo < hi) {
                            int sum = nums[i] + nums[lo] + nums[hi];
                            int delta = Math.Abs(target - sum);
                            if (delta < min) {
                                min = delta;
                                retsum = nums[i] + nums[lo] + nums[hi];
                                if (target - sum == 0) {
                                    return retsum;
                                }
                                if (target - sum < 0) {
                                    while (lo < hi && nums[hi] == nums[hi - 1]) {
                                        //跳过所有相同的
                                        hi--;
                                    }
                                    hi--;
                                } else {
                                    while (lo < hi && nums[lo] == nums[lo + 1]) {
                                        //跳过所有相同的
                                        lo++;
                                    }
                                    lo++;
                                }
                            } else if (target - sum < 0) {
                                hi--;
                            } else {
                                lo++;
                            }
                        }
                    }
                }
                return retsum;
            } else {
                throw new Exception();
            }
        }
    }
}
