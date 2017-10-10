using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kickleetcode.Problems.Algorithm
{
    /// <summary>
    /// Combination Sum
    /// </summary>
    class N39
    {
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            Array.Sort(candidates);
            List<IList<int>> result = new List<IList<int>>();
            getResult(result, candidates, new List<int>(), target, 0);
            return result;
        }

        public void getResult(IList<IList<int>> list, int[] candidates, IList<int> cur, int num, int idx)
        {
            if (num > 0)
            {
                for (int i = idx; i < candidates.Length; i++)
                {
                    if (candidates[i] <= num)
                    {
                        cur.Add(candidates[i]);
                        getResult(list, candidates, cur, num - candidates[i], i);
                    }
                    else
                    {
                        if (cur.Count > 0)
                        {
                            cur.RemoveAt(cur.Count - 1);
                        }
                        return;
                    }
                }

                if (cur.Count > 0) {
                    cur.RemoveAt(cur.Count - 1);
                }
            } else if (num == 0)
            {
                List<int> clone = new List<int>(cur);
                list.Add(clone);
                if (cur.Count > 0)
                {
                    cur.RemoveAt(cur.Count - 1);
                }
            }
        }
    }
}
