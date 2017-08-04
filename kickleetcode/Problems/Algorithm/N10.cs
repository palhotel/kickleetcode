using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kickleetcode.Problems.Algorithm
{
    /// <summary>
    /// Regular Expression Matching
    /// </summary>
    class N10
    {
        /// <summary>
        /// 动态规划
        /// </summary>
        public bool IsMatch(string s, string p)
        {
            if (string.IsNullOrEmpty(s) && string.IsNullOrEmpty(p))
            {
                return true;
            }

            bool[,] arr = new bool[s.Length + 1, p.Length + 1];
            for (int i = 0; i < s.Length + 1; i++)
            {
                for (int j = 0; j < p.Length + 1; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        arr[i, j] = true;
                    }
                    else if (j - 1 >= 0 && p[j - 1] == '*' && j - 2 >= 0)
                    {
                        arr[0, j] = arr[0, j - 2];
                    }
                    else
                    {
                        arr[i, j] = false;
                    }
                }
            }

            for (int i = 1; i < s.Length + 1; i++)
            {
                for (int j = 1; j < p.Length + 1; j++)
                {
                    if (p[j - 1] == '*')
                    {
                        if (j - 2 >= 0 && (s[i - 1] == p[j - 2] || p[j - 2] == '.'))
                        {
                            //选择匹配一个或者0个
                            arr[i, j] = arr[i - 1, j] || arr[i, j - 2];
                        }
                        else if(j - 2 >= 0)
                        {
                            arr[i, j] = arr[i, j - 2];
                        }
                    } else if (s[i - 1] == p[j - 1] || p[j - 1] == '.')
                    {
                        arr[i, j] = arr[i - 1, j - 1];
                    }
                }
            }


            return arr[s.Length, p.Length];
        }
    }
}
