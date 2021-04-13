using System;
using System.Collections.Generic;

namespace InorderTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        // 中序遍历   左-根-右
        private static IList<int> InorderTraversal(TreeNode root)
        {
            IList<int> res = new List<int>();
            inorder(root, res);
            return res;
        }
        public static void inorder(TreeNode root, IList<int> res)
        {
            if (root == null)
                return;
            inorder(root.left,res);
            res.Add(root.val);
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