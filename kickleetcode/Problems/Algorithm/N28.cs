using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kickleetcode.Problems.Algorithm
{
    /// <summary>
    /// Implement strStr()
    /// </summary>
    class N28
    {
        public int StrStr(string haystack, string needle)
        {
            if (haystack.Length == needle.Length && needle.Length == 0)
            {
                return 0;
            }
            int i = -1;
            int k = needle.Length;
            for (int j = 0; j < haystack.Length; j ++)
            {
                if (haystack.Length - k - j >= 0)
                {
                    if (haystack.Substring(j, k) == needle)
                    {
                        i = j;
                        break;
                    }
                }
                else
                {
                    break;
                }
            }
            return i;
        }
    }
}
