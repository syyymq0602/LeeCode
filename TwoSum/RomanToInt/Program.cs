using System;
using System.Collections.Generic;

namespace RomanToInt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RomanToInt("LVIII"));
        }

        private static int RomanToInt(string s)
        {
            char[] chars = s.ToCharArray();
            int num = 0;
            int preNum = match(chars[0]);
            for (int i = 1; i < s.Length; i++)
            {
                if (preNum < match(chars[i]))
                {
                    num -= preNum;
                }
                else
                {
                    num += preNum;
                }
                preNum = match(chars[i]);
            }
            num += preNum;
            return num;
        }

        private static int match(char ch)
        {
            switch (ch)
            {
                case 'M': return 1000;
                case 'D': return 500;
                case 'C': return 100;
                case 'L': return 50;
                case 'X': return 10;
                case 'V': return 5;
                case 'I': return 1;
            }
            return 0;
        }
    }
}