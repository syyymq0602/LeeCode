using System;

namespace RemoveNthFromEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode head = new ListNode();
            int n = 2;
            var s = RemoveNthFromEnd(head, n);
            Console.WriteLine("Hello World!");
        }
        // 双指针 链表
        public static ListNode RemoveNthFromEnd(ListNode head, int n) {
            ListNode dummy = new ListNode(0,head);
            ListNode firstNode = head;
            ListNode secondNode = dummy;
            for (int i = 0; i < n; i++)
            {
                firstNode = firstNode.next;
            }

            while (firstNode != null)
            {
                firstNode = firstNode.next;
                secondNode = secondNode.next;
            }

            secondNode.next = secondNode.next.next;
            ListNode ans = dummy.next;
            return ans;
        }
        public class ListNode {
            public int val;
            public ListNode next;
            public ListNode(int val=0, ListNode next=null) {
                this.val = val;
                this.next = next;
            }
        }
    }
}