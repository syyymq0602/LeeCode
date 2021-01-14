using System;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {2, 7, 11, 15};
            int target = 9;
            int[] res = TwoSum(nums, target);
            Console.WriteLine(res[0]+","+res[1]);
        }
        private static int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        result[0] = i;
                        result[1] = j;
                        break;
                    }
                }
            }
            return result;
        }
    }
}
