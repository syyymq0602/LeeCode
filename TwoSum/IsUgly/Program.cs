﻿using System;

namespace IsUgly
{
    class Program
    {
        // 0和负整数不算是丑数
        static void Main(string[] args)
        {
            int num = 0;
            var res = IsUgly(num);
            Console.WriteLine(res.ToString());
        }
        private static bool IsUgly(int n)
        {
            bool result = false;
            if (n == 0)
                return false;
            int[] nums = new[] {2, 3, 5};
            for (int i = 0; i < nums.Length; i++)
            {
                while (n%nums[i] == 0)
                {
                    n /= nums[i];
                }
                if (n == 1)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }
    }
}