using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kickleetcode.Problems.Algorithm
{
    class N44
    {
        public bool IsMatch(string s, string p) {
            bool[,] arr = new bool[s.Length + 1, p.Length + 1];
            arr[0, 0] = true;
            for (int i = 0; i < p.Length; i++)
            {
                if (p[i] != '*')
                {
                    break;
                }
                else
                {
                    arr[0, i + 1] = true;
                }
            }

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < p.Length; j++)
                {
                    if (p[j] == '*')
                    {
                        arr[i + 1, j + 1] = arr[i, j] || arr[i, j + 1] || arr[i + 1, j];
                    }
                    else
                    {
                        if (p[j] == '?' || s[i] == p[j])
                        {
                            arr[i + 1, j + 1] = arr[i, j];
                        }
                        else
                        {
                            arr[i + 1, j + 1] = false;
                        }
                    }
                }
            }

            return arr[s.Length, p.Length];
        }
    }
}
