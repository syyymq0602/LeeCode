# LeetCode
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

### 11. 盛最多水的容器（MaxArea）
给你 n 个非负整数 a1，a2，...，an，每个数代表坐标中的一个点 (i, ai) 。在坐标内画 n 条垂直线，垂直线 i 的两个端点分别为 (i, ai) 和 (i, 0) 。找出其中的两条线，使得它们与 x 轴共同构成的容器可以容纳最多的水。<br>
```
输入：[1,8,6,2,5,4,8,3,7]
输出：49 
解释：图中垂直线代表输入数组 [1,8,6,2,5,4,8,3,7]。在此情况下，容器能够容纳水（表示为蓝色部分）的最大值为 49。
```

### 12. 整数转罗马数字(IntToRoman)
罗马数字包含以下七种字符： I， V， X， L，C，D 和 M。<br>
```
字符          数值
I             1
V             5
X             10
L             50
C             100
D             500
M             1000
```
例如， 罗马数字 2 写做 II ，即为两个并列的 1。12 写做 XII ，即为 X + II 。 27 写做  XXVII, 即为 XX + V + II 。<br>
通常情况下，罗马数字中小的数字在大的数字的右边。但也存在特例，例如 4 不写做 IIII，而是 IV。数字 1 在数字 5 的左边，所表示的数等于大数 5 减小数 1 得到的数值 4 。同样地，数字 9 表示为 IX。这个特殊的规则只适用于以下六种情况：<br>
    + I 可以放在 V (5) 和 X (10) 的左边，来表示 4 和 9。
    + X 可以放在 L (50) 和 C (100) 的左边，来表示 40 和 90。
    + C 可以放在 D (500) 和 M (1000) 的左边，来表示 400 和 900。
给定一个整数，将其转为罗马数字。输入确保在 1 到 3999 的范围内。<br>
```
输入: 1994
输出: "MCMXCIV"
解释: M = 1000, CM = 900, XC = 90, IV = 4.
```

### 13. 罗马数字转整数（RomanToInt）
```
输入: "MCMXCIV"
输出: 1994
解释: M = 1000, CM = 900, XC = 90, IV = 4.
```

### 14. 最长公共前缀
编写一个函数来查找字符串数组中的最长公共前缀。<br>
如果不存在公共前缀，返回空字符串 ""。<br>
```
输入：strs = ["flower","flow","flight"]
输出："fl"
```
### 15. 三数之和（ThreeSum）
给你一个包含 n 个整数的数组 nums，判断 nums 中是否存在三个元素 a，b，c ，使得 a + b + c = 0 ？请你找出所有和为 0 且不重复的三元组。<br>
注意：答案中不可以包含重复的三元组。<br>
```
输入：nums = [-1,0,1,2,-1,-4]
输出：[[-1,-1,2],[-1,0,1]]
```

### 16. 最接近的三数之和(ThreeSumClosest)
给定一个包括 n 个整数的数组 nums 和 一个目标值 target。找出 nums 中的三个整数，使得它们的和与 target 最接近。返回这三个数的和。假定每组输入只存在唯一答案。
```
输入：nums = [-1,2,1,-4], target = 1
输出：2
解释：与 target 最接近的和是 2 (-1 + 2 + 1 = 2) 。
```
### 17. 电话号码的字母组合
给定一个仅包含数字 2-9 的字符串，返回所有它能表示的字母组合。答案可以按 任意顺序 返回。<br>
给出数字到字母的映射如下（与电话按键相同）。注意 1 不对应任何字母。<br>
```
输入：digits = "23"
输出：["ad","ae","af","bd","be","bf","cd","ce","cf"]
```

### 18. 四数之和（FourSum）
给定一个包含 n 个整数的数组 nums 和一个目标值 target，判断 nums 中是否存在四个元素 a，b，c 和 d ，使得 a + b + c + d 的值与 target 相等？找出所有满足条件且不重复的四元组。<br>
```
输入：nums = [1,0,-1,0,-2,2], target = 0
输出：[[-2,-1,1,2],[-2,0,0,2],[-1,0,0,1]]
```
### 19. 删除链表的倒数第 N 个结点（RemoveNthFromEnd）
给你一个链表，删除链表的倒数第 n 个结点，并且返回链表的头结点。<br>
```
输入：head = [1,2,3,4,5], n = 2
输出：[1,2,3,5]
```
### 20. 有效的括号(IsValid)
给定一个只包括 '('，')'，'{'，'}'，'['，']' 的字符串 s ，判断字符串是否有效。<br>
有效字符串需满足：
    + 左括号必须用相同类型的右括号闭合。
    + 左括号必须以正确的顺序闭合。
```
输入：s = "()[]{}"
输出：true
```

### 32. 最长有效括号（LongestValidParentheses）
给你一个只包含 '(' 和 ')' 的字符串，找出最长有效（格式正确且连续）括号子串的长度。<br>
```
输入：s = ")(()())"
输出：6
解释：最长有效括号子串是 "(()())"
```

### 263. 丑数(IsUgly)
给你一个整数 n ，请你判断 n 是否为 丑数 。如果是，返回 true ；否则，返回 false 。<br>
丑数 就是只包含质因数 2、3 和/或 5 的正整数。<br>
```
输入：n = 14
输出：false
解释：14 不是丑数，因为它包含了另外一个质因数 7 。
```
