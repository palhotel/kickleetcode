using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kickleetcode.Problems.Algorithm
{
    /// <summary>
    /// Longest Palindromic Substring
    /// </summary>
    class N5
    {
        public string LongestPalindrome(string s) {
            if (s.Length == 1) {
                return s;
            } else if (s.Length == 2 && s[0] == s[1]) {
                return s;
            }

            //奇数
            int center = 1, len = 1;
            int maxCenter = 1, maxLen = 0;
            //偶数
            int evenLen = 1;
            int maxEvenCenter = 1, maxEvenLen = -1;
            if (s[0] == s[1]) {
                maxEvenCenter = 0;
                maxEvenLen = 1;
            }
            for (; center < s.Length; center++) {
                len = 1;
                evenLen = 1;
                while (center - len >= 0 && center + len < s.Length && s[center - len] == s[center + len]) {
                    if (len > maxLen) {
                        maxLen = len;
                        maxCenter = center;
                    }
                    len++;
                }
                while (center - evenLen + 1 >= 0 && center + evenLen < s.Length &&
                       s[center - evenLen + 1] == s[center + evenLen]) {
                    if (evenLen > maxEvenLen) {
                        maxEvenLen = evenLen;
                        maxEvenCenter = center;
                    }
                    evenLen++;
                }
            }

            if (maxLen == 0 && maxEvenLen == -1) {
                return s.Substring(0, 1);
            } else {
                if (2 * maxLen + 1 > 2 * maxEvenLen) {
                    return s.Substring(maxCenter - maxLen, maxLen + maxLen + 1);
                } else {
                    return s.Substring(maxEvenCenter - maxEvenLen + 1, 2 * maxEvenLen);
                }

            }
        }
    }
}
