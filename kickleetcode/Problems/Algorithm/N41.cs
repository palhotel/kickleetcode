using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kickleetcode.Problems.Algorithm
{
    /// <summary>
    /// First Missing Positive
    /// </summary>
    class N41
    {
        public int FirstMissingPositive(int[] nums)
        {
            int pos = 0;
            int i = 0;
            for (; i < nums.Length; i++)
            {
                while (nums[i] > 0 && nums[i] != i + 1 && nums[i] <= nums.Length && nums[i] != nums[nums[i] - 1])
                {
                    int temp = nums[i];
                    int k = nums[i] - 1;
                    nums[i] = nums[k];
                    nums[k] = temp;
                }
            }

            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] != j + 1)
                {
                    return j + 1;
                }
            }
            return nums.Length + 1;
        }
    }
}
