using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kickleetcode.Problems.Algorithm
{
    /// <summary>
    /// Trapping Rain Water
    /// </summary>
    class N42
    {
        public int Trap(int[] height)
        {
            int result = 0;
            int left = -1, right = -1, temp = 0;
            int i = 0;
            while (i < height.Length && height[i] == 0) {
                i++;
            }
            if (i < height.Length) {
                left = i;
            }
            while (left < height.Length && left >= 0)
            {
                int leftH = height[left];
                while (leftH > 0 && right < 0) {
                    int j = left + 1;
                    for (; j < height.Length; j++) {
                        if (height[j] >= leftH) {
                            right = j;
                            break;
                        }
                    }
                    if (j >= height.Length) {
                        leftH--;
                    }
                }
                if (right >= 0) {
                    for (int j = left + 1; j <= right - 1; j++) {
                        temp += (leftH - height[j]);
                    }
                    result += temp;
                    left = right;
                    right = -1;
                    temp = 0;
                } else {
                    break;
                }
            }
            return result;
        }
    }
}
