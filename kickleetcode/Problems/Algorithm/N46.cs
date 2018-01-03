using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kickleetcode.Problems.Algorithm
{
    class N46
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            var lists = new List<IList<int>>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (i > 0)
                {
                    int temp = nums[0];
                    nums[0] = nums[i];
                    nums[i] = temp;
                }
                var list = new List<int>();
                list.Add(nums[0]);
                var newArray = new int[nums.Length];
                Array.Copy(nums, newArray, nums.Length);
                SetList(lists, list, newArray, 1);
            }
            
            return lists;
        }

        public void SetList(IList<IList<int>> lists, List<int> curList, int[] nums, int start)
        {
            if (start >= nums.Length)
            {
                lists.Add(curList);
            }
            else
            {
                for (int i = start; i < nums.Length; i++) {
                    if (i > start) {
                        int temp = nums[start];
                        nums[start] = nums[i];
                        nums[i] = temp;
                    }

                    var list = new List<int>();
                    foreach (var n in curList)
                    {
                        list.Add(n);
                    }
                    list.Add(nums[start]);

                    var newArray = new int[nums.Length];
                    Array.Copy(nums, newArray, nums.Length);
                    SetList(lists, list, newArray, start + 1);
                }
            }
        }
    }
}
