using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /// <summary>
    /// B树
    /// </summary>
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
        public TreeNode(int val, TreeNode left, TreeNode right) {
            this.val = val;
            this.left = left;
            this.right = right;
        }
        /// <summary>
        /// 使用数组构建,先序遍历
        /// </summary>
        /// <param name="nums"></param>
        public static TreeNode CreateTreeByArr(int[] nums) {
            return createSonNode(nums, 0, nums.Length);
        }
        public static TreeNode createSonNode(int[] nums,int index,int len) {
            if (index > len-1)
                return null;
            TreeNode node = new TreeNode(nums[index]);
            node.left = createSonNode(nums, 2 * index + 1, len);
            node.right = createSonNode(nums, 2 * index + 2, len);
            return node;
        }
    }

    public class ListNode
    {
          public int val;
          public ListNode next;
          public ListNode(int x) { val = x; }
    }
}
