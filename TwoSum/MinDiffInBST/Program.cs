using System;

namespace MinDiffInBST
{
    class Program
    {
        public static int pre;
        public static int ans;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        // 二叉搜索树性质,dfs遍历方法
        private static int MinDiffInBST(TreeNode root)
        {
            ans = Int32.MaxValue;
            pre = -1;
            dfs(root);
            return ans;
        }
        public static void dfs(TreeNode root)
        {
            if (root == null)
                return;
            dfs(root.left);
            if (pre == -1)
            {
                pre = root.val;
            }
            else
            {
                ans = Math.Min(ans, root.val - pre);
                pre = root.val;
            }
            dfs(root.right);
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