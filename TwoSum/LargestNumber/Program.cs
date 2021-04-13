using System;
using System.Text;

namespace LargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new[] {3,30,34,5,9,46};
            var s = LargestNumber(nums);
            Console.WriteLine(s);
        }
        private static string LargestNumber(int[] nums)
        {
            string[] strs = new string[nums.Length];
            StringBuilder temp = new StringBuilder();
            string result = "";
            for (int i = 0; i < nums.Length; i++)
            {
                strs[i] = nums[i].ToString();
            }
            // 拼接比大小，运用到了委托
            Array.Sort(strs, delegate(string strs1, string strs2)
            {
                string str1 = strs1 + strs2;
                string str2 = strs2 + strs1;
                return str2.CompareTo(str1);
            });
            for (int i = 0; i < strs.Length; i++)
            {
                temp.Append(strs[i]);
            }
            // 首位排0
            while ('0' == temp.ToString()[0])
            {
                temp.Remove(0, 1);
                if (0 == temp.Length)
                {
                    return "0";
                }
            }
            result = temp.ToString();
            return result;
        }
    }
}