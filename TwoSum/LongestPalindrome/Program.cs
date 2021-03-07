using System;

// 注意：在状态转移方程中，我们是从长度较短的字符串向长度较长的字符串进行转移的，因此一定要注意动态规划的循环顺序。

namespace LongestPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "babad";
            var str = Palindrome(s);
            Console.WriteLine(str);
        }

        private static string Palindrome(string s)
        {
            int n = s.Length;
            char[] Pal = s.ToCharArray();
            bool[,] dp = new bool[n,n];
            string str = "";
            // 注意必须从短到长,从0到n
            for (int k = 0; k < n; k++) {
                for (int i = 0; i+k < n; i++) {
                    int j = i + k;
                    if (k == 0)
                        dp[i, j] = true;
                    else if (k == 1) {
                        dp[i, j] = Pal[i] == Pal[j];
                    }else {
                        dp[i,j] = Pal[i] == Pal[j] && dp[i+1,j-1];
                    }
                    if (dp[i, j] && (k + 1) > str.Length)
                        str = s.Substring(i, k+1);
                }
            }
            return str;
        }
    }
}