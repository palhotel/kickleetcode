using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kickleetcode.Problems.Algorithm
{
    class N7
    {
        public int Reverse(int x) {
            if (x == 0) {
                return 0;
            }

            Stack<int> stack = new Stack<int>();
            bool isNeg = x < 0 ? true : false;
            if (isNeg) {
                x = 0 - x;
            }
            while (x > 0) {
                stack.Push(x % 10);
                x = x / 10;
            }
            long ret = 0;
            long i = 1, j = 1;
            while (stack.Count > 0) {
                ret += stack.Pop() * i;
                i = i * 10;
                j ++;
                if (j > 11)
                {
                    break;
                }
            }
            if (isNeg) {
                if (0 - ret < int.MinValue) {
                    return 0;
                } else {
                    return (int)(0 - ret);
                }
            } else {
                if (ret > int.MaxValue) {
                    return 0;
                } else {
                    return (int)ret;
                }
            }

        }
    }
}
