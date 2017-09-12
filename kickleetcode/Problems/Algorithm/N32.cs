using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kickleetcode.Problems.Algorithm
{
    /// <summary>
    /// Longest Valid Parentheses
    /// </summary>
    class N32
    {
        public int LongestValidParentheses(string s) {
            int maxans = 0;
            Stack<int> stack = new Stack<int>();
            stack.Push(-1);
            for (int i = 0; i < s.Length; i++) {
                if (s[i] == '(') {
                    stack.Push(i);
                } else {
                    stack.Pop();
                    if (stack.Count == 0) {
                        stack.Push(i);
                    } else {
                        maxans = Math.Max(maxans, i - stack.Peek());
                    }
                }
            }
            return maxans;
        }
    }
}
