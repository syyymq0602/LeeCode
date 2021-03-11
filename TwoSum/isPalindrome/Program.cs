using System;

namespace isPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome(2332));
        }

        private static bool IsPalindrome(int x)
        {
            var str = x.ToString();
            char[] chars = str.ToCharArray();
            for (int i = 0; i < chars.Length/2; i++)
            {
                var m = chars[i];
                chars[i] = chars[str.Length - 1 - i];
                chars[str.Length - 1 - i] = m;
            }

            string s = new string(chars);
            if (s == str)
                return true;
            return false;
        }
    }
}