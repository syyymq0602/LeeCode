using System;

namespace NthUglyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var res = NthUglyNumberNew(445);
            Console.WriteLine(res.ToString());
        }
        
        //  使用三指针解法
        private static int NthUglyNumberNew(int n)
        {
            int[] dp = new int[n + 1];
            dp[1] = 1;
            int p2 = 1, p3 = 1, p5 = 1;
            for (int i = 2; i <= n; i++)
            {
                int num2 = dp[p2] * 2, num3 = dp[p3] * 3, num5 = dp[p5] * 5;
                dp[i] = Math.Min(Math.Min(num2, num3), num5);
                if (dp[i] == num2) p2++;
                if (dp[i] == num3) p3++;
                if (dp[i] == num5) p5++;
            }
            return dp[n];
        }
        
        //  暴力解法超时！！！！
        private static int NthUglyNumber(int n)
        {
            int i = 0;
            int num = 0;
            while (true)
            {
                if (IsUgly(i))
                {
                    num++;
                    if (num == n)
                        break;
                }
                i++;
            }
            return i;
        }
        private static bool IsUgly(int n)
        {
            if (n <= 0)
                return false;
            int[] nums = new[] {2, 3, 5};
            for (int i = 0; i < nums.Length; i++)
            {
                while (n%nums[i] == 0)
                {
                    n /= nums[i];
                }
            }
            return n == 1;
        }
    }
}