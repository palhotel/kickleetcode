using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kickleetcode.Problems.Algorithm
{
    class N9
    {
        public bool IsPalindrome(int x) {
            if (x < 0) {
                return false;
            }
            if (x < int.MaxValue) {
                int tx = x;
                int i = 0;
                while (tx > 0) {
                    tx = tx / 10;
                    i++;
                }
                if (i == 1) {
                    return true;
                } else {
                    int j = 0;
                    while (j < i / 2) {
                        if (x / (long)Math.Pow(10, i - j - 1) % 10 == x % (long)Math.Pow(10, j + 1) / (long)Math.Pow(10, j)) {
                            j++;
                        } else {
                            return false;
                        }
                    }
                    return true;
                }
            }
            return false;
        }
    }
}
