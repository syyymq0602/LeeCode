using System;

namespace LengthOfLongestSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "asdfasdfs";
            var str = CheckRepeated(s);
            Console.WriteLine(str);
        }

        private static int CheckRepeated(string s)
        {
            int maxNum = 0 , index = 0;
            char[] chars = s.ToCharArray();
            for (int i = 0; i < chars.Length; i++) {
                int j = s.IndexOf(chars[i], index);
                if(j!=i){
                    index = j+1;
                }
                maxNum = Math.Max(maxNum,i-index+1);
            }
            return maxNum;
        }
    }
}