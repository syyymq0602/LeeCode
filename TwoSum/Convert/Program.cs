using System;
using System.Linq;

namespace Convert
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "PAYPALISHIRING";
            Console.WriteLine(Convert(str,3));
        }

        private static string Convert(string s, int numRows)
        {
            char[][] chars = new char[numRows][];
            char[] str = s.ToCharArray();
            int j = -1;
            for (int i = 0; i < s.Length; i++)
            {
                if (j == 0 || j == 4)
                    j = -j;
            }
            return "s";
        }
    }
}