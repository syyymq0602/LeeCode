using System;
using System.Collections;
using System.Collections.Generic;

namespace PostorderTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        // 后序遍历  左-右-根
        private static IList<int> PostorderTraversal(TreeNode root)
        {
            IList<int> res =new List<int>();
            inorder(root, res);
            return res;
        }
        private static void inorder(TreeNode root, IList<int> res)
        {
            if (root == null)
                return;
            inorder(root.left,res);
            inorder(root.right,res);
            res.Add(root.val);
        }
        public class TreeNode {
            public int val; 
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
    }
}