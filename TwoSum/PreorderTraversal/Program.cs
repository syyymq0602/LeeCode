using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace PreorderTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        // 前序遍历   根-左-右
        private static IList<int> PreorderTraversal(TreeNode root)
        {
            IList<int> res = new List<int>();
            inorder(root, res);
            return res;
        }

        private static void inorder(TreeNode root, IList<int> res)
        {
            if (root == null)
                return;
            res.Add(root.val);
            inorder(root.left,res);
            inorder(root.right,res);
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