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
            if (x < 0)
                return false;
            int rem = 0, y = 0;
            int quo = x;
            while(quo!=0){
                rem = quo % 10;
                y = y * 10 + rem;
                quo = quo / 10;
            }
            return y == x;
        }
    }
}