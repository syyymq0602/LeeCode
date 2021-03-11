using System;
using System.Linq;

namespace Convert
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "ABC";
            Console.WriteLine(Convert(str,1));
        }

        private static string Convert(string s, int numRows)
        {
            if (s.Length <= 1 || numRows == 1)
                return s;
            // 头尾常规字符间的距离
            int step = 2 * numRows - 2;
            int index = 0;
            int n = s.Length;
            int add = 0;
            string ret = "";
            for(int i=0;i<numRows;i++)
            {
                // 每行字符索引值
                index = i;
                // 中间字符之间的距离
                add = 2 * i;
                while(index < n)
                {
                    ret += s[index];
                    add = step - add;
                    if(i==0 || i ==numRows-1)
                    {
                        index += step;
                    }
                    else
                    {
                        index += add;
                    }
                }
            }
            return ret;
        }
    }
}