using System;
using System.Collections.Generic;

namespace LetterCombinations
{
    class Program
    {
        static void Main(string[] args)
        {
            var res = LetterCombinations("2345");
            foreach (var r in res)
            {
                Console.WriteLine(r);
            }
        }
        private static IList<string> LetterCombinations(string digits)
        {
            IList<string> curr = new List<string>();
            if (digits == "")
                return curr;
            curr.Add("");
            foreach (var d in digits) {
                IList<string> next = new List<string>();
                foreach (var letter in GetLetters(d))
                {
                    foreach (var s in curr)
                    {
                        next.Add(s + letter);
                    }
                }
                curr = next;
            }
            return curr;
        }
        private static char[] GetLetters(char digit)
        {
            switch (digit)
            {
                case '2':
                    return new char[] {'a', 'b', 'c'};
                case '3':
                    return new char[] {'d', 'e', 'f'};
                case '4':
                    return new char[] {'g', 'h', 'i'};
                case '5':
                    return new char[] {'j', 'k', 'l'};
                case '6':
                    return new char[] {'m', 'n', 'o'};
                case '7':
                    return new char[] {'p', 'q', 'r', 's'};
                case '8':
                    return new char[] {'t', 'u', 'v'};
                case '9':
                    return new char[] {'w', 'x', 'y', 'z'};
                default:
                    return new char[0];
            }
        }
    }
}