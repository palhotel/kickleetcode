using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kickleetcode.Problems.Algorithm
{
    /// <summary>
    /// 4Sum
    /// </summary>
    class N18
    {
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            List<IList<int>> list = new List<IList<int>>();
            if (nums.Length >= 4)
            {
                Array.Sort(nums);
                for (int i = 0; i <= nums.Length - 4; i++) {
                    if (i == 0 || (i > 0 && nums[i] != nums[i - 1]))
                    {
                        int sum = target - nums[i];
                        var listtemp = ThreeSum(nums, i+1, sum);
                        for (int k = 0; k < listtemp.Count; k++)
                        {
                            list.Add(new int[] { nums[i], listtemp[k][0], listtemp[k][1], listtemp[k][2] });
                        }
                    }
                }
            }

            return list;
        }

        public IList<IList<int>> ThreeSum(int[] nums, int start, int target) {
            List<IList<int>> list = new List<IList<int>>();
            if (nums.Length >= 3) {
                Array.Sort(nums);
                for (int i = start; i < nums.Length - 2; i++) {
                    if (i == start || (i > start && nums[i] != nums[i - 1])) {
                        //第一个数字和前边不一样
                        //0 - 第一个数
                        int lo = i + 1, hi = nums.Length - 1, sum = target - nums[i];
                        while (lo < hi) {
                            if (nums[lo] + nums[hi] == sum) {
                                list.Add(new int[] { nums[i], nums[lo], nums[hi] });
                                while (lo < hi && nums[lo] == nums[lo + 1]) {
                                    //跳过所有相同的
                                    lo++;
                                }
                                while (lo < hi && nums[hi] == nums[hi - 1]) {
                                    //跳过所有相同的
                                    hi--;
                                }
                                lo++; hi--;
                            } else if (nums[lo] + nums[hi] < sum) {
                                lo++;
                            } else {
                                hi--;
                            }
                        }

                    }
                }
            }

            return list;
        }
    }
}
