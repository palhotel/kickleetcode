using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kickleetcode.Problems.Algorithm
{
    /// <summary>
    /// Letter Combinations of a Phone Number
    /// </summary>
    class N17
    {
        public IList<string> LetterCombinations(string digits)
        {
            string[] keyboard =
            {
                " ",
                "!",
                "abc",
                "def",
                "ghi",
                "jkl",
                "mno",
                "pqrs",
                "tuv",
                "wxyz"
            };
            List<string> list = new List<string>();

            string outstr = "";
            Output(digits, outstr, list, keyboard, 0);
            return list;
        }

        public void Output(string src, string dest, List<string> list, string[] keyboard, int cur)
        {
            if (src.Length - 1 < cur)
            {
                if (!string.IsNullOrEmpty(dest))
                {
                    list.Add(dest);
                }
                dest = "";
                return;
            }
            int nCur = src[cur] - '0';
            string newdest = dest;
            for (int i = 0; i < keyboard[nCur].Length; i++)
            {
                dest = newdest + keyboard[nCur][i];
                Output(src, dest, list, keyboard, cur + 1);
            }
        }
    }
}
