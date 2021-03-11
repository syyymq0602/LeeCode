using System;
using System.Collections.Generic;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Reverse(1534236469));
        }

        private static int Reverse(int x)
        {
            int rec = 0;
            while (x != 0)
            {
                int pop = x % 10;
                x /= 10;
                // int.MinValue/10是防止rec * 10溢出
                if (rec < int.MinValue/10 || (rec == int.MinValue / 10 && pop < -8))
                {
                    return 0;
                }
                if (rec > int.MaxValue/10 || (rec == int.MaxValue / 10 && pop > 7))
                {
                    return 0;
                }
                rec = rec * 10 + pop;
            }
            return rec;
        }
        
    }
}