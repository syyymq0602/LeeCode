using System;
using System.Collections.Generic;

namespace ThreeSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new[] {0,0,0};
            var res = (ThreeSum(num));
            Console.WriteLine(" ");
        }
        // 定1找2  双指针
        private static IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if(nums == null || nums.Length<3)
                return result;
            // 必须排序后才能用双指针
            Array.Sort(nums);
            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (nums[i] > 0)
                    break;
                // 跳过相同的数字
                if(i>0 && nums[i] == nums[i-1])
                    continue;
                int left = i + 1, right = nums.Length - 1;
                while (left < right) {
                    if (nums[i] + nums[left] + nums[right] == 0) {
                        result.Add(new List<int>() {nums[i], nums[left], nums[right]});
                        left++;
                        right--;
                        // 指针也需要跳过相同的数字
                        while (left < right && nums[left] == nums[left - 1]) left++;
                        while (left < right && nums[right] == nums[right + 1]) right--;
                    }
                    // 双指针移动
                    else if(nums[i] + nums[left] + nums[right] < 0)
                    {
                        left++;
                    }
                    else if(nums[i] + nums[left] + nums[right] > 0)
                    {
                        right--;
                    }
                }
            }

            return result;
        }
    }
}