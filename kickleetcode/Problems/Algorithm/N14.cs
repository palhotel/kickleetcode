using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kickleetcode.Problems.Algorithm
{
    /// <summary>
    /// Longest Common Prefix
    /// </summary>
    class N14
    {
        public string LongestCommonPrefix(string[] strs)
        {
            int i = 0;
            bool isBreak = true;
            string strRet = "";
            while (true)
            {
                foreach (string s in strs) {
                    if (strs[0].Length <= i || s.Length <= i || strs[0][i] != s[i])
                    {
                        isBreak = true;
                        break;
                    }
                    else
                    {
                        isBreak = false;
                    }
                }
                if (isBreak)
                {
                    break;
                }
                strRet += strs[0][i];
                i ++;
            }
            return strRet;
        }
    }
}
