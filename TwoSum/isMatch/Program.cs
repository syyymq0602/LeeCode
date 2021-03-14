using System;

namespace isMatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isMatch("ab",".*"));
        }
        private static bool isMatch(string s, string p)
        {
            int m = s.Length;
            int n = p.Length;
            bool[,] f = new bool[m+1,n+1];
            f[0, 0] = true;
            for (int i = 0; i < m+1; ++i) {
                for (int j = 1; j < n + 1; ++j) {
                    if (p.ToCharArray()[j-1] == '*') {
                        f[i, j] = f[i, j - 2];
                        if (matches(s, p, i, j - 1)) {
                            f[i, j] = f[i, j] || f[i - 1, j];
                        }
                    }
                    else {
                        if (matches(s, p, i, j)) {
                            f[i, j] = f[i - 1, j - 1];
                        }
                    }
                }
            }
            return f[m, n];
        }
        private static bool matches(string s, string p, int i, int j)
        {
            if (i == 0)
                return false;
            if (p.ToCharArray()[j - 1] == '.')
            {
                return true;
            }
            return s.ToCharArray()[i - 1] == p.ToCharArray()[j - 1];
        }
    }
}