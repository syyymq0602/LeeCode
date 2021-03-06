﻿using System;

namespace addTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode L1 = new ListNode(2);
            ListNode L2 = new ListNode(5);
            var res = addTwoNumbers(L1, L2);
            Console.WriteLine(res);
        }
        //Definition for singly-linked list.
        public class ListNode { 
            public int val;
            public ListNode next;
            public ListNode(int val=0, ListNode next=null) {
                this.val = val;
                this.next = next;
            }
        }
        public static ListNode addTwoNumbers(ListNode l1, ListNode l2) {
            ListNode pre = new ListNode();
            ListNode cur = pre;
            int carry = 0;
            while(l1!=null || l2!=null){
                int x = l1 == null ? 0 : l1.val;
                int y = l2 == null ? 0 : l2.val;
                int sum = x + y + carry;
            
                carry = sum / 10;			
                sum = sum % 10;
            
                cur.next = new ListNode(sum);

                cur = cur.next;
                if(l1 != null)
                    l1 = l1.next;
                if(l2 != null)
                    l2 = l2.next;
            }
            if(carry == 1)
                cur.next = new ListNode(1);

            return pre.next;
        }
    }
}