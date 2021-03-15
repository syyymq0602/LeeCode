using System;

namespace MaxArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = {4,6,4};
            Console.WriteLine(MaxArea(num));
        }
        // 双指针
        private static int MaxArea(int[] height)
        {
            int left = 0, right = height.Length - 1;
            int maxarea = 0;
            while (left < right)
            {
                int min = Math.Min(height[left], height[right]);
                maxarea = Math.Max(min * (right - left), maxarea);
                if (height[left] <= height[right])
                {
                    ++left;
                }
                else
                {
                    --right;
                }
            }

            return maxarea;
        }
    }
}