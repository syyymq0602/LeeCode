# LeeCode
Codes for algorithm

### 两数之和（TwoSum）
给定一个整数数组 nums 和一个整数目标值 target，请你在该数组中找出 和为目标值 的那 两个 整数，并返回它们的数组下标。<br>
例：
    输入：nums = [2,7,11,15], target = 9
    输出：[0,1]

### 两数相加（addTwoNumbers）
给你两个 非空 的链表，表示两个非负的整数。它们每位数字都是按照 逆序 的方式存储的，并且每个节点只能存储 一位 数字。<br>
请你将两个数相加，并以相同形式返回一个表示和的链表。
输入：l1 = [2,4,3], l2 = [5,6,4]
输出：[7,0,8]
解释：342 + 465 = 807.

### 无重复字符的最长子串（LengthOfLongestSubstring）
给定一个字符串，请你找出其中不含有重复字符的 最长子串 的长度。<br>
输入: s = "abcabcbb"
输出: 3 
解释: 因为无重复字符的最长子串是 "abc"，所以其长度为 3。

### 寻找两个正序数组的中位数（FindMedianSortedArrays）
给定两个大小分别为 `m` 和 `n` 的正序（从小到大）数组 `nums1` 和 `nums2`。请你找出并返回这两个正序数组的 中位数 。<br>
输入：nums1 = [1,3], nums2 = [2]
输出：2.00000
解释：合并数组 = [1,2,3] ，中位数 2

### 最长回文子串（LongestPalindrome）
给你一个字符串 s，找到 s 中最长的回文子串。<br>
输入：s = "babad"
输出："bab"
解释："aba" 同样是符合题意的答案。

### Z 字形变换（Convert）
将一个给定字符串 s 根据给定的行数 numRows ，以从上往下、从左到右进行 Z 字形排列。<br>
比如输入字符串为 "PAYPALISHIRING" 行数为 3 时，排列如下：<br>
```
P   A   H   N
A P L S I I G
Y   I   R
```
之后，你的输出需要从左往右逐行读取，产生出一个新的字符串，比如："PAHNAPLSIIGYIR"。<br>
```
输入：s = "PAYPALISHIRING", numRows = 3
输出："PAHNAPLSIIGYIR"
```