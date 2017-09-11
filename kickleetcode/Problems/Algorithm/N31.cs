using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kickleetcode.Problems.Algorithm
{
    class N31
    {
        public void NextPermutation(int[] nums) {
            if (nums.Length == 1)
            {
                return;
            }
            int n = nums.Length;
            if (nums[n - 1] > nums[n - 2])
            {
                int temp = nums[n - 1];
                nums[n - 1] = nums[n - 2];
                nums[n - 2] = temp;
            }
            else
            {
                int i = n - 1;
                for (; i != 0; i--)
                {
                    if (nums[i] > nums[i - 1])
                    {
                        break;
                    }
                }
                if (i == 0)
                {
                    Array.Sort(nums);
                }
                else
                {
                    Array.Sort(nums, i, nums.Length - i);
                    if (nums[i - 1] < nums[i])
                    {
                        int temp = nums[i - 1];
                        nums[i - 1] = nums[i];
                        nums[i] = temp;
                    }
                    else
                    {
                        int k = i;
                        while (k < nums.Length && nums[k] <= nums[i - 1])
                        {
                            k ++;
                        }
                        int temp = nums[i - 1];
                        nums[i - 1] = nums[k];
                        nums[k] = temp;

                    }
                }

            }
        }
    }
}
