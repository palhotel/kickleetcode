using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kickleetcode.Problems.Algorithm
{
    /// <summary>
    /// Median of Two Sorted Arrays
    /// </summary>
    class N4
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] nums = new int[nums1.Length + nums2.Length];
            int i = 0, j = 0, k = 0;
            while (k < nums.Length) {
                if (i < nums1.Length && j < nums2.Length) {
                    if (nums1[i] < nums2[j]) {
                        nums[k] = nums1[i];
                        i++;
                    } else {
                        nums[k] = nums2[j];
                        j++;
                    }
                } else if (i >= nums1.Length) {
                    nums[k] = nums2[j];
                    j++;
                } else if (j >= nums2.Length) {
                    nums[k] = nums1[i];
                    i++;
                }
                k++;
            }
            if (nums.Length%2 == 0)
            {
                return Math.Round((nums[nums.Length/2 - 1] + nums[nums.Length/2])/2.0, 1);
            }
            else
            {
                return Math.Round(nums[nums.Length/2] + 0.0, 1);
            }
        }
    }
}
