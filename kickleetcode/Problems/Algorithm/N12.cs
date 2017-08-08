using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kickleetcode.Problems.Algorithm
{
    /// <summary>
    /// Integer to Roman
    /// </summary>
    class N12
    {
        /*
         * Ⅰ（1）、X（10）、C（100）、M（1000）、V（5）、L（50）、D（500）
         */
        public string IntToRoman(int num) {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "I");
            dic.Add(5, "V");
            dic.Add(10, "X");
            dic.Add(50, "L");
            dic.Add(100, "C");
            dic.Add(500, "D");
            dic.Add(1000, "M");
            string str = "";
            int temp = 1000;
            while (num > 0 && temp > 0) {
                if (num >= temp)
                {
                    int m = num / temp;

                    if (m >= 5 && m < 9) {
                        str += dic[5 * temp];
                        m -= 5;
                    } else if (m == 9) {
                        str += dic[temp] + dic[10 * temp];
                        m -= 9;
                    } else if (m == 4) {
                        str += dic[temp] + dic[5 * temp];
                        m -= 4;
                    }

                    while (m-- > 0) {
                        str += dic[temp];
                    }
                    num -= num / temp * temp;
                }
                
                temp = temp/10;
            }

            return str;
        }
    }
}
