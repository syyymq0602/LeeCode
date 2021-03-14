# LeeCode
Codes for algorithm

### 1. 两数之和（TwoSum）
给定一个整数数组 nums 和一个整数目标值 target，请你在该数组中找出 和为目标值 的那 两个 整数，并返回它们的数组下标。<br>
```
输入：nums = [2,7,11,15], target = 9
输出：[0,1]
```

### 2. 两数相加（addTwoNumbers）
给你两个 非空 的链表，表示两个非负的整数。它们每位数字都是按照 逆序 的方式存储的，并且每个节点只能存储 一位 数字。<br>
请你将两个数相加，并以相同形式返回一个表示和的链表。
```
输入：l1 = [2,4,3], l2 = [5,6,4]
输出：[7,0,8]
解释：342 + 465 = 807.
```

### 3. 无重复字符的最长子串（LengthOfLongestSubstring）
给定一个字符串，请你找出其中不含有重复字符的 最长子串 的长度。<br>
```
输入: s = "abcabcbb"
输出: 3 
解释: 因为无重复字符的最长子串是 "abc"，所以其长度为 3。
```

### 4. 寻找两个正序数组的中位数（FindMedianSortedArrays）
给定两个大小分别为 `m` 和 `n` 的正序（从小到大）数组 `nums1` 和 `nums2`。请你找出并返回这两个正序数组的 中位数 。<br>
```
输入：nums1 = [1,3], nums2 = [2]
输出：2.00000
解释：合并数组 = [1,2,3] ，中位数 2
```

### 5. 最长回文子串（LongestPalindrome）
给你一个字符串 s，找到 s 中最长的回文子串。<br>
```
输入：s = "babad"
输出："bab"
解释："aba" 同样是符合题意的答案。
```

### 6. Z 字形变换（Convert）
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
### 7. 整数反转（Reverse）
给你一个 32 位的有符号整数 x ，返回将 x 中的数字部分反转后的结果。<br>
如果反转后整数超过 32 位的有符号整数的范围 [−231,  231 − 1] ，就返回 0。<br>
```
输入：x = 123
输出：321
```

### 8. 回文数（IsPalindrome）
给你一个整数 x ，如果 x 是一个回文整数，返回 true ；否则，返回 false 。<br>
回文数是指正序（从左向右）和倒序（从右向左）读都是一样的整数。例如，121 是回文，而 123 不是。<br>
```
输入：x = -121
输出：false
解释：从左向右读, 为 -121 。
```

### 9. 字符串转换整数 (MyAtoi)
请你来实现一个 myAtoi(string s) 函数，使其能将字符串转换成一个 32 位有符号整数（类似 C/C++ 中的 atoi 函数）。<br>
```
输入：s = "4193 with words"
输出：4193
解释：
第 1 步："4193 with words"（当前没有读入字符，因为没有前导空格）
         ^
第 2 步："4193 with words"（当前没有读入字符，因为这里不存在 '-' 或者 '+'）
         ^
第 3 步："4193 with words"（读入 "4193"；由于下一个字符不是一个数字，所以读入停止）
             ^
解析得到整数 4193 。
由于 "4193" 在范围 [-231, 231 - 1] 内，最终结果为 4193 。
```

### 10. 正则表达式匹配（isMatch）（difficult）
给你一个字符串 s 和一个字符规律 p，请你来实现一个支持 '.' 和 '*' 的正则表达式匹配。<br>
    + '.' 匹配任意单个字符
    + '*' 匹配零个或多个前面的那一个元素
所谓匹配，是要涵盖 整个 字符串 s的，而不是部分字符串。<br>
```
输入：s = "aab" p = "c*a*b"
输出：true
解释：因为 '*' 表示零个或多个，这里 'c' 为 0 个, 'a' 被重复一次。因此可以匹配字符串 "aab"。
```

### 32. 最长有效括号（LongestValidParentheses）
给你一个只包含 '(' 和 ')' 的字符串，找出最长有效（格式正确且连续）括号子串的长度。<br>
```
输入：s = ")(()())"
输出：6
解释：最长有效括号子串是 "(()())"
```