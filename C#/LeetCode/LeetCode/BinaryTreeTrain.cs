using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /// <summary>
    /// 二叉树复习训练
    /// </summary>
    class BinaryTreeTrain
    {

        //static void Main(string[] args) {
        //    TreeNode n1 = new TreeNode(1);
        //    TreeNode n2 = new TreeNode(2);
        //    TreeNode n3 = new TreeNode(3);
        //    TreeNode n4 = new TreeNode(4);
        //    TreeNode n5 = new TreeNode(5);
        //    TreeNode n6 = new TreeNode(6);
        //    TreeNode n7 = new TreeNode(7);
        //    TreeNode n8 = new TreeNode(8);
        //    n1.left = n2;
        //    n1.right = n3;
        //    n2.left = n4;
        //    n2.right = n5;
        //    n5.left = n7;
        //    n7.right = n8;
        //    n3.right = n6;

        //    PostOrderTraverse2(n1);
        //}

        /// <summary>
        /// 前序遍历,递归
        /// </summary>
        public static void PreOrderTraverse(TreeNode t) {
            if (t == null)
                return;
            Console.Write(t.val);
            PreOrderTraverse(t.left);
            PreOrderTraverse(t.right);
        }
        /// <summary>
        /// 前序遍历,非递归,在选择左分支时判断右分支是否为空，否则将右节点压入栈中
        /// </summary>
        public static void PreOrderTraverse2(TreeNode head)
        {
            if (head == null)
                return;
            Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode t = head;
            while (t != null) {
                printf(t.val);
                if (t.left != null)
                {
                    if (t.right != null)
                        stack.Push(t.right);
                    t = t.left;
                }
                else if (t.right != null)
                {
                    t = t.right;
                }
                else {
                    if (stack.Count > 0)
                    {
                        t = stack.Pop();
                    }
                    else
                    {
                        t = null;
                    }
                }
            }
        }

        /// <summary>
        /// 中序遍历，递归
        /// </summary>
        public static void InOrderTraverse(TreeNode head) {
            if (head == null)
                return;
            InOrderTraverse(head.left);
            printf(head.val);
            InOrderTraverse(head.right);
        }
        /// <summary>
        /// 中序遍历，非递归
        /// </summary>
        public static void InOrderTraverse2(TreeNode head) {
            if (head == null)
                return;
            Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode t = head;
            while (t != null) {
                if (t.left != null)
                {
                    TreeNode tt = t;
                    stack.Push(tt);
                    t = t.left;
                    tt.left = null;
                }
                if (t.left == null)
                {
                    printf(t.val);
                    if (t.right == null)
                    {
                        if (stack.Count > 0)
                        {
                            t = stack.Pop();
                        }
                        else {
                            t = null;
                        }
                    }
                    else {
                        t = t.right;
                    }
                }
            }
        }

        /// <summary>
        /// 后续遍历,递归
        /// </summary>
        /// <param name="head"></param>
        public static void PostOrderTraverse(TreeNode head) {
            if (head == null)
                return;
            PostOrderTraverse(head.left);
            PostOrderTraverse(head.right);
            printf(head.val);
        }
        /// <summary>
        /// 后续遍历，非递归
        /// </summary>
        /// <param name="head"></param>
        public static void PostOrderTraverse2(TreeNode head)
        {
            if (head == null)
                return;
            Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode t = head;
            while (t != null) {
            }
        }

        public static void printf(int msg) {
            Console.Write(msg);
        }
        public static void printf(string msg)
        {
            Console.Write(msg);
        }

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

    }
}
