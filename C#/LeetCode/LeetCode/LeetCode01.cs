using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class LeetCode01
    {

        static void Main(string[] args)
        {
            //int[,] nums = { { 1, 2 }, { 3, 4 } };
            //MatrixReshape(nums,4,1);
            //Console.WriteLine(1);
            //string[] ops = { "5", "-2", "4", "C", "D", "9", "+", "+" };
            //CalPoints(ops);
            //int[,] can = { { 0, 1, 0, 0 }, { 1, 1, 1, 0 }, { 0, 1, 0, 0 }, { 1, 1, 0, 0 } };
            //IslandPerimeter(can);
            //int[] a = { 4, 1, 2 };
            //int[] b = { 1, 3, 4, 2 };
            //NextGreaterElement(a, b);
            //[3, 2, 0, -4]

            //[1,3,5,6,7,8,9,10]
            //[2,4,6,7,8,9,10]
            //ListNode h1 = new ListNode(1);
            //ListNode h2 = new ListNode(2);
            //ListNode h3 = new ListNode(3);
            //ListNode h4 = new ListNode(4);
            //ListNode h5 = new ListNode(5);
            //ListNode h6 = new ListNode(6);
            //ListNode h7 = new ListNode(7);
            //ListNode h8 = new ListNode(8);
            //ListNode h9 = new ListNode(9);
            //ListNode h10 = new ListNode(10);

            //h1.next = h3;h3.next = h5;h5.next = h6;h6.next = h7;h7.next = h8;h8.next = h9;h9.next = h10;
            //h2.next = h4;h4.next = h6;

            //Console.Write(GetIntersectionNode(h1,h2).val);

            //int[] n1 = { 1 };
            //int[] n2 = { 1, 2 };
            //Intersection(n1, n2);
            //int[] nums = { 1, 0, 1, 1 };
            //FindMaxConsecutiveOnes(nums);

            int[] p = { 1, 2 };
            MaxProfit(p);
        }

        #region 20171207

        //Say you have an array for which the ith element is the price of a given stock on day i.
        //If you were only permitted to complete at most one transaction(ie, buy one and sell one share of the stock), design an algorithm to find the maximum profit.
        public static int MaxProfit(int[] prices)
        {
            if (prices == null || prices.Length == 0)
                return 0;
            int res = 0;
            int curMin = prices[0];
            for (int i = 1; i < prices.Length; i++) {
                curMin = Math.Min(curMin, prices[i]);
                res = Math.Max(res, prices[i] - curMin);
            }
            return res;
        }

        //Given a binary array, find the maximum number of consecutive 1s in this array.
        public static int FindMaxConsecutiveOnes(int[] nums)
        {
            if (nums == null)
                return 0;
            int res = 0;
            int t = 0;
            foreach (int v in nums) {
                if (v == 1)
                {
                    t++;
                }
                else {
                    if (res < t)
                        res = t;
                    t = 0;
                }
            }
            if (t > res) {
                return t;
            }
            return res;
        }

        #endregion

        #region 20171206

        //Given two arrays, write a function to compute their intersection.
        public static int[] Intersection(int[] nums1, int[] nums2)
        {
            List<int> res = new List<int>();
            HashSet<int> n1 = new HashSet<int>(nums1);
            HashSet<int> n2 = new HashSet<int>(nums2);

            foreach (int v1 in n1) {
                foreach (int v2 in n2) {
                    if (v1 == v2)
                        res.Add(v1);
                }
            }
            return res.ToArray();
        }

        //Write a program to find the node at which the intersection of two singly linked lists begins.
        public static ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            if (headA == null || headB == null)
                return null;
            Stack<ListNode> A = new Stack<ListNode>();
            Stack<ListNode> B = new Stack<ListNode>();
            while (headA != null) {
                A.Push(headA);
                headA = headA.next;
            }
            while (headB != null)
            {
                B.Push(headB);
                headB = headB.next;
            }
            ListNode tA = A.Pop();
            ListNode tB = B.Pop();
            if (tA != tB)
                return null;
            ListNode res = tA;
            while (tA == tB && A.Count != 0 && B.Count != 0) {
                tA = A.Pop();
                tB = B.Pop();
                if(tA == tB)
                    res = tA;
            }
            return res;
        }
        //两个链表，只要有一个节点一样，后面的节点肯定一样
        public static ListNode GetIntersectionNode2(ListNode headA, ListNode headB)
        {
            if (headA == null || headB == null)
                return null;
            ListNode a = headA;
            ListNode b = headB;
            while (a != b) {
                a = a == null ? headB : a.next;
                b = b == null ? headA : b.next;
            }
            return a;
        }

        //Remove all elements from a linked list of integers that have value val.
        public static ListNode RemoveElements(ListNode head, int val)
        {
            if (head == null)
                return null;
            while (head.val == val && head != null && head.next != null)
                head = head.next;
            if (head.val == val)
                return null;
            ListNode t = head.next;
            ListNode h = head;
            while (t != null) {
                if (t.val == val)
                {
                    h.next = t.next;
                    t = h.next;
                }
                else {
                    h = t;
                    t = t.next;
                }
            }
            return head;
        }

        //Given a singly linked list, determine if it is a palindrome.
        public static bool IsPalindrome(ListNode head)
        {
            if (head == null)
                return true;
            List<int> list = new List<int>();
            ListNode t = head;
            while (t != null) {
                list.Add(t.val);
                t = t.next;
            }
            for (int i = 0,j = list.Count-1; i < j; i++,j--) {
                if (list[i] != list[j])
                    return false;
            }
            return true;
        }

        //***
        //Given a linked list, determine if it has a cycle in it
        public static bool HasCycle(ListNode head)
        {
            if (head == null || head.next == null)
                return false;
            ListNode t = head;
            Dictionary<ListNode, int> dic = new Dictionary<ListNode, int>();
            while (t != null) {
                if (dic.ContainsKey(t))
                    return true;
                dic.Add(t, 1);
                t = t.next;
            }
            return false;
        }

        //Given a sorted linked list, delete all duplicates such that each element appear only once.
        public static ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null || head.next == null)
                return head;
            ListNode c = head.next;
            ListNode t = head;
            while (c != null) {
                if (t.val == c.val)
                {
                    t.next = c.next;
                    c = c.next;
                }
                else {
                    t = c;
                    c = c.next;
                }
            }
            return head;
        }

        //***
        //Reverse a singly linked list.
        public static ListNode ReverseList(ListNode head)
        {
            if (head == null || head.next == null)
                return head;
            ListNode pHead = ReverseList(head.next);
            head.next.next = head;
            head.next = null;
            return pHead;
        }
        public static ListNode ReverseList2(ListNode head)
        {
            if (head == null || head.next == null)
                return head;
            ListNode c = head.next;
            ListNode n = null;
            head.next = null;
            while (c != null) {
                n = c.next;
                c.next = head;
                head = c;
                c = n;
            }
            return head;
        }

        //Write a function to delete a node(except the tail) in a singly linked list, given only access to that node.
        //Supposed the linked list is 1 -> 2 -> 3 -> 4 and you are given the third node with value 3, the linked list should become 1 -> 2 -> 4 after calling your function.
        public static void DeleteNode(ref ListNode node)
        {
            node.val = node.next.val;
            node.next = node.next.next;
        }

        //***
        //遍历队列，将同层次的值的平均值求出
        //Given a non-empty binary tree, return the average value of the nodes on each level in the form of an array.
        public static IList<double> AverageOfLevels(TreeNode root)
        {
            List<double> res = new List<double>();
            if (root == null)
                return res;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            TreeNode t;
            while (queue.Count > 0) {
                int n = queue.Count;
                double sum = 0;
                for (int i = 0; i < n; i++) {
                    t = queue.Dequeue();
                    sum += t.val;
                    if (t.left != null) queue.Enqueue(t.left);
                    if (t.right != null) queue.Enqueue(t.right);
                }
                res.Add(sum/n);
            }
            return res;
        }

        //496. Next Greater Element I
        public static int[] NextGreaterElement(int[] findNums, int[] nums)
        {
            if (findNums == null || nums == null) {
                return findNums == null ? nums : findNums;
            }
            int len = findNums.Length;
            int[] res = new int[len];
            for (int i = 0; i < len; i++) {
                bool f = false;
                int val = -1;
                for (int j = 0; j < nums.Length; j++) {
                    if (!f)
                    {
                        if (nums[j] == findNums[i])
                        {
                            f = true;
                        }
                    }
                    else {
                        if (nums[j] > findNums[i]) {
                            val = nums[j];
                        }
                    }
                    if (val != -1)
                        break;
                }
                res[i] = val;
            }
            return res;
        }

        //463. Island Perimeter
        public static int IslandPerimeter(int[,] grid)
        {
            if (grid == null)
                return 0;
            int count = 0;
            int row = grid.GetLength(0);
            int col = grid.GetLength(1);
            for (int i = 0; i < row; i++) {
                for (int j = 0; j < col; j++) {
                    if (grid[i, j] == 1) {
                        count += 4;
                        if (i < row - 1) {
                            if (grid[i + 1, j] == 1)
                                count -= 1;
                        }
                        if (i > 0) {
                            if (grid[i - 1, j] == 1)
                                count -= 1;
                        }
                        if (j < col - 1) {
                            if (grid[i, j + 1] == 1)
                                count -= 1;
                        }
                        if (j > 0) {
                            if (grid[i, j - 1] == 1)
                                count -= 1;
                        }
                    }
                }
            }
            return count;
        }

        //***
        //Given an integer array with even length, where different numbers in this array represent different kinds of candies.
        //Each number means one candy of the corresponding kind. 
        //You need to distribute these candies equally in number to brother and sister.
        //Return the maximum number of kinds of candies the sister could gain.
        public static int DistributeCandies(int[] candies)
        {
            int[] arr = candies.OrderBy(x => x).ToArray();
            int count = 1;
            for (int i = 1; i < candies.Length; i++) {
                if (arr[i] != arr[i - 1])
                    count++;
            }
            return count > candies.Length / 2 ? candies.Length / 2 : count;
        }

        #endregion

        #region 20171205

        //You're now a baseball game point recorder.
        //Given a list of strings, each string can be one of the 4 following types:
        //Integer(one round's score): Directly represents the number of points you get in this round.
        //"+" (one round's score): Represents that the points you get in this round are the sum of the last two valid round's points.
        //"D" (one round's score): Represents that the points you get in this round are the doubled data of the last valid round's points.
        //"C" (an operation, which isn't a round's score): Represents the last valid round's points you get were invalid and should be removed.
        //Each round's operation is permanent and could have an impact on the round before and the round after.
        //You need to return the sum of the points you could get in all the rounds.
        public static int CalPoints(string[] ops)
        {
            if (ops == null)
                return 0;
            List<int> cList = new List<int>();
            int sum = 0;
            int curCount = 0;
            for (int i = 0; i < ops.Length; i++)
            {
                string s = ops[i];
                switch (ops[i])
                {
                    case "+":
                        curCount = 0;
                        for (int j = cList.Count - 1; j > cList.Count - 3; j--)
                        {
                            curCount += cList[j];
                        }
                        sum += curCount;
                        cList.Add(curCount);
                        break;
                    case "D":
                        curCount = cList.Last() * 2;
                        sum += curCount;
                        cList.Add(curCount);
                        break;
                    case "C":
                        curCount = cList.Last();
                        sum -= curCount;
                        cList.RemoveAt(cList.Count - 1);
                        break;
                    default:
                        curCount = int.Parse(s);
                        cList.Add(curCount);
                        sum += curCount;
                        break;
                }
            }
            return sum;
        }

        //***
        //我们可以找一个有效位和所给的数相同，且每一位都是1的数与之做异或运算，即可得到答案。
        //Given a positive integer, output its complement number. The complement strategy is to flip the bits of its binary representation.
        public static int FindComplement(int num)
        {
            int xorNum = 1;
            int n = num >> 1;
            while (n > 0) {
                xorNum = ((xorNum << 1) + 1);
                n = n >> 1;
            }
            return num ^ xorNum;
        }

        //***
        //搜索二叉树，将左树值中大于L的去掉，将右树中大于R的节点去掉
        public static TreeNode TrimBST(TreeNode root, int L, int R)
        {
            if (root == null)
                return root;
            if (root.val >= L && root.val <= R) {
                //该节点被存下来
                root.left = TrimBST(root.left, L, R);
                root.right = TrimBST(root.right, L, R);
                return root;
            }
            //该节点被去掉了
            if (root.val < L) return TrimBST(root.right, L, R);
            if (root.val > R) return TrimBST(root.left, L, R);
            return root;
        }

        //***
        //In MATLAB, there is a very useful function called 'reshape', which can reshape a matrix into a new one with different size but keep its original data.
        public static int[,] MatrixReshape(int[,] nums, int r, int c)
        {
            if (r * c != nums.Length)
                return nums;
            int[,] res = new int[r, c];
            int i = 0;
            foreach (int a in nums) {
                res[i / c, i % c] = a;
                i++;
            }
            return res;
        }

        #endregion

    }
}
