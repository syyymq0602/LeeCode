using System;

namespace MyAtoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MyAtoi("  42ss"));
        }

        private static int MyAtoi(string s)
        {
            char[] chars = s.ToCharArray();
            int index = 0;
            // 去掉空格
            while (index < s.Length && chars[index] == ' ')
            {
                index++;
            }
            if (index == s.Length)
                return 0;
            // 判断正负
            int sign = 1;
            if (chars[index] == '+')
            {
                index++;
            }else if (chars[index] == '-')
            {
                sign = -1;
                index++;
            }
            // 数字转化
            int result = 0;
            while (index <s.Length)
            {
                // 判断是否有效
                if (chars[index] < '0' || chars[index] > '9') {
                    break;
                }
                // 判断是否超出范围
                if (result > int.MaxValue / 10 || result == int.MaxValue / 10 && chars[index] - '0' > int.MaxValue%10)
                {
                    return int.MaxValue;
                }
                if (result < int.MinValue / 10 || result == int.MinValue / 10 && chars[index] - '0' > -(int.MinValue%10))
                {
                    return int.MinValue;
                }
                // 自动转换为数字
                result = result * 10 + sign * (chars[index] - '0');
                index++;
            }
            return result;
        }
    }
}