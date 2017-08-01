using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kickleetcode.Problems.Algorithm
{
    /// <summary>
    /// String to Integer (atoi)
    /// </summary>
    class N8
    {
        public int MyAtoi(string str) {
            str = str.Trim();
            long ret = 0;
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < str.Length && stack.Count < 12; i++) {
                if (i == 0 && str[0] == '-') {
                    stack.Push(-1);
                } else if (i == 0 && str[0] == '+') {
                    stack.Push(0);
                } else if (str[i] >= '0' && str[i] <= '9') {
                    stack.Push(str[i] - '0');
                } else {
                    break;
                }
            }
            long j = 1;
            while (stack.Count > 0) {
                int pop = stack.Pop();
                if (pop == -1) {
                    ret = 0 - ret;
                } else {
                    ret += pop * j;
                    j = j * 10;
                }
            }
            if (ret > int.MaxValue) {
                return int.MaxValue;
            } else if (ret < int.MinValue) {
                return int.MinValue;
            } else {
                return (int)ret;
            }
        }
    }
}
