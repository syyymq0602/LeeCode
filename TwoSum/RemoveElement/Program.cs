using System;

namespace RemoveElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {3, 2, 2, 3};
            int val = 3;
            var num = RemoveElement(nums, val);
            Console.WriteLine(num);
        }
        // 双指针
        private static int RemoveElement(int[] nums, int val)
        {
            int len = nums.Length;
            int left = 0;
            for (int right = 0; right < len; right++)
            {
                if (nums[right] != val)
                {
                    nums[left] = nums[right];
                    left++;
                }
            }
            return left;
        }
    }
}