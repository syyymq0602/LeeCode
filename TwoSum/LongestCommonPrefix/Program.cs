using System;

namespace LongestCommonPrefix
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strs = {"flowere","flowe","floweeight"};
            Console.WriteLine(LongestCommonPrefix(strs));
        }

        private static string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0)
                return "";
            string result = strs[0];
            for (int i = 1; i < strs.Length; i++)
            {
                int j = 0;
                for (; j < result.Length && j < strs[i].Length; j++)
                {
                    if(result[j] != strs[i][j])
                        break;
                }
                result = result.Substring(0, j);
                if (result.Equals(""))
                    return result;
            }
            return result;
        }
    }
}