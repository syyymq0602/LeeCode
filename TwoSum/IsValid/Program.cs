using System;
using System.Collections.Generic;
using System.Linq;

namespace IsValid
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "()[]{}(]";
            var res = IsValid(s);
            Console.WriteLine(res.ToString());
        }
        // 字典 栈 的使用！！！
        public static bool IsValid(string s)
        {
            int len = s.Length;
            if (len % 2 == 1)
                return false;
            Dictionary<char,char> map = new Dictionary<char, char>
            {
                { '}', '{' },
                { ']', '[' },
                { ')', '(' }
            };
            var chars = s.ToCharArray();
            var stack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                var c = chars[i];
                if (map.ContainsKey(c))
                {
                    var top = stack.Any() ? stack.Pop() : '#';
                    if (top != map[c])
                    {
                        return false;
                    }
                }
                else
                {
                    stack.Push(c);
                }
            }
            return !stack.Any();
        }
    }
}