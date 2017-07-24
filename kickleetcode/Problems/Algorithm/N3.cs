using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kickleetcode.Problems.Algorithm
{
    /// <summary>
    /// Longest Substring Without Repeating Characters
    /// </summary>
    class N3
    {
        public int LengthOfLongestSubstring(string s)
        {
            if (s.Length <= 0)
            {
                return 0;
            }
            HashSet<char> set = new HashSet<char>();
            int left = -1, right = -1;
            int maxLen = 1;
            int maxL, maxR;
            int i = 0;
            bool isNew = true;
            while (i < s.Length)
            {
                if (isNew)
                {
                    set.Clear();
                    left = i;
                    right = i;
                    isNew = false;
                }

                if (!set.Contains(s[i]))
                {
                    set.Add(s[i]);
                    right = i;
                    i++;
                }
                else
                {
                    if (maxLen < right - left + 1)
                    {
                        maxLen = right - left + 1;
                        maxL = left;
                        maxR = right;
                    }
                    i = left + 1;
                    isNew = true;
                }
            }

            if (isNew == false)
            {
                if (maxLen < right - left + 1) {
                    maxLen = right - left + 1;
                    maxL = left;
                    maxR = right;
                }
            }

            return maxLen;
        }

        /// <summary>
        /// 一个更好的方法
        /// </summary>
        public int LengthOfLongestSubstringBetter(string s)
        {
            int n = s.Length;
            HashSet<char> set = new HashSet<char>();
            int maxLen = 0, left = 0, right = 0;
            while (left < s.Length && right < s.Length)
            {
                if (!set.Contains(s[right]))
                {
                    set.Add(s[right]);
                    maxLen = Math.Max(maxLen, right - left + 1);
                    right ++;
                }
                else
                {
                    set.Remove(s[left]);
                    left ++;
                }
            }

            return maxLen;
        }
    }
}
