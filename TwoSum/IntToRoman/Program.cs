using System;
using System.Collections.Generic;

namespace IntToRoman
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IntToRoman(1999));
        }
        // 贪心算法
        private static string IntToRoman(int number)
        {
            List<string> str= new List<string>(){"M","CM","D","CD","C","XC","L","XL","X","IX","V","IV","I"};
            List<int> val = new List<int>(){1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1};
            string res = string.Empty;
            for (int i = 0; i < val.Count; i++)
            {
                while (number >= val[i])
                {
                    number -= val[i];
                    res += str[i];
                }
            }

            return res;
        }
    }
}