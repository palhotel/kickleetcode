using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kickleetcode.Problems.Algorithm
{
    /// <summary>
    /// Roman to Integer
    /// </summary>
    class N13
    {
        /*
         * Ⅰ（1）、X（10）、C（100）、M（1000）、V（5）、L（50）、D（500）
         */
        public int RomanToInt(string s) {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            dic.Add('I', 1);
            dic.Add('V', 5);
            dic.Add('X', 10);
            dic.Add('L', 50);
            dic.Add('C', 100);
            dic.Add('D', 500);
            dic.Add('M', 1000);

            int ret = 0;
            int w = 1000;

            for (int i = 0; i < s.Length && w > 0; i++)
            {
                if (!dic.ContainsKey(s[i]))
                {
                    break;
                }
                int val = dic[s[i]];
                if (val == w)
                {
                    ret += val;
                    
                } else if (val == w/2)
                {
                    ret += val;

                } else if (val == w/10)
                {
                    if (i + 1 < s.Length && (dic[s[i + 1]] == w || dic[s[i + 1]] == w/2))
                    {
                        ret -= val;
                    }
                    else
                    {
                        ret += val;
                    }
                }
                else
                {
                    i--;
                    w = w/10;
                }
            }
            return ret;
        }
    }
}
