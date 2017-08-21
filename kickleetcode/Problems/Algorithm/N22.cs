using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kickleetcode.Problems.Algorithm
{
    /// <summary>
    /// Generate Parentheses
    /// </summary>
    class N22
    {
        public IList<string> GenerateParenthesis(int n) {
            List<String> list = new List<String>();
            //
            generateOneByOne("", list, n, n);
            return list;
        }
        public void generateOneByOne(String sublist, List<String> list, int left, int right) {
            if (left > right) {
                return;
            }
            if (left > 0) {
                generateOneByOne(sublist + "(", list, left - 1, right);
            }
            if (right > 0) {
                generateOneByOne(sublist + ")", list, left, right - 1);
            }
            if (left == 0 && right == 0) {
                //匹配完毕
                list.Add(sublist);
                return;
            }
        }
    }
}
