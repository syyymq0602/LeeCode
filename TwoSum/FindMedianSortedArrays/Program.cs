using System;

namespace FindMedianSortedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = new int[]{1,2};
            int[] nums2 = new int[] {3,4};
            var dou = FindArray(nums1, nums2);
            Console.WriteLine(dou);
        }

        private static double FindArray(int[] nums1, int[] nums2)
        {
            int Len1 = nums1.Length;
            int Len2 = nums2.Length;
            double mid;
            int[] res = new int[Len1+Len2];
            nums1.CopyTo(res,0);
            nums2.CopyTo(res,Len1);
            Array.Sort(res);
            if ((Len1 + Len2) % 2 == 0)
            {
                mid = Convert.ToDouble(res[(Len1 + Len2) / 2] + res[(Len1 + Len2) / 2 - 1]) / 2;
            }
            else
            {
                mid = Convert.ToDouble(res[(Len1 + Len2 - 1) / 2]);
            }
            return mid;
        }
    }
}