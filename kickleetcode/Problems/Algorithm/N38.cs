using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kickleetcode.Problems.Algorithm
{
    /// <summary>
    /// Count and Say
    /// </summary>
    class N38
    {
        public string CountAndSay(int n)
        {
            if (n < 2)
            {
                return "1";
            }
            else
            {
                string s = "1";

                string temp = "";
                for (int i = 2; i <= n; i++)
                {
                    char last = '0';
                    int lastcount = 0;
                    temp = "";
                    for (int j = 0; j < s.Length; j++)
                    {
                        if (s[j] == last)
                        {
                            lastcount ++;
                        }
                        else
                        {
                            if (j > 0)
                            {
                                temp += lastcount.ToString() + last;
                            }
                            last = s[j];
                            lastcount = 1;
                        }
                    }

                    if (s.Length > 1 && s[s.Length - 1] != s[s.Length - 2])
                    {
                        temp += "1" + s[s.Length - 1];
                    }
                    else
                    {
                        temp += lastcount.ToString() + last;
                    }

                    s = temp;
                }
                return s;
            }
        }
    }
}
