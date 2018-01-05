using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kickleetcode.Problems.Algorithm
{
    class N47
    {

        public IList<IList<int>> PermuteUnique(int[] nums) {
            var lists = new List<IList<int>>();
            if (nums == null || nums.Length == 0) {
                return lists;
            }
            permute(lists, nums, 0);
            return lists;
        }

        private void permute(IList<IList<int>> lists, int[] nums, int index) {
            if (index == nums.Length) {
                var list = new List<int>();
                foreach (var n in nums) {
                    list.Add(n);
                }
                lists.Add(list);
                return;
            }

            HashSet<int> appeared = new HashSet<int>();

            for (int i = index; i < nums.Length; ++i) {
                if (appeared.Add(nums[i])) {
                    swap(nums, index, i);
                    permute(lists, nums, index + 1);
                    swap(nums, index, i);
                }
            }
        }

        private void swap(int[] nums, int i, int j) {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }

    }
}
