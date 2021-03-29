using System;

namespace ThreeSumClosest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new[] {0,2,1,-3};
            var res = (ThreeSumClosest(num, 1));
            Console.WriteLine(res);
        }

        private static int ThreeSumClosest(int[] nums, int target)
        {
            Array.Sort(nums);
            int dis = Int32.MaxValue;
            int close = 0;
            for (int i = 0; i < nums.Length - 2; i++)
            {
                // 跳过相同的数字
                if(i>0 && nums[i] == nums[i-1])
                    continue;
                int left = i + 1, right = nums.Length - 1;
                while (left < right)
                {
                    var diff = nums[i] + nums[left] + nums[right] - target;
                    // var closest = Math.Min(close, Math.Abs(diff));
                    if (diff == 0)
                    {
                        return target;
                    }
                    if (dis > Math.Abs(diff))
                    {
                        dis = Math.Abs(diff);
                        close = diff + target;
                    }
                    if (diff > 0)
                    {
                        right--;
                    }
                    else
                    {
                        left++;
                    }
                }
            }
            return close;
        }
    }
}