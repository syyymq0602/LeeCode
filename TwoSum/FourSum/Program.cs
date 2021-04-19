using System;
using System.Collections.Generic;

namespace FourSum
{
    class Program
    {
        // 参照 ThreeSum
        static void Main(string[] args)
        {
            int[] nums = new int[]{1,0,-1,0,-2,2};
            int target = 0;
            string s = "ss";
            s.ToCharArray();
            var result = FourSum(nums, target);
            Console.WriteLine("Hello World!");
        }

        private static IList<IList<int>> FourSum(int[] nums, int target)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if(nums == null || nums.Length<4)
                return result;
            Array.Sort(nums);
            int len = nums.Length;
            // 剪枝操作
            for (int i = 0; i < len - 3; i++)
            {
                if(i > 0 && nums[i] == nums[i-1])
                    continue;
                if (nums[i] + nums[i + 1] + nums[i + 2] + nums[i + 3] > target)
                    break;
                if(nums[i] + nums[len-3] + nums[len-2] + nums[len-1] < target)
                    continue;
                // 剪枝操作
                for (int j = i + 1; j < len - 2; j++)
                {
                    if(j>i+1 && nums[j]==nums[j-1])
                        continue;
                    if (nums[i] + nums[j] + nums[j + 1] + nums[j + 2] > target)
                        break;
                    if(nums[i] + nums[j] + nums[len-2] + nums[len-1] < target)
                        continue;
                    int left = j + 1, right = len - 1;
                    while (left < right)
                    {
                        int sum = nums[i] + nums[j] + nums[left] + nums[right];
                        if (sum == target)
                        {
                            result.Add(new List<int>(){nums[i], nums[j],nums[left],nums[right]});
                            while (left < right && nums[left] == nums[left + 1])
                            {
                                left++;
                            }
                            left++;
                            while (left < right && nums[right] == nums[right - 1])
                            {
                                right--;
                            }
                            right--;
                        }
                        else if(sum<target)
                        {
                            left++;
                        }
                        else
                        {
                            right--;
                        }
                    }
                }
            }
            return result;
        }
    }
}