using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kickleetcode.Problems.Algorithm
{
    /// <summary>
    /// Container With Most Water
    /// </summary>
    class N11
    {
        public int MaxArea(int[] height) {
            int left = 0, right = height.Length - 1;
            int maxArea = 0;

            while (left < right) {
                maxArea = Math.Max(maxArea, Math.Min(height[left], height[right])
                        * (right - left));
                if (height[left] < height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
                    
            }

            return maxArea;
        }
    }
}
