﻿using System;
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
            #region old
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

            //int[] p = { 33,0,33,33 };
            //ContainsNearbyDuplicate(p,1);

            //    IsPowerOfThree(1);


            //    ListNode head = new ListNode(0);
            //    //建立一个指向head的箭头
            //    ListNode t = head;
            //    while (t != null) {
            //        //dosomething
            //        t = t.next;
            //}

            //int[] arr = { 1, 0, 1, 0, 2, 3 };
            //int[] res = moveZero2(arr);

            //Console.Write(AddDigits(129));

            //Console.Write(AddStrings("55", "55"));

            //Console.Write(CanWinNim(20));

            //Console.Write(HasAlternatingBits(6));

            //TreeNode r1 = new TreeNode(1);
            //TreeNode r2 = new TreeNode(2);
            //TreeNode r3 = new TreeNode(3);
            //TreeNode r4 = new TreeNode(4);
            //TreeNode r5 = new TreeNode(5);
            //TreeNode r6 = new TreeNode(6);
            //r1.left = r2;
            //r2.left = r4;
            //r1.right = r3;
            //r3.right = r5;
            //r5.right = r6;
            //Console.Write(MaxDepth(r1));

            //char[] arr = { 'c', 'f', 'j' };
            //Console.Write(NextGreatestLetter(arr, 'a'));

            //Console.Write(CountBinarySubstrings("00110011"));

            //int[] nums = { 1,2,3,3,2,6 };
            //FindDisappearedNumbers2(nums);

            //Console.Write(FindTheDifference("abcde", "abcdef"));

            //int[] nums = { 1, 0, 3, 0, 2, 6 };
            //MoveZeroes(nums);

            //int[,] grid = { { 0, 1 }, { 1, 1 } };
            //Console.Write(MaxAreaOfIsland(grid)); 

            //Console.Write(TitleToNumber("ABA"));

            //    string[] words = { "stripe", "step","steps","stepple"};
            //    Console.Write(ShortestCompletingWord("1s3 PSt", words));

            //TreeNode node = new TreeNode(5);
            //TreeNode node2 = new TreeNode(2);
            //TreeNode node3 = new TreeNode(13);
            //node.left = node2;
            //node.right = node3;
            //int[] nums = { 5, 2, 13 };
            //TreeNode node = TreeNode.CreateTreeByArr(nums);

            //ConvertBST2(node);

            //int[] res = ConstructRectangle(6);

            //int[] nums = { 0,0,1,1 };
            //Console.Write(MinCostClimbingStairs2(nums));
            //ClimbStairs(4);
            //    int[] arr = { 4, 3, 7, 5, 6 };
            //    TreeNode root = TreeNode.CreateTreeByArr(arr);
            //    TreeNode res = findNearstFar(root, 5, 6);
            //    int val = res == null ? 0 : res.val;
            //    Console.Write(res);
            //MajorityElement(nums);

            //Console.Write(FirstUniqChar("cc"));

            //int[] nums = { 2, 3, 4 };
            //int[] res = TwoSum2(nums, 6);

            //TreeNode root = TreeNode.CreateTreeByArr(new int[3] { 1, 2, 3});
            //GetMinimumDifference(root);

            //TreeNode root = TreeNode.CreateTreeByArr(new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 });
            //traverseTreeBack(root);

            //int[] nums = new int[12] { 20,-2, 1, -3, 4, -1, 2, 1, -5, 4,-10,20 };
            //MaxSubArray2(nums);

            //int[] nums = { 5, 4, 3, 2, 1 };
            //string[] res = FindRelativeRanks(nums);
            //int[] nums = {2,6,4,2,8,9,3 };
            //Console.Write(FindUnsortedSubarray(nums));

            //int[] nums = { -1, -1, -1, -1, -1, -1 };
            //Console.Write(PivotIndex(nums));

            //ListNode l1 = ListNode.CreateFromArrays(new int[4] { 1,2,3,4 });
            //ListNode l2 = ListNode.CreateFromArrays(new int[2] { 9,9 });
            //ListNode res = AddTwoNumbers2(l1, l2);

            //int[] nums = { 2, 3, 2, 3, 4 };
            //Console.Write(CheckPossibility(nums));

            //string msg = "cuppucu";
            //ValidPalindrome(msg);

            //int[] nums = { 1, 3, 5, 7 };
            //Console.Write(FindLengthOfLCIS(nums));

            //int[] nums = { 1, 12, -5, -6, 50, 3 };
            //Console.Write(FindMaxAverage2(nums, 4));

            //Console.Write(ReachNumber(10));

            //    int[] nums = { 1, 2, 2 };
            //    int[] res = FindErrorNums(nums);

            //int[] nums = { 1, 2, 2, 3, 2, 2, 4, 3, 3 };
            //Console.Write(FindShortestSubArray(nums));

            //LongestPalindrome("bbaabccccddacc");
            //string res = AddBinary2("11", "11");

            //Console.Write('1' - '0');

            //Console.Write(ReverseStr("abcdefgh", 3));
            //Generate(3);

            //int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
            //Rotate2(nums,5);

            //int[] nums = { 1, 2, 3, 4, 5 };
            //int res = Rob2(nums);

            //List<int> nums = new List<int>();
            //for (int i = 1; i < 101; i++)
            //{
            //    nums.Add(i);
            //}
            //int res = MissingNumber2(nums.ToArray());
            //int res = MySqrt(8);
            //TreeNode root = TreeNode.CreateTreeByArr(new int[5] { 1, 2, 3,4,5});
            //IList<IList<int>>  res  = LevelOrderBottom(root);

            //int res = CountPrimes(5);

            //char[] cs = { 'a','b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b' };
            //int res = Compress(cs);

            //string[] strs = { "a","banana", "app", "appl", "ap", "apply", "apple" };
            //string res = LongestWord2(strs);

            //ConvertToTitle(1000);
            //GetRow(5);
            //IsPalindrome("0PP");
            //TrailingZeroes(30);

            //reverseBits(5);
            //IsHappy(2);
            //MyQueue q = new MyQueue();
            //q.Push(1);
            //q.Push(2);
            //q.Push(3);
            //int res = q.Peek();


            //int[] nums = { 1, 2, 3 };
            ////int[] b = new int[2];
            ////combine1(nums, nums.Length, 2, b, 2);
            //combine2(nums, 0, nums.Length-1);

            //int res = reverseAdd(123, 456);
            //int t = 321 + 654;

            //dice("RA");
            //bool res = IsPowerOfFour(32);
            //TreeNode root = TreeNode.CreateTreeByArr(new int[7] { 1, -2, -3, 1, 3, -2, -1 });
            //int res = PathSum3(root, 1); ;
            //FindAnagrams2("abab", "ab");
            //int[] nums = { 4, 3, 5, 4, 3, 3, 6, 7 };
            //SliderDown(nums, 3);
            //bool res = RepeatedSubstringPattern("abcabcabc");

            //int[] nums = { 1, 2, 5 };
            //int[] heat = { 2 };
            //int res = FindRadius(nums, heat);

            //TreeNode root = TreeNode.CreateTreeByArr(new int[5] { 1, 2, 3, 4, 5 });
            //FindSecondMinimumValue(root);

            //int res = CountPrimeSetBits(6, 10);

            //TreeNode node = ConstructMaximumBinaryTree(new int[6] { 3, 2, 1, 6, 0, 5 });

            //int[] res = ProductExceptSelf(new int[4] { 1, 2, 3, 4 });

            //int res = ArrayNesting(new int[7] { 5, 4, 0, 3, 1, 6, 2 });

            //CombinationSum3(3, 27);
            //int[] ws = { 2, 2, 6, 5, 4 };
            //int[] va = { 6, 3, 5, 4, 6 };
            //int res = package01_2(ws, va, 10);

            #endregion

            //PartitionLabels("abcdea");
            //Console.ReadLine();
            //int a = brickTest1("AAA");
            //int size = int.Parse(Console.ReadLine());
            //string numStr = Console.ReadLine();
            //string[] numsStr = numStr.Split(' ');
            //int[] nums = new int[size];
            //for (int i = 0; i < size; i++)
            //{
            //    nums[i] = int.Parse(numsStr[i]);
            //}
            //Console.Write(str01("1010101"));
            //shulie(nums);

            //int[] res = caozuonixu(new int[4] { 1, 2, 3, 4 });
            //for (int i = 0; i < res.Length; i++)
            //{
            //    if(i != res.Length - 1)
            //        Console.Write(res[i] + " ");
            //    else
            //        Console.Write(res[i]);
            //}
            //int[] nums = { 3, 34, 4, 12, 5, 2 };
            //int res = maxSum(nums, nums.Length - 1);
            //int res = maxSum2(nums);
            //bool res = sumEq2(nums, 13);

            //int[,] nums = new int[6, 2] { { 7,0 }, { 4,4}, { 7, 1 }, { 5, 0 }, { 6, 1 }, { 5, 2 } };
            //int[,] res = ReconstructQueue(nums);
            //int res = NumberOfArithmeticSlices(new int[6] { 1, 2, 3, 4, 5, 6 });
            //int res = MinMoves2(new int[3] { -5, 3, 3 });
            string res = FrequencySort2("tree");

            Console.ReadLine();
        }

        #region 其他
        #region 递归问题

        //nums中是否存在子集，使得子集之和为target，动态规划
        public static bool sumEq2(int[] nums, int target)
        {
            int[,] subset = new int[nums.Length, target+1];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < target + 1; j++)
                {
                    if (j == 0 && i != 0)
                        subset[i, j] = 1;
                    else
                        subset[i, j] = 0;
                }
            }
            if (nums[0] <= target)
            {
                subset[0,nums[0]] = 1;
            }
            for (int i = 1; i < nums.Length; i++)
            {
                for (int j = 1; j < target + 1; j++)
                {
                    if (nums[i] > j)
                        subset[i, j] = subset[i - 1, j];
                    else
                    {
                        subset[i, j] = subset[i - 1, j - nums[i]] | subset[i - 1, j];
                    }
                }
            }
            return subset[nums.Length - 1, target] == 1;
        }

        //nums中是否存在子集，使得子集之和为target，递归解法
        public static bool sumEq(int[] nums,int index,int target)
        {
            if (target == 0)
                return true;
            if (index == 0)
                return target == nums[index];
            if (nums[index] > target)
                return sumEq(nums, index - 1, target);//直接选下一个
            else
                //选当前个或选下一个
                return sumEq(nums, index - 1, target - nums[index]) || sumEq(nums, index - 1, target);
        }

        //间隔最大和 动态规划
        public static int maxSum2(int[] nums)
        {
            //int[] temp = new int[nums.Length];
            //temp[0] = nums[0];
            //temp[1] = Math.Max(nums[0], nums[1]);
            int temp0 = nums[0];
            int temp1 = Math.Max(nums[0], nums[1]);
            for (int i = 2; i < nums.Length; i++)
            {
                int t = temp1;
                temp1 = Math.Max(temp1, temp0 + nums[i]);
                temp0 = t;
            }
            return temp1;
        }

        //间隔最大和 递归解法
        public static int maxSum(int[] nums,int index)
        {
            if (index == 0)
                return nums[0];
            if (index == 1)
                return Math.Max(nums[0], nums[1]);
            return Math.Max(maxSum(nums, index - 1), maxSum(nums, index - 2) + nums[index]);
        }

        #endregion
        #region 背包问题

        //01背包问题 二维数据DP
        public static int package01(int[] weights,int[] values,int maxWeight)
        {
            int[,] mm = new int[weights.Length + 1, maxWeight + 1];
            
            for (int i = 1; i <= weights.Length; i++)
            {
                for (int j = 1; j <= maxWeight; j++)
                {
                    if (j > weights[i-1])
                        mm[i, j] = Math.Max(mm[i - 1, j], mm[i - 1, j - weights[i-1]] + values[i-1]);
                    else
                        mm[i, j] = mm[i - 1, j];
                }
            }
            return mm[weights.Length, maxWeight];
        }

        //01背包问题 一维数据DP
        public static int package01_2(int[] weights, int[] values, int maxWeight)
        {
            int[] maxVal = new int[maxWeight+1];
            for (int i = 0; i < weights.Length; i++)
            {
                for (int j = maxWeight; j >= weights[i]; j--)
                {
                    int t = j - weights[i];
                    if (maxVal[j - weights[i]] + values[i] > maxVal[j])
                        maxVal[j] = maxVal[j - weights[i]] + values[i];
                }
            }
            return maxVal[maxWeight];
        }

        #endregion
        #region 面试题

        //小易有一个长度为n的整数序列,a_1,...,a_n。然后考虑在一个空序列b上进行n次以下操作:
        //1、将a_i放入b序列的末尾
        //2、逆置b序列
        //小易需要你计算输出操作n次之后的b序列。 
        public static int[]  caozuonixu(int[] nums)
        {
            int[] res = new int[nums.Length];
            int[] temp = new int[nums.Length];

            int midFlag = -1;
            temp[0] = nums.Length;
            int t = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                t = 0;
                if (midFlag == -1)//未过中线
                {
                    t = temp[i - 1] - 2;
                } else if(midFlag == 0)//已过中线，
                {
                    t = temp[i - 1] + 2;
                }
                if (t == 1)//刚好到中线，且之前为3
                {
                    temp[i] = 1;
                    temp[i + 1] = 2;
                    i++;
                    midFlag = 0;
                }
                else if (t <= 0)//到中线，且之前为2
                {
                    temp[i] = 1;
                    temp[i + 1] = 3;
                    i++;
                    midFlag = 0;
                }
                else
                {
                    temp[i] = t;
                }
            }
            for (int i = 0; i < temp.Length; i++)
            {
                res[i] = nums[temp[i]-1];
            }
            return res;
        }

        //最长01交错子串
        public static int str01(string str)
        {
            if (str.Length == 0)
                return 0;
            if (str.Length == 1)
                return 1;
            int max = 0;
            int temp = 1;
            for (int i = 0; i < str.Length-1; i++)
            {
                if (str[i] == str[i + 1])
                {
                    max = Math.Max(temp, max);
                    temp = 1;
                }
                else
                {
                    temp++;
                }
            }
            return Math.Max(max,temp);
        }

        //能否构成等差数列
        public static void shulie(int[] nums)
        {
            if (nums.Length <= 2)
            {
                Console.Write("Possible");
                return;
            }
            Array.Sort(nums);
            int diff = nums[1] - nums[0];
            for (int i = 2; i < nums.Length; i++)
            {
                if (nums[i] - nums[i - 1] != diff)
                {
                    Console.Write("Impossible");
                    return;
                }
            }
            Console.Write("Possible");
        }

        //ABAB方块
        public static int brickTest1(string str)
        {
            int count = 0;
            if (str.Length == 0)
                return count;
            int[] map = new int[26];
            for (int i = 0; i < str.Length; i++)
            {
                map[str[i] - 'A'] = 1;
            }
            for (int i = 0; i < map.Length; i++)
            {
                if (map[i] == 1)
                    count++;
            }
            if (count > 2)
                return 0;
            return count;
        }
        

        //华为-整数反转求和
        //(123,456) = 321 + 654
        public static int reverseAdd(int a, int b)
        {
            int ta = 0;
            while (a >= 10)
            {
                int temp = a % 10;
                ta = (ta + temp) * 10;
                a /= 10;
            }
            ta += a;
            int tb = 0;
            while (b >= 10)
            {
                int temp = b % 10;
                tb = (tb + temp) * 10;
                b /= 10;
            }
            ta += b;
            return ta + tb;
        }

        /// <summary>
        /// 华为-掷骰子
        /// </summary>
        public static void dice(string cmd)
        {
            int[] init = { 0, 1, 2, 3, 4, 5, 6 };
            for (int i = 0; i < cmd.Length; i++)
            {
                switch (cmd[i])
                {
                    case 'L':
                        int temp1 = init[1];
                        init[1] = init[5];
                        init[5] = init[2];
                        init[2] = init[6];
                        init[6] = temp1;
                        break;
                    case 'R':
                        int temp2 = init[1];
                        init[1] = init[6];
                        init[6] = init[2];
                        init[2] = init[5];
                        init[5] = temp2;
                        break;
                    case 'F':
                        int temp3 = init[3];
                        init[3] = init[5];
                        init[5] = init[4];
                        init[4] = init[6];
                        init[6] = temp3;
                        break;
                    case 'B':
                        int temp4 = init[3];
                        init[3] = init[6];
                        init[6] = init[4];
                        init[4] = init[5];
                        init[5] = temp4;
                        break;
                    case 'A':
                        int temp5 = init[1];
                        init[1] = init[4];
                        init[4] = init[2];
                        init[2] = init[3];
                        init[3] = temp5;
                        break;
                    case 'C':
                        int temp6 = init[1];
                        init[1] = init[3];
                        init[3] = init[2];
                        init[2] = init[4];
                        init[4] = temp6;
                        break;
                }
            }
            for (int i = 1; i < init.Length; i++)
            {
                Console.Write(init[i]);
            }
        }


        #endregion
        #region 组合问题

        //全排列
        public static void combine2(int[] inArr,int index,int length)
        {
            if (index == length)
            {
                for (int i = 0; i < length + 1; i++)
                {
                    Console.Write(inArr[i]);
                }
                Console.WriteLine();
                return;
            }
            for (int i = index; i <= length; i++)
            {
                swap(inArr, index, i);
                combine2(inArr, index + 1, length);
                swap(inArr, index, i);
            }
        }
        public static void swap(int[] arr,int t1,int t2)
        {
            int temp = arr[t1];
            arr[t1] = arr[t2];
            arr[t2] = temp;
        }

        //求从数组a[1..n]中任选m个元素的所有组合。
        public static void combine1(int[] inArr, int nLen, int m, int[] outArr, int outLen)
        {
            if (m == 0)
            {
                for (int i = 0; i < outLen; i++)
                {
                    Console.Write(outArr[i]);
                }
                Console.WriteLine();
                return;
            }
            for (int i = nLen; i >= m; --i)
            {
                outArr[m - 1] = inArr[i-1];
                combine1(inArr, i - 1, m - 1, outArr, outLen);
            }
        }

        #endregion
        #region Medium

        // 查找最近公共父节点,二叉树查找树（有序）
        public static TreeNode findNearstFar2(TreeNode root, int a, int b)
        {
            if (root == null)
                return root;
            if (a > root.val && b > root.val)
                return findNearstFar2(root.right, a, b);
            else if (a < root.val && b < root.val)
                return findNearstFar2(root.left, a, b);
            return root;
        }

        // 查找最近公共父节点,普通二叉树
        public static TreeNode findNearstFar(TreeNode root,int a,int b) {
            if (root == null || root.val == a || root.val == b)
                return root;
            TreeNode left = findNearstFar(root.left, a, b);
            TreeNode right = findNearstFar(root.right, a, b);
            if (left != null && right != null)
                return root;
            else
                return left == null ? right : left;
        }

        //Given a binary tree and a sum, find all root-to-leaf paths where each path's sum equals the given sum.
        public static IList<IList<int>> PathSum(TreeNode root, int sum)
        {
            IList<IList<int>> res = new List<IList<int>>();
            if (root == null)
                return res;
            findPath(res, root, new Stack<int>(), sum);
            return res;
        }
        public static void findPath(IList<IList<int>> list,TreeNode node,Stack<int> stack,int sum) {
            if (node == null)
                return;
            stack.Push(node.val);
            if (node.left == null && node.right == null && stack.Sum() == sum) {
                List<int> n = stack.ToList();
                n.Reverse();
                list.Add(n);
            }
            if (node.left != null) {
                findPath(list, node.left, stack, sum);
                //重要操作，出栈
                stack.Pop();
            }
            if (node.right != null) {
                findPath(list, node.right, stack, sum);
                stack.Pop();
            }
        }

        #endregion
        #endregion

        #region 20180126

        //451. Sort Characters By Frequency
        List<char> sortTemp = null;
        public string FrequencySort(string s)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (dict.ContainsKey(s[i]))
                    dict[s[i]]++;
                else
                    dict.Add(s[i], 1);
            }
            StringBuilder sb = new StringBuilder();
            while (dict.Count > 0)
            {
                int max = dict.Values.Max();
                sortTemp = new List<char>(dict.Keys);
                for (int i = 0; i < sortTemp.Count; i++)
                {
                    if (dict[sortTemp[i]].Equals(max))
                    {
                        sb.Append(sortTemp[i], max);
                        dict.Remove(sortTemp[i]);
                        break;
                    }
                }
            }
            return sb.ToString();
        }

        public static string FrequencySort2(string s)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            StringBuilder[] bucket = new StringBuilder[s.Length + 1];
            StringBuilder res = new StringBuilder();
            foreach(char c in s)
            {
                if (dict.ContainsKey(c))
                    dict[c]++;
                else
                    dict.Add(c, 1);
            }
            foreach (KeyValuePair<char, int> item in dict)
            {
                if(bucket[item.Value] == null)
                    bucket[item.Value] = new StringBuilder();
                bucket[item.Value].Append(item.Key, item.Value);
            }
            for (int i = s.Length; i >= 0; i--)
            {
                if (bucket[i] != null)
                {
                    res.Append(bucket[i]);
                }
            }
            return res.ToString();
        }

        //462. Minimum Moves to Equal Array Elements II
        public static int MinMoves2(int[] nums)
        {
            Array.Sort(nums);
            int res = 0;
            int left = 0;
            int right = nums.Length-1;
            while (left < right)
            {
                res += nums[right] - nums[left];
                left++;
                right--;
            }
            return res;
        }

        #endregion

        #region 20180125

        //508. Most Frequent Subtree Sum
        public int[] FindFrequentTreeSum(TreeNode root)
        {
            List<int> sums = new List<int>();
            if (root == null)
                return sums.ToArray();
            FindFrequentTreeSumHelp(root, sums);
            Dictionary<int, int> dic = new Dictionary<int, int>();
            foreach (int v in sums)
            {
                if (dic.ContainsKey(v))
                    dic[v]++;
                else
                    dic.Add(v, 1);
            }
            int max = dic.Values.Max();
            sums.Clear();
            foreach(KeyValuePair<int,int> item in dic)
            {
                if (item.Value == max)
                    sums.Add(item.Key);
            }
            return sums.ToArray();
        }
        public static int FindFrequentTreeSumHelp(TreeNode node, List<int> sums)
        {
            if (node == null)
            {
                return 0;
            }
            int sum = node.val + FindFrequentTreeSumHelp(node.left, sums) + FindFrequentTreeSumHelp(node.right, sums);
            sums.Add(sum);
            return sum;
        }

        //260. Single Number III
        public int[] SingleNumber(int[] nums)
        { 
            List<int> res = new List<int>();
            Array.Sort(nums);
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    i++;
                }
                else
                {
                    res.Add(nums[i]);
                }
            }
            if (nums.Length > 1 && nums[nums.Length - 1] != nums[nums.Length - 2])
                res.Add(nums[nums.Length - 1]);
            return res.ToArray();
        }

        #endregion

        #region 20180124

        //739. Daily Temperatures 暴力超时
        public int[] DailyTemperatures(int[] temperatures)
        {
            int length = temperatures.Length;
            int[] res = new int[length];
            for (int i = 0; i < length; i++)
            {
                res[i] = 0;
            }
            if (length == 0)
                return res;
            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (temperatures[j] > temperatures[i])
                    {
                        res[i] = j - i;
                        break;
                    }
                }
            }
            return res;
        }
        //从后往前计算，勉强过
        public int[] DailyTemperatures2(int[] temperatures)
        {
            int length = temperatures.Length;
            int[] res = new int[length];
            if (length == 0)
                return res;
            res[length - 1] = 0;
            for (int i = length - 2; i >= 0; i--)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (temperatures[j] == temperatures[i])
                    {
                        if (res[j] == 0)
                            res[i] = 0;
                        else
                            res[i] = res[j] + j - i;
                        break;
                    }
                    else if (temperatures[j] < temperatures[i])
                    {
                        if (res[j] == 0)
                        {
                            res[i] = 0;
                            break;
                        }
                    }
                    else if(temperatures[j] > temperatures[i])
                    {
                        res[i] = j - i;
                        break;
                    }
                }
            }
            return res;
        }

        public int[] DailyTemperatures3(int[] temperatures)
        {
            Stack<int> stakc = new Stack<int>();
            int[] res = new int[temperatures.Length];
            for (int i = 0; i < temperatures.Length; i++)
            {
                while (!(stakc.Count == 0) && temperatures[i] > temperatures[stakc.Peek()])
                {
                    int idx = stakc.Pop();
                    res[idx] = i - idx;
                }
                stakc.Push(i);
            }
            return res;
        }

        #endregion

        #region 20180122

        //413. Arithmetic Slices
        public static int NumberOfArithmeticSlices(int[] A)
        {
            int res = 0;
            int added = 0;
            for (int i = 2; i < A.Length; i++)
            {
                if (A[i - 1] - A[i] == A[i - 2] - A[i - 1])
                    res += ++added;
                else
                    added = 0;
            }
            return res;
        }

        //515. Find Largest Value in Each Tree Row 
        public IList<int> LargestValues(TreeNode root)
        {
            List<int> res = new List<int>();
            //二叉树广度搜索模版
            Queue<TreeNode> queue = new Queue<TreeNode>();
            if(root != null)
                queue.Enqueue(root);
            while (queue.Count > 0)
            {
                int count = queue.Count;
                int tempMax = int.MinValue;
                for (int i = 0; i < count; i++)
                {
                    TreeNode node = queue.Dequeue();
                    if (node.left != null)
                        queue.Enqueue(node.left);
                    if (node.right != null)
                        queue.Enqueue(node.right);
                    tempMax = Math.Max(tempMax, node.val);
                }
                res.Add(tempMax);
            }
            return res;
        }

        #endregion

        #region 20180121

        //406. Queue Reconstruction by Height
        public static int[,] ReconstructQueue(int[,] people)
        {
            List<Tuple<int, int>> temp = new List<Tuple<int, int>>();
            List<Tuple<int, int>> temp2 = new List<Tuple<int, int>>(people.GetLength(0));
            for (int i = 0; i < people.GetLength(0); i++)
            {
                temp.Add(new Tuple<int, int>(people[i, 0], people[i, 1]));
            }
            temp.Sort((x, y) =>
            {
                int result = y.Item1.CompareTo(x.Item1);
                return result == 0 ? x.Item2.CompareTo(y.Item2) : result;
            });
            for (int i = 0; i < temp.Count; i++)
            {
                temp2.Insert(temp[i].Item2, temp[i]);
            }
            for(int i = 0; i  < people.GetLength(0); i ++)
            {
                people[i, 0] = temp2[i].Item1;
                people[i, 1] = temp2[i].Item2;
            }
            return people;
        }

        #endregion

        #region 20180119

        //763. Partition Labels
        public static IList<int> PartitionLabels(string S)
        {
            if (S == null || S.Length == 0)
                return null;
            List<int> res = new List<int>();
            int[] map = new int[26];
            for (int i = 0; i < S.Length; i++)
            {
                map[S[i] - 'a'] = i;
            }
            int last = 0;
            int start = 0;
            for (int i = 0; i < S.Length; i++)
            {
                last = Math.Max(last, map[S[i] - 'a']);
                if (last == i)
                {
                    res.Add(last - start + 1);
                    start = last + 1;
                }
            }
            return res;
        }

        #endregion

        #region 20180118

        //122. Best Time to Buy and Sell Stock II
        public int MaxProfit(int[] prices)
        {
            int total = 0;
            for (int i = 0; i < prices.Length - 1; i++)
            {
                if (prices[i + 1] > prices[i])
                    total += prices[i + 1] - prices[i];
            }
            return total;
        }
        public int MaxProfit2(int[] prices)
        {
            if (prices.Length == 0)
                return 0;
            int sum = 0;
            int startIndex = 0;
            int i = 0;
            for (i = 1; i < prices.Length; i++)
            {
                if (prices[i] < prices[i - 1])
                {
                    sum += prices[i - 1] - prices[startIndex];//在i-1处卖出
                    startIndex = i;//在i处重新买入
                }
            }
            //最后一次计算利润
            if (prices[i - 1] > prices[startIndex])
                sum += prices[i - 1] - prices[startIndex];
            return sum;
        }

        #endregion

        #region 20180117

        //216. Combination Sum III 找出1-9之间k个数之和为n的所有组合
        public static IList<IList<int>> CombinationSum3(int k, int n)
        {
            List<IList<int>> res = new List<IList<int>>();
            CombinationSum3Help(res, new List<int>(), k, 1, n);
            return res;
        }
        public static void CombinationSum3Help(List<IList<int>> res, List<int> comb,int k,int start,int n)
        {
            if (comb.Count == k && n == 0)
            {
                List<int> li = new List<int>(comb);
                res.Add(li);
                return;
            }
            for (int i = start; i <= 9; i++)
            {
                comb.Add(i);
                CombinationSum3Help(res, comb, k, i + 1, n - i);
                comb.RemoveAt(comb.Count - 1);
            }
        }

        //565. Array Nesting ***
        public static int ArrayNesting(int[] nums)
        {
            int len = nums.Length;
            int res = 0;
            for (int i = 0; i < len; i++)
            {
                //遇到重复的节点
                if (nums[i] != len)
                {
                    int count = 0;
                    int t = i;
                    while (nums[t] != len)
                    {
                        count++;
                        int k = nums[t];
                        //将计算过的数据节点改变，避免形成环
                        nums[t] = len;
                        t = k;
                    }
                    res = Math.Max(res, count);
                }
            }
            return res;
        }

        #endregion

        #region 20180116

        //238. Product of Array Except Self
        public static int[] ProductExceptSelf(int[] nums)
        {
            int n = nums.Length;
            int[] fwd = new int[n];
            int[] bwd = new int[n];
            int[] res = new int[n];
            for (int i = 0; i < n; i++)
            {
                fwd[i] = 1;
                bwd[i] = 1;
            }
            for (int i = 0; i < n - 1; i++)
            {
                fwd[i + 1] = fwd[i] * nums[i];
            }
            for (int i = n - 1; i > 0; i--)
            {
                bwd[i - 1] = bwd[i] * nums[i];
            }
            for (int i = 0; i < n; i++)
            {
                res[i] = fwd[i] * bwd[i];
            }
            return res;
        }

        //442. Find All Duplicates in an Array
        public IList<int> FindDuplicates(int[] nums)
        {
            List<int> res = new List<int>();
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (set.Contains(nums[i]))
                {
                    res.Add(nums[i]);
                }
                else
                {
                    set.Add(nums[i]);
                }
            }
            return res;
        }

        //338. Counting Bits 暴力法
        public int[] CountBits(int num)
        {
            List<int> res = new List<int>();
            for (int i = 0; i <= num; i++)
            {
                int count = 0;
                int temp = i;
                while (temp > 0)
                {
                    if ((temp & 1) == 1)
                        count++;
                    temp = temp >> 1;
                }
                res.Add(count);
            }
            return res.ToArray();
        }
        //特殊解法 0(n) 计算0-num中每个值对应二进制中1的个数
        public int[] CountBits2(int num)
        {
            int[] res = new int[num + 1];
            for (int i = 0; i <= num; i++)
            {
                if (i % 2 == 0)//偶数
                    res[i] = res[i / 2];
                else           //奇数
                    res[i] = res[i / 2] + 1;
            }
            return res;
        }

        //654. Maximum Binary Tree
        public static TreeNode ConstructMaximumBinaryTree(int[] nums)
        {
            return ConstructMaximumBinaryTreeHelp(nums, 0, nums.Length - 1);
        }
        public static TreeNode ConstructMaximumBinaryTreeHelp(int[] nums,int left,int right)
        {
            if (left > right)
                return null;
            int max = nums[left];
            int maxIndex = left;
            for (int i = left + 1; i <= right; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                    maxIndex = i;
                }
            }
            TreeNode node = new TreeNode(max);
            node.left = ConstructMaximumBinaryTreeHelp(nums, left, maxIndex - 1);
            node.right = ConstructMaximumBinaryTreeHelp(nums, maxIndex + 1, right);
            return node;
        }

        #endregion

        #region 20180115

        //687. Longest Univalue Path 求最长的相同值路径
        public int LongestUnivaluePath(TreeNode root)
        {
            int[] res = new int[1];
            if (root != null) LongestUnivaluePathDfs(root, res);
            return res[0];
        }
        public int LongestUnivaluePathDfs(TreeNode node,int[] res)
        {
            int l = node.left != null ? LongestUnivaluePathDfs(node.left,res) : 0;
            int r = node.right != null ? LongestUnivaluePathDfs(node.right,res) : 0;
            int resl = node.left != null && node.left.val == node.val ? l + 1 : 0;
            int resr = node.right != null && node.right.val == node.val ? r + 1 : 0;
            res[0] = Math.Max(res[0], resl + resr);
            return Math.Max(resl, resr);
        }

        //760. Find Anagram Mappings
        public int[] AnagramMappings(int[] A, int[] B)
        {
            List<int> res = new List<int>();
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = B.Length - 1; i >= 0; i--)
            {
                if (!dic.ContainsKey(B[i]))
                {
                    dic.Add(B[i], i);
                }
            }
            for (int i = 0; i < A.Length; i++)
            {
                res.Add(dic[A[i]]);
            }
            return res.ToArray();
        }

        //762. Prime Number of Set Bits in Binary Representation
        public static int CountPrimeSetBits(int L, int R)
        {
            if (L > R)
                return 0;
            int res = 0;
            while (L <= R)
            {
                int temp = L;
                int count = 0;
                while (temp > 0)
                {
                    if ((temp & 1) == 1)
                        count++;
                    temp = temp >> 1;
                }
                bool isPri = true;
                for (int i = 2; i <= Math.Sqrt(count); i++)
                {
                    if (count % i == 0)
                    {
                        isPri = false;
                        break;
                    }
                }
                if (isPri && count != 1)
                {
                    res++;
                }
                L++;
            }
            return res;
        }

        #endregion

        #region 20180114

        //671. Second Minimum Node In a Binary Tree
        public static int FindSecondMinimumValue(TreeNode root)
        {
            List<int> res = new List<int>();
            Stack<TreeNode> stack = new Stack<TreeNode>();
            while (root != null || stack.Count != 0)
            {
                while (root != null)
                {
                    stack.Push(root);
                    root = root.left;
                }
                root = stack.Pop();
                res.Add(root.val);
                root = root.right;
            }
            res.Sort();
            if (res.Count == 0 || res.First() == res.Last())
                return -1;
            int temp = res[0];
            foreach (int v in res)
            {
                if (v != temp)
                {
                    temp = v;
                    break;
                }
            }
            return temp;
        }

        //501. Find Mode in Binary Search Tree
        //查找一个搜索二叉树中最长出现的几个节点值
        public int[] FindMode(TreeNode root)
        {
            List<int> res = new List<int>();
            Dictionary<int, int> dic = new Dictionary<int, int>();
            FindModeHelp(root, ref dic);
            if (dic.Count != 0)
            {
                int max = dic.Values.Max();
                foreach (int key in dic.Keys)
                {
                    if (dic[key] == max)
                        res.Add(key);
                }
            }
            return res.ToArray();
        }
        public static void FindModeHelp(TreeNode node,ref Dictionary<int,int> dic)
        {
            if (node == null) return;
            FindModeHelp(node.left, ref dic);
            if (dic.ContainsKey(node.val))
            {
                dic[node.val]++;
            }
            else
            {
                dic.Add(node.val, 1);
            }
            FindModeHelp(node.right, ref dic);
        }

        //475. Heaters
        public static int FindRadius(int[] houses, int[] heaters)
        {
            Array.Sort(houses);
            Array.Sort(heaters);

            int res = 0;
            int j = 0;
            for (int i = 0; i < houses.Length; i++)
            {
                while (j < heaters.Length - 1
                    && (Math.Abs(heaters[j + 1] - houses[i]) <= Math.Abs(heaters[j] - houses[i])))
                    {
                    j++;
                }
                res = Math.Max(res, Math.Abs(heaters[j] - houses[i]));
            }
            return res;
        }

        //459. Repeated Substring Pattern
        public static bool RepeatedSubstringPattern(string s)
        {
            char[] cs = s.ToCharArray();
            for (int i = 1; i < s.Length; i++)
            {
                //找到重复节点,并且刚好被总长度除尽,截取判断
                if (s[i] == s[0] && s.Length % (i) == 0)
                {
                    //截取出合适的字符串
                    string temp = s.Substring(0, i);
                    int begin = i;
                    while ((begin + i) <= s.Length)
                    {
                        //截取出下一同样长度的字符串
                        string ss = s.Substring(begin, i);
                        if (ss != temp)
                            break;
                        //比较到了最后，且全部通过，返回true
                        if (begin + i == s.Length)
                            return true;
                        begin += i;
                    }
                }
            }
            return false;
        }

        #endregion

        #region 20180113

        //窗口滑动问题
        public static List<int> SliderDown(int[] nums,int k)
        {
            List<int> res = new List<int>();
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(0);
            int index = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (i - index >= k)
                {
                    index++;
                    res.Add(nums[queue.First()]);
                }
                if (i - queue.First() >= k)
                    queue.Dequeue();
                int temp = nums[i];
                if (queue.Count != 0 && temp <= nums[queue.First()])
                {
                    queue.Enqueue(i);
                }
                else
                {
                    queue.Clear();
                    queue.Enqueue(i);
                }
            }
            res.Add(queue.Dequeue());
            return res;
        }

        // //438. Find All Anagrams in a String
        public static IList<int> FindAnagrams2(string s, string p)
        {
            int[] chars = new int[26];
            List<int> res = new List<int>();

            if (s == null || p == null || s.Length < p.Length)
                return res;
            foreach (char c in p)
            {
                chars[c - 'a']++;
            }
            int start = 0, end = 0, count = p.Length;
            while (end < s.Length)
            {
                if (end - start == p.Length)
                {
                    if (chars[s[start] - 'a']++ >= 0)
                    {
                        count++;
                    }
                    start++;
                }
                if (--chars[s[end]-'a'] >= 0)
                    count--;
                end++;
                if (count == 0)
                    res.Add(start);
            }
            return res;
        }

        //438. Find All Anagrams in a String 超时
        public static IList<int> FindAnagrams(string s, string p)
        {
            List<int> res = new List<int>();
            for (int i = 0; i < s.Length - p.Length + 1; i++)
            {
                string temp = s.Substring(i, p.Length);
                if (FindAnagramsHelp(temp, p))
                    res.Add(i);
            }
            return res;
        }
        public static bool FindAnagramsHelp(string a,string b)
        {
            if (a.Length != b.Length)
                return false;
            List<char> bs = new List<char>(b);
            for (int i = 0; i < a.Length; i++)
            {
                if (!bs.Contains(a[i]))
                    return false;
                else
                    bs.Remove(a[i]);
            }
            return true;
        }

        //437. Path Sum III
        public static int PathSum3(TreeNode root, int sum)
        {
            Count = 0;
            Stack<int> temp = new Stack<int>();
            PathSumHelp(root, temp, sum);
            return Count;
        }
        public static int Count = 0;
        public static void PathSumHelp(TreeNode node,Stack<int> temp,int sum)
        {
            if (node == null)
                return;
            temp.Push(node.val);
            if (node.val == sum)
                Count++;
            int tempSum = 0;
            List<int> tList = new List<int>(temp);
            for (int i = 0; i < tList.Count; i++)
            {
                tempSum += tList[i];
                if (tempSum == sum && i != 0)
                {
                    Count++;
                }
            }
            PathSumHelp(node.left, temp, sum);
            PathSumHelp(node.right, temp, sum);
            temp.Pop();
        }

        #endregion

        #region 20180112

        //303. Range Sum Query - Immutable
        public class NumArray
        {
            List<int> sums = new List<int>();

            public NumArray(int[] nums)
            {
                int sum = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    sum += nums[i];
                    sums.Add(sum);
                }
            }

            public int SumRange(int i, int j)
            {
                if (i > j || i >= sums.Count || j >= sums.Count)
                    return 0;
                if (i == 0)
                    return sums[j];
                return (sums[j] - sums[i - 1]);
            }
        }

        //350. Intersection of Two Arrays II
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            List<int> n1 = new List<int>(nums1);
            List<int> n2 = new List<int>(nums2);
            List<int> res = new List<int>();
            for (int i = 0; i < n1.Count; i++)
            {
                int t = n2.IndexOf(n1[i]);
                if (t != -1)
                {
                    res.Add(n1[i]);
                    n2.RemoveAt(t);
                }
            }
            return res.ToArray();
        }

        //345. Reverse Vowels of a String
        public string ReverseVowels(string s)
        {
            HashSet<char> set = new HashSet<char>()
            {
                'a','e','i','o', 'u','A', 'E','I', 'O','U'
            };
            char[] cs = s.ToCharArray();
            int left = 0;
            int right = s.Length - 1;
            while (left < right)
            {
                while (left < right && !set.Contains(cs[left]))
                {
                    left++;
                }
                while (left < right && !set.Contains(cs[right]))
                {
                    right--;
                }
                char temp = cs[left];
                cs[left] = cs[right];
                cs[right] = temp;
                left++;
                right--;
            }
            return new string(cs);
        }

        //342. Power of Four
        public static bool IsPowerOfFour(int num)
        {
            if (num < 1)
                return false;
            long sum = 1;
            while (sum <= num)
            {
                if (sum == num)
                    return true;
                sum *= 4;
            }
            return false;
        }

        #endregion

        #region 20180111



        #endregion

        #region 20180110

        //232. Implement Queue using Stacks
        public class MyQueue
        {
            Stack<int> data;
            /** Initialize your data structure here. */
            public MyQueue()
            {
                data = new Stack<int>();
            }

            /** Push element x to the back of queue. */
            public void Push(int x)
            {
                List<int> temp = new List<int>(data);
                data.Clear();
                data.Push(x);
                for (int i = temp.Count - 1; i >= 0; i--)
                {
                    data.Push(temp[i]);
                }
            }

            /** Removes the element from in front of queue and returns that element. */
            public int Pop()
            {
                return data.Pop();
            }

            /** Get the front element. */
            public int Peek()
            {
                return data.Peek();
            }

            /** Returns whether the queue is empty. */
            public bool Empty()
            {
                return data.Count == 0;
            }
        }

        //225. Implement Stack using Queues
        public class MyStack
        {
            Queue<int> data;
            /** Initialize your data structure here. */
            public MyStack()
            {
                data = new Queue<int>();
            }

            /** Push element x onto stack. */
            public void Push(int x)
            {
                List<int> temp = new List<int>(data);
                data.Clear();
                data.Enqueue(x);
                foreach (int v in temp)
                {
                    data.Enqueue(v);
                }
            }

            /** Removes the element on top of the stack and returns that element. */
            public int Pop()
            {
                return data.Dequeue();
            }

            /** Get the top element. */
            public int Top()
            {
                return data.First();
            }

            /** Returns whether the stack is empty. */
            public bool Empty()
            {
                return data.Count == 0;
            }
        }

        //205. Isomorphic Strings
        public static bool IsIsomorphic(string s, string t)
        {
            if (s.Length != t.Length)
                return false;
            Dictionary<char, char> dic = new Dictionary<char, char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!dic.ContainsKey(s[i]))
                {
                    if (dic.ContainsValue(t[i]))
                        return false;
                    dic.Add(s[i], t[i]);
                }
                else
                {
                    if (dic[s[i]] != t[i])
                        return false;
                }
            }
            return true;
        }

        //202. Happy Number
        public static bool IsHappy(int n)
        {
            HashSet<int> set = new HashSet<int>();
            while (n != 1 || !set.Contains(n))
            {
                set.Add(n);
                int sum = 0;
                while (n >= 10)
                {
                    int t = n % 10;
                    sum += (t * t);
                    n /= 10;
                }
                sum += (n * n);
                n = sum;
            }
            return n == 1;
        }

        //191. Number of 1 Bits
        public int HammingWeight(uint n)
        {
            int count = 0;
            while (n > 0)
            {
                if ((n & 1) == 1)
                    count++;
                n = n >> 1;
            }
            return count;
        }

        //190. Reverse Bits
        public static uint reverseBits(uint n)
        {
            uint res = 0;
            int f = 31;
            while (n > 0)
            {
                int v = (n & 1) == 0 ? 0 : 1;
                if (v == 1)
                    res += (uint)Math.Pow(2, f);
                f--;
                n = n >> 1;
            }
            return res;
        }

        //172. Factorial Trailing Zeroes
        public static int TrailingZeroes(int n)
        {
            return n == 0 ? 0 : n/5 + TrailingZeroes(n / 5);
        }

        //125. Valid Palindrome
        public static bool IsPalindrome(string s)
        {
            s = s.ToLower();
            int left = 0;
            int right = s.Length - 1;
            while (left < right)
            {
                while (!IsNumOrChac(s[left]) && left < right)
                {
                    left ++;
                }
                while (!IsNumOrChac(s[right]) && left < right)
                {
                    right--;
                }
                if (s[left] != s[right])
                    return false;
                left++;
                right--;
            }
            return true;
        }
        public static bool IsNumOrChac(char c)
        {
            if ((c >= 'a' && c <= 'z') || (c >= '0' && c <= '9'))
                return true;
            return false;
        }

        //119. Pascal's Triangle II
        public static IList<int> GetRow(int rowIndex)
        {
            int[] res = new int[rowIndex + 1];
            res[0] = 1;
            for (int i = 1; i < rowIndex + 1; i++)
            {
                for (int j = i; j >= 1; j--)
                {
                    res[j] += res[j - 1];
                }
            }
            return res;
        }

        //231. Power of Two
        public bool IsPowerOfTwo(int n)
        {
            if (n <= 0)
                return false;
            while (n > 1)
            {
                if ((n & 1) == 1)
                {
                    return false;
                }
                n = n >> 1;
            }
            return true;
        }

        //290. Word Pattern
        public bool WordPattern(string pattern, string str)
        {
            string[] strs = str.Split(' ');
            if (pattern.Length != strs.Count())
                return false;
            Dictionary<char, string> dic = new Dictionary<char, string>(pattern.Length);
            for (int i = 0; i < pattern.Length; i++)
            {
                char c = pattern[i];
                string cur = strs[i];
                if (!dic.ContainsKey(c))
                {
                    if (dic.ContainsValue(cur))
                        return false;
                    dic.Add(c, cur);
                }
                else
                {
                    if (cur != dic[c])
                        return false;
                }
            }
            return true;
        }

        //263. Ugly Number
        public bool IsUgly(int num)
        {
            if (num == 1) return true;
            if (num == 0) return false;
            while (num % 2 == 0) num = num / 2;
            while (num % 3 == 0) num = num / 3;
            while (num % 5 == 0) num = num / 5;
            return num == 1;
        }

        //257. Binary Tree Paths 打印二叉树的所有path
        public IList<string> BinaryTreePaths(TreeNode root)
        {
            string str = "";
            IList<string> res = new List<string>();
            BinaryTreePathsHelp(root,str,res);
            return res;
        }
        public void BinaryTreePathsHelp(TreeNode root,string str, IList<string> res)
        {
            if (root == null)
                return;
            if (root.left == null && root.right == null)
            {
                str += root.val + "";
                res.Add(str);
                return;
            }
            str += root.val + "->";
            if (root.left != null)
            {
                BinaryTreePathsHelp(root.left, str, res);
            }
            if (root.right != null)
            {
                BinaryTreePathsHelp(root.right, str, res);
            }
        }

        #endregion

        #region 20180109

        //168. Excel Sheet Column Title 1='A'
        public static string ConvertToTitle(int n)
        {
            StringBuilder sb = new StringBuilder();
            while (n > 0)
            {
                n--;
                sb.Insert(0, (char)('A' + n % 26));
                n /= 26;
            }
            return sb.ToString();
        }

        //155. Min Stack
        public class MinStack
        {
            Stack<int> curStack;
            Stack<int> minSatck;
            /** initialize your data structure here. */
            public MinStack()
            {
                curStack = new Stack<int>();
                minSatck = new Stack<int>();
            }

            public void Push(int x)
            {
                int min = minSatck.Count == 0 ? int.MaxValue : minSatck.Peek();
                min = Math.Min(min, x);
                minSatck.Push(min);
                curStack.Push(x);
            }

            public void Pop()
            {
                minSatck.Pop();
                curStack.Pop();
            }

            public int Top()
            {
                return curStack.Peek();
            }

            public int GetMin()
            {
                return minSatck.Peek();
            }
        }

        //111. Minimum Depth of Binary Tree
        public int MinDepth(TreeNode root)
        {
            if (root == null)
                return 0;
            if (root.left == null && root.right == null)
                return 1;
            if (root.left == null)
            {
                return MinDepth(root.right) + 1;
            }
            if (root.right == null)
            {
                return MinDepth(root.left) + 1;
            }
            return Math.Min(MinDepth(root.left), MinDepth(root.right)) + 1;
        }

        //88. Merge Sorted Array
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int[] res = new int[m + n];
            int i1 = 0;
            int i2 = 0;
            int index = 0;
            while (i1 < m && i2 < n)
            {
                if (nums1[i1] <= nums2[i2])
                {
                    res[index++] = nums1[i1++];
                }
                else
                {
                    res[index++] = nums2[i2++];
                }
            }
            while (i1 < m)
            {
                res[index++] = nums1[i1++];
            }
            while (i2 < n)
            {
                res[index++] = nums2[i2++];
            }
            for (int i = 0; i < res.Length; i++)
            {
                nums1[i] = res[i];
            }
        }

        //66. Plus One
        public int[] PlusOne(int[] digits)
        {
            if (digits == null || digits.Length == 0)
                return digits;
            int plus = 0;
            List<int> res = new List<int>();
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                int temp = digits[i];
                if (i == digits.Length - 1)
                {
                    temp += 1;
                }
                else
                {
                    temp += plus;
                }
                if (temp >= 10)
                {
                    plus = 1;
                    temp -= 10;
                }
                else {
                    plus = 0;
                }
                res.Add(temp);
            }
            if (plus == 1)
                res.Add(1);
            res.Reverse();
            return res.ToArray();
        }

        //58. Length of Last Word
        public int LengthOfLastWord(string s)
        {
            int count = 0;
            bool flag = false;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] != ' ')
                {
                    flag = true;
                    count++;
                }
                if (s[i] == ' ' && flag)
                {
                    return count;
                }
                if (i == 0 && flag)
                {
                    return count;
                }
            }
            return 0;
        }

        #endregion

        #region 20180108

        //720. Longest Word in Dictionary 失败，没有根据字典序列排序，思路有问题
        public static string LongestWord(string[] words)
        {
            if (words == null || words.Length == 0)
                return "";
            List<string> temp = new List<string>(words);
            for(int index = 0; index < temp.Count ; index ++)
            {
                string str = temp[index];
                for(int i = 1; i < str.Length; i ++)
                {
                    string s = str.Substring(0, i);
                    if (!words.Contains(s))
                    {
                        temp.Remove(str);
                        break;
                    }
                }
            }
            temp.Sort((string a,string b)=> { return a.Length.CompareTo(b.Length); });
            for (int i = temp.Count - 1; i >= 0; i --)
            {
                if (temp[i].Length < temp.Last().Length)
                    return temp[i + 1];
            }
            return temp[0];
        }

        //720. Longest Word in Dictionary
        public static string LongestWord2(string[] words)
        {
            //排序,这个排序已经是按照长度优先，字典序其后的方式进行的
            Array.Sort(words);
            //temp是关键，将前面满足条件的短字符串先放进去
            HashSet<string> temp = new HashSet<string>();
            string res = "";
            foreach(string s in words)
            {
                //判断是长度为1或者在截取n-1位，在前面的较短的temp的查找
                if (s.Length == 1 || temp.Contains(s.Substring(0, s.Length - 1)))
                {
                    res = s.Length > res.Length ? s : res;
                    temp.Add(s);
                }
            }
            return res;
        }

        //443. String Compression ** 
        public static int Compress(char[] chars)
        {
            int start = 0;
            for (int end = 0, count = 0; end < chars.Length; end++)
            {
                count++;
                if (end == chars.Length - 1 || chars[end] != chars[end + 1])
                {
                    chars[start] = chars[end];
                    start++;
                    if (count != 1)
                    {
                        char[] arr = (count + "").ToCharArray();
                        for (int i = 0; i < arr.Length; i++, start++)
                        {
                            chars[start] = arr[i];
                        }
                    }
                    count = 0;
                }
            }
            return start;
        }

        //204. Count Primes 求小于n的2所有素数
        public static int CountPrimes(int n)
        {
            if (n <= 2)
                return 0;
            int count = n - 2;
            for (int i = 2; i < n; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        count--;
                        break;
                    }
                }
            }
            return count;
        }

        //FirstBadVersion
        public static int FirstBadVersion(int n)
        {
            int left = 1;
            int right = n;
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (!IsBadVersion(mid))
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
            }
            return left;
        }
        static bool IsBadVersion(int version)
        {
            if (version >= 1)
                return false;
            return true;
        }

        #endregion

        #region 20180107

        //112. Path Sum
        public static bool HasPathSum(TreeNode root, int sum)
        {
            if (root == null)
                return false;
            return HasPathSumHelp(root, sum, 0);
        }
        public static bool HasPathSumHelp(TreeNode root, int sum, int temp)
        {
            if (root == null)
            {
                return false;
            }
            temp += root.val;
            if (root.left == null && root.right == null)
            {
                if (temp == sum)
                    return true;
                else
                    return false;
            }
            bool res = false;
            if (root.left != null)
            {
                res |= HasPathSumHelp(root.left, sum, temp);
            }
            if (root.right != null)
            {
                res |= HasPathSumHelp(root.right, sum, temp);
            }
            temp -= root.val;
            return res;
        }

        //108. Convert Sorted Array to Binary Search Tree
        //将数组转换成搜索树
        public static TreeNode SortedArrayToBST(int[] nums)
        {
            return SortedArrayToBSTHelp(nums, 0, nums.Count() - 1);
        }

        public static TreeNode SortedArrayToBSTHelp(int[] nums,int left,int right)
        {
            if (left > right) return null;
            int mid = (left + right) / 2;
            TreeNode cur = new TreeNode(nums[mid]);
            cur.left = SortedArrayToBSTHelp(nums, left, mid - 1);
            cur.right = SortedArrayToBSTHelp(nums,mid+1,right);
            return cur;
        }

        //107. Binary Tree Level Order Traversal II 广度搜索
        public static IList<IList<int>> LevelOrderBottom(TreeNode root)
        {
            IList<IList<int>> res = new List<IList<int>>();
            Queue<TreeNode> queue = new Queue<TreeNode>();

            if (root == null) return res;

            queue.Enqueue(root);
            while (queue.Count != 0)
            {
                int levelNum = queue.Count;
                List<int> temp = new List<int>();
                for (int i = 0; i < levelNum; i++)
                {
                    if (queue.Peek().left != null)
                        queue.Enqueue(queue.Peek().left);
                    if (queue.Peek().right != null)
                        queue.Enqueue(queue.Peek().right);
                    temp.Add(queue.Dequeue().val);
                }
                res.Insert(0, temp);
            }
            
            return res;
        }

        //深度搜索
        public static IList<IList<int>> LevelOrderBottom2(TreeNode root)
        {
            IList<IList<int>> res = new List<IList<int>>();

            levelMaker(res, root, 0);

            return res;
        }
        public static void levelMaker(IList<IList<int>> list, TreeNode root, int level)
        {
            if (root == null)
                return;
            if (level >= list.Count)
            {
                list.Insert(0, new List<int>());
            }
            levelMaker(list, root.left, level + 1);
            levelMaker(list, root.right, level + 1);
            list[list.Count - level - 1].Add(root.val);
        }

        //69. Sqrt(x) 牛顿法求根
        public static int MySqrt(int x)
        {
            double res = 1;
            double temp = 1;
            do
            {
                temp = res;
                res = 0.5f * (res + x / res);
            }
            while (Math.Abs(res - temp) > 0.00001);
            return (int)res;
        }

        #endregion

        #region 20180106

        //268. Missing Number
        public static int MissingNumber(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;
            if (nums.Length == 1 && nums[0] != 0)
                return 0;
            Array.Sort(nums);
            int max = nums[nums.Length - 1];
            int index = 0;
            while (index < nums.Length)
            {
                if (index == nums[index])
                    index++;
                else
                    return index;
            }
            return max + 1;
        }

        public static int MissingNumber2(int[] nums)
        {
            if (nums == null)
                return 0;
            int MaxSum = nums.Length * (nums.Length + 1) / 2;
            int curSum = 0;
            foreach (int v in nums)
            {
                curSum += v;
            }
            return MaxSum - curSum;
        }

        //633. Sum of Square Numbers
        public static bool JudgeSquareSum(int c)
        {
            if (c < 0)
                return false;
            int left = 0;
            int right = (int)Math.Sqrt(c);
            while (left <= right)
            {
                int cur = left * left + right * right;
                if (cur < c)
                    left++;
                else if (cur > c)
                    right--;
                else
                    return true;
            }
            return false;
        }

        //686. Repeated String Match
        public static int RepeatedStringMatch(string A, string B)
        {
            int count = 0;
            StringBuilder sb = new StringBuilder();
            while (sb.Length < B.Length)
            {
                sb.Append(A);
                count++;
            }
            if (sb.ToString().Contains(B)) return count;
            if (sb.Append(A).ToString().Contains(B)) return ++count;
            return -1;
        }

        //198. House Robber 递归解法
        public static int Rob(int[] nums)
        {
            return RobHelp(nums, nums.Length - 1);
        }
        public static int RobHelp(int[] nums, int n)
        {
            if (n < 0)
                return 0;
            return Math.Max(nums[n] + RobHelp(nums, n - 2), RobHelp(nums, n - 1));
        }

        //198. House Robber DP解法
        public static int Rob2(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;
            if (nums.Length == 1)
                return nums[0];
            int[] temp = new int[nums.Length];
            temp[0] = nums[0];
            temp[1] = Math.Max(nums[0], nums[1]);
            for (int i = 2; i < nums.Length; i++)
            {
                temp[i] = Math.Max(nums[i] + temp[i - 2], temp[i - 1]);
            }
            return temp[nums.Length - 1];
        }

        #endregion

        #region 20180104

        //189. Rotate Array ****
        public void Rotate(int[] nums, int k)
        {
            int len = nums.Length;
            if (len <= k)
                return;
            int diff = len - k;
            int[] temp = new int[diff];
            for (int i = 0; i < diff; i++)
            {
                temp[i] = nums[i];
            }
            for (int i = diff; i < len; i++)
            {
                nums[i - diff] = nums[i];
            }
            int index = 0;
            for (int i = k; i < len; i++)
            {
                nums[i] = temp[index++];
            }
        }

        public static void Rotate2(int[] nums, int k)
        {
            if (nums == null || nums.Length < 2)
                return;
            k = k % nums.Length;
            RotateHelp(nums, 0, nums.Length - k - 1);
            RotateHelp(nums, nums.Length - k, nums.Length - 1);
            RotateHelp(nums, 0, nums.Length - 1);
        }
        public static void RotateHelp(int[] nums,int i,int j)
        {
            int temp = 0;
            while (i < j)
            {
                temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;
                i++;
                j--;
            }
        }

        //594. Longest Harmonious Subsequence
        public int FindLHS(int[] nums)
        {
            if (nums == null || nums.Length <= 1)
                return 0;
            Dictionary<int, int> dic = new Dictionary<int, int>();
            foreach (int v in nums)
            {
                if (dic.ContainsKey(v))
                {
                    dic[v]++;
                }
                else
                {
                    dic.Add(v, 1);
                }
            }
            int max = 0;
            foreach (int v in dic.Keys)
            {
                if (dic.ContainsKey(v - 1))
                {
                    max = Math.Max(dic[v] + dic[v - 1], max);
                }
                if (dic.ContainsKey(v + 1))
                {
                    max = Math.Max(dic[v] + dic[v + 1], max);
                }
            }
            return max;
        }

        #endregion

        #region 20180103

        //118. Pascal's Triangle
        //对任意的n>0有 
        //f(i)=1，(n>0) 
        //f(i)=1，(n=2) 
        //C(i)=C(ii)+C(i-1)(n > 2)
        public static IList<IList<int>> Generate(int numRows)
        {
            List<IList<int>> res = new List<IList<int>>();

            if (numRows >= 1)
                res.Add(new List<int>() { 1 });
            if (numRows >= 2)
                res.Add(new List<int>() { 1, 1 });
            if (numRows >= 3)
            {
                for (int i = 3; i <= numRows; i++)
                {
                    List<int> pre = (List<int>)res[i - 1 - 1];
                    List<int> temp = new List<int>();
                    temp.Add(1);
                    for (int j = 2; j < i; j ++)
                    {
                        temp.Add(pre[j - 2] + pre[j-1]);
                    }
                    temp.Add(1);
                    res.Add(temp);
                }
            }
            return res;
        }

        //101. Symmetric Tree 对称二叉树
        public static bool IsSymmetric(TreeNode root)
        {
            return root == null || isSymmetricHelp(root.left, root.right);
        }
        public static bool isSymmetricHelp(TreeNode left,TreeNode right)
        {
            if (left == null || right == null)
                return left == right;
            if (left.val != right.val)
                return false;
            return isSymmetricHelp(left.left, right.right) && isSymmetricHelp(left.right, right.left);
        }

        //541. Reverse String II
        public static string ReverseStr(string s, int k)
        {
            char[] chs = s.ToCharArray();
            for (int i = 0; i * k < chs.Length; i +=2 )
            {
                int index = i * k;
                int beg = index;
                int end = index + k - 1 >= chs.Length ? chs.Length - 1 : index + k - 1;
                while (beg < end)
                {
                    char temp = chs[beg];
                    chs[beg] = chs[end];
                    chs[end] = temp;
                    beg++;
                    end--;
                }
            }
            return new string(chs);
        }

        #endregion

        #region 20180102

        //67. Add Binary
        public static string AddBinary2(string a, string b)
        {
            int len = Math.Min(a.Length, b.Length);
            string longStr = a.Length >= b.Length ? a : b;
            string shortStr = a.Length >= b.Length ? b : a;
            int diff = Math.Abs(a.Length - b.Length);
            int carr = 0;
            StringBuilder sb = new StringBuilder();
            for (int i = len - 1; i >= 0; i--)
            {
                int j = i + diff;
                int c1 = shortStr[i] == '0' ? 0 : 1;
                int c2 = longStr[j] == '0' ? 0 : 1;
                int sum = c1 + c2 + carr;
                if (sum <= 1)
                {
                    carr = 0;
                    sb.Append(sum);
                }
                else if (sum == 2)
                {
                    carr = 1;
                    sb.Append(0);
                }
                else if (sum == 3)
                {
                    carr = 1;
                    sb.Append(1);
                }
            }
            int index = diff - 1;
            while (index >= 0)
            {
                int c = longStr[index] == '0' ? 0 : 1;
                int sum = c + carr;
                if (sum <= 1)
                {
                    carr = 0;
                    sb.Append(sum);
                }
                else if (sum == 2)
                {
                    carr = 1;
                    sb.Append(0);
                }
                else if (sum == 3)
                {
                    carr = 1;
                    sb.Append(1);
                }
                index--;
            }
            if (carr != 0)
                sb.Append(1);
            char[] chs = sb.ToString().ToCharArray();
            Array.Reverse(chs);
            return new string(chs);
        }

        //67. Add Binary
        public static string AddBinary3(string a, string b)
        {
            string s = "";
            int c = 0, i = a.Length - 1, j = b.Length - 1;
            while (i >= 0 || j >= 0 || c >= 0)
            {
                c += i > 0 ? a[i--] - '0' : 0;
                c += j > 0 ? b[j--] - '0' : 0;
                s = (char)(c % 2 + '0') + s;
                c /= 2;
            }
            return s;
        }

        //409. Longest Palindrome 可组成最长回文子串
        public static int LongestPalindrome(string s)
        {
            if (s == "")
                return 0;
            HashSet<char> hs = new HashSet<char>();
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (hs.Contains(s[i]))
                {
                    hs.Remove(s[i]);
                    count++;
                }
                else
                {
                    hs.Add(s[i]);
                }
            }
            if (hs.Count != 0) return count * 2 + 1;
            return count * 2;
        }

        //599. Minimum Index Sum of Two Lists
        //暴力，不入流
        public static string[] FindRestaurant(string[] list1, string[] list2)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();
            for (int i = 0; i < list1.Length; i++)
            {
                int index = FindRestaurantHelp(list2, list1[i]);
                if (index != -1)
                {
                    int sum = index + i;
                    dic.Add(list1[i], sum);
                }
            }
            int max = int.MaxValue;
            foreach (int v in dic.Values)
            {
                max = Math.Min(v, max);
            }
            List<string> res = new List<string>();
            foreach (string str in dic.Keys)
            {
                if (dic[str] == max)
                    res.Add(str);
            }
            return res.ToArray();
        }
        public static int FindRestaurantHelp(string[] list,string str)
        {
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] == str)
                    return i;
            }
            return -1;
        }

        public static string[] FindRestaurant2(string[] list1, string[] list2)
        {
            Dictionary<string, int> map = new Dictionary<string, int>();

            for (int i = 0; i < list1.Length; i++)
            {
                map.Add(list1[i], i);
            }

            var res = new List<string>();

            int minSum = int.MaxValue, sum = 0;
            for (int i = 0; i < list2.Length; i++)
            {
                if (map.ContainsKey(list2[i])) {
                    sum = map[list2[i]] + i;
                    if (sum < minSum)
                    {
                        res.Clear();
                        res.Add(list2[i]);
                        minSum = sum;
                    }
                    else if (sum == minSum)
                    {
                        res.Add(list2[i]);
                    }
                }
            }
            return res.ToArray();
        }

        //697. Degree of an Array
        //public static int FindShortestSubArray(int[] nums)
        //{

        //}

        #endregion

        #region 20180101

        //628. Maximum Product of Three Numbers
        public int MaximumProduct(int[] nums)
        {
            if (nums == null || nums.Length < 3)
                return 0;
            Array.Sort(nums);
            int n = nums.Length;
            return Math.Max(nums[n - 1] * nums[n - 2] * nums[n - 3], nums[n - 1] * nums[0] * nums[1]);
        }

        //605. Can Place Flowers
        public static bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            int zeroCount = 1;
            for (int i = 0; i < flowerbed.Length; i++)
            {
                if (flowerbed[i] == 0)
                {
                    zeroCount++;
                }
                else {
                    zeroCount = 0;
                }
                if (zeroCount == 3)
                {
                    n--;
                    if (i < flowerbed.Length - 1 && flowerbed[i + 1] == 0)
                    {
                        zeroCount = 1;
                    }
                    else
                    {
                        zeroCount = 0;
                    }
                }
                if (n <= 0)
                    return true;
            }
            if (zeroCount == 2)
                n--;
            return n <= 0;
        }

        #endregion

        #region 20171231


        //645. Set Mismatch 无法理解
        public static int[] FindErrorNums(int[] nums)
        {
            int[] res = new int[2];
            foreach (int i in nums)
            {
                if (nums[Math.Abs(i) - 1] < 0)
                    res[0] = Math.Abs(i);
                else
                    nums[Math.Abs(i) - 1] *= -1;//重点
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                    res[1] = i + 1;
            }
            return res;
        }

        #endregion

        #region 20171230

        //643. Maximum Average Subarray I 暴力法，超时
        public static double FindMaxAverage(int[] nums, int k)
        {
            if (nums.Length == k)
                return (double)nums.Sum() / (double)k;
            int maxSum = int.MinValue;
            for (int i = 0; i <= nums.Length-k; i++)
            {
                int temp = 0;
                for (int j = i; j < i+k; j++)
                {
                    temp += nums[j];
                }
                maxSum = Math.Max(maxSum, temp);
            }
            return (double)maxSum / (double)k;
        }
        public static double FindMaxAverage2(int[] nums, int k)
        {
            //if (nums.Length == k)
            //    return (double)nums.Sum() / (double)k;
            //int maxSum = 0;
            //for (int i = 0; i < k; i++)
            //{
            //    maxSum += nums[i];
            //}
            //for (int i = k; i < nums.Length; i++)
            //{
            //    int temp = maxSum - nums[i - k] + nums[i];
            //    maxSum = Math.Max(temp, maxSum);
            //}
            //return (double)maxSum / (double)k;
            long sum = 0;
            for (int i = 0; i < k; i++)
            {
                sum += nums[i];
            }
            long max = sum;
            for (int i = k; i < nums.Length; i++)
            {
                sum += nums[i] - nums[i - k];
                max = Math.Max(max, sum);
            }
            return max / 1.0 / k;
        }

        //674. Longest Continuous Increasing Subsequence
        public static int FindLengthOfLCIS(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;
            int count = 1;
            int max = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > nums[i - 1])
                {
                    count++;
                }
                else {
                    max = Math.Max(max, count);
                    count = 1;
                }
            }
            max = Math.Max(max, count);
            return max;
        }

        //680. Valid Palindrome II 有效的回文
        public static bool ValidPalindrome(string s)
        {
            int lp = -1;
            int rp = s.Length;
            while (++lp < --rp)
            {
                if (s[lp] != s[rp])
                    return ValidPalindromeHelp(s, lp, rp + 1) || ValidPalindromeHelp(s, lp - 1, rp);
            }
            return true;
        }
        public static bool ValidPalindromeHelp(string s,int l,int r)
        {
            while (++l < --r)
            {
                if (s[l] != s[r]) return false; 
            }
            return true;
        }

        #endregion

        #region 20171229

        //665. Non-decreasing Array 非递减数列
        public static bool CheckPossibility(int[] nums)
        {
            int cnt = 0;//记录修改的次数
            for (int i = 1; i < nums.Length && cnt <= 1; i++)
            {
                //如果前面一个数大于当前数，假设更前面的数都已经被遍历修改过
                if (nums[i - 1] > nums[i])
                {
                    cnt++;
                    //如果前2个数<=当前数
                    if (i - 2 < 0 || nums[i - 2] <= nums[i])
                        nums[i - 1] = nums[i];
                    else
                        nums[i] = nums[i - 1];
                }
            }
            return cnt <= 1;
        }

        #endregion

        #region 20171228

        //445. Add Two Numbers II
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            List<int> list1 = new List<int>();
            ToArr(l1, ref list1);
            List<int> list2 = new List<int>();
            ToArr(l2, ref list2);
            List<int> res = new List<int>();
            int len = Math.Min(list1.Count, list2.Count);
            int i = 0;
            bool isAdd = false;
            while(i < len)
            {
                int add = isAdd ? 1 : 0;
                int val = list1[i] + list2[i] + add;
                if (val >= 10) {
                    val -= 10;
                    isAdd = true;
                }
                else
                    isAdd = false;
                res.Add(val);
                i++;
            }
            while (i < list1.Count)
            {
                if (isAdd)
                {
                    int v = list1[i] + 1;
                    if (v >= 10)
                    {
                        v -= 10;
                    }
                    else
                    {
                        isAdd = false;
                    }
                    res.Add(v);
                }
                else {
                    res.Add(list1[i]);
                }
                i++;
            }
            while (i < list2.Count)
            {
                if (isAdd)
                {
                    int v = list2[i] + 1;
                    if (v >= 10)
                    {
                        v -= 10;
                    }
                    else {
                        isAdd = false;
                    }
                    res.Add(v);
                }
                else
                {
                    res.Add(list2[i]);
                }
                i++;
            }
            if (isAdd)
            {
                res.Add(1);
            }
            res.Reverse();
            ListNode resNode = new ListNode(res[0]);
            ListNode p = resNode;
            for (int index = 1; index < res.Count; index++)
            {
                ListNode temp = new ListNode(res[index]);
                p.next = temp;
                p = p.next;
            }
            return resNode;
        }
        public static void ToArr(ListNode l,ref List<int> list)
        {
            ListNode t = l;
            while (t != null)
            {
                list.Add(t.val);
                t = t.next;
            }
            list.Reverse();
        }

        //未做
        public static ListNode AddTwoNumbers2(ListNode l1, ListNode l2)
        {
            return ReverseListNode(l1);
        }
        public static ListNode ReverseListNode(ListNode l1)
        {
            ListNode pre = null;
            while (l1 != null)
            {
                ListNode next = l1.next;
                l1.next = pre;
                pre = l1;
                l1 = next;
            }
            return pre;
        }

        //724. Find Pivot Index
        public static int PivotIndex(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return -1;
            int leftSum = 0;
            int rightSum = nums.Sum() - nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (leftSum == rightSum)
                {
                    return i;
                }
                else
                {
                    leftSum += nums[i];
                    if (i != (nums.Length - 1))
                    {
                        rightSum -= nums[i + 1];
                    }
                }
            }
            return -1;
        }

        public static int PivotIndex2(int[] nums)
        {
            int sum = nums.Count();
            int leftSum = 0;
            int index = 0;
            while (index < nums.Length)
            {
                if(sum - nums[index] == leftSum)
                    return index;
                leftSum += nums[index];
                sum -= nums[index];
                index++;
            }
            return -1;
        }

        //581. Shortest Unsorted Continuous Subarray
        public static int FindUnsortedSubarray(int[] nums)
        {
            if (nums == null)
                return 0;
            int n = nums.Length;
            int beg = -1;
            int end = -2;
            int min = nums[n-1];
            int max = nums[0];
            for (int i = 1; i < n; i++)
            {
                max = Math.Max(max, nums[i]);
                min = Math.Min(min, nums[n - 1 - i]);
                if (nums[i] < max) end = i;
                if (nums[n - 1 - i] > min) beg = n - 1 - i;
            }
            return end - beg + 1;
        }

        //506. Relative Ranks
        public static string[] FindRelativeRanks(int[] nums)
        {
            List<List<int>> pair = new List<List<int>>();
 
            for (int i = 0; i < nums.Count(); i++)
            {
                List<int> l1 = new List<int>();
                l1.Add(nums[i]);
                l1.Add(i);
                pair.Add(l1);
            }
            pair.Sort((List<int> x, List<int> y) => { return y[0].CompareTo(x[0]); });
            string[] res = new string[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0)
                    res[pair[i][1]] = "Gold Medal";
                else if (i == 1)
                    res[pair[i][1]] = "Silver Medal";
                else if (i == 2)
                    res[pair[i][1]] = "Bronze Medal";
                else
                    res[pair[i][1]] = (i + 1) + "";
            }
            return res;
        }

        //242. Valid Anagram 暴力法，效率极低
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
                return false;
            if (s == t)
                return true;
            List<char> ss = new List<char>(s.ToCharArray());
            List<char> tt = new List<char>(t.ToCharArray());
            for (int i = 0; i < ss.Count; i++)
            {
                if (!tt.Contains(ss[i]))
                {
                    return false;
                }
                tt.Remove(ss[i]);
            }
            return true;
        }
        //散列表
        public bool IsAnagram2(string s, string t)
        {
            if (s.Length != t.Length)
                return false;
            if (s == t)
                return true;
            int[] st = new int[26];
            foreach (char c in s)
            {
                st[c - 'a']++;
            }
            foreach (char c in t)
            {
                st[c - 'a']--;
            }
            foreach (int v in st)
            {
                if (v != 0) return false;
            }
            return true;
        }

        //455. Assign Cookies
        public int FindContentChildren(int[] g, int[] s)
        {
            int res = 0;
            if (g == null || s == null)
                return res;
            Array.Sort(g);
            Array.Sort(s);
            int index = 0;
            foreach (int v in g)
            {
                if (s.Count() == 0)
                    return res;
                for (;index < s.Length;)
                {
                    if (s[index++] >= v)
                    {
                        res++;
                        break;
                    }
                }
            }
            return res;
        }

        #endregion

        #region 20171227


        //543. Diameter of Binary Tree
        public int DiameterOfBinaryTree(TreeNode root)
        {
            if (root == null)
                return 0;
            int ld = DiameterOfBinaryTree(root.left);//左子树的最大直径
            int rd = DiameterOfBinaryTree(root.right);//右子树的最大直径
            int lh = GetDepth(root.left);//左子树的最大深度
            int rh = GetDepth(root.right);//右子树的最大深度
            int cDia = lh + rh;//左右子树加起来 = 当前节点的最大直径
            int dm = Math.Max(ld, rd);//左右子树的最大直径
            return Math.Max(dm, cDia);//此节点的最大深度和左右子树的最大直径比较
        }
        public static int GetDepth(TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }
            int leftDep = GetDepth(node.left);
            int rightDep = GetDepth(node.right);
            return Math.Max(leftDep, rightDep) + 1;
        }

        public static int max = int.MinValue;
        public int DiameterOfBinaryTree2(TreeNode root)
        {
            if (root == null)
                return 0;
            Diameter(root);
            return max;
        }
        public int Diameter(TreeNode root)
        {
            if (root == null)
                return 0;

            int curr = 0;
            int left = Diameter(root.left);
            int right = Diameter(root.right);

            if (root.left != null)
                curr = curr + left + 1;
            if (root.right != null)
                curr = curr + right + 1;
            max = Math.Max(curr, max);

            if (root.left != null || root.right != null)
                return Math.Max(left, right) + 1;
            return 0;
        }

        #endregion

        #region 20171226

        //747. Largest Number Greater Than Twice of Others
        public int DominantIndex(int[] nums)
        {
            if (nums == null)
                return -1;
            List<int> list = new List<int>(nums);
            int max = list.Max();
            foreach (int val in list)
            {
                if (val != max)
                {
                    if (max < val * 2)
                        return -1;
                }
            }
            return list.IndexOf(max);
        }

        //572. Subtree of Another Tree 暴力法
        public bool IsSubtree(TreeNode s, TreeNode t)
        {
            Stack<TreeNode> stack = new Stack<TreeNode>();
            while (s != null || stack.Count != 0)
            {
                while (s != null)
                {
                    if (s.val == t.val && CheckTheSame(s, t)){
                            return true;
                    }
                    stack.Push(s);
                    s = s.left;
                }
                s = stack.Pop();
                s = s.right;
            }
            return false;
        }
        public static bool CheckTheSame(TreeNode s, TreeNode t)
        {
            if (s == null && t == null)
                return true;
            if (s == null || t == null)
                return false;
            if(s.val == t.val)
                return CheckTheSame(s.left, t.left) && CheckTheSame(s.right, t.right);
            return false;
        }

        public bool IsSubtree2(TreeNode s, TreeNode t)
        {
            if (s == null)
                return false;
            if (CheckTheSame(s, t))
                return true;
            return IsSubtree(s.left, t) || IsSubtree(s.right, t);
        }

        //110. Balanced Binary Tree 判断是否是平衡二叉树
        public bool IsBalanced(TreeNode root)
        {
            if (root == null)
                return true;
            //二叉树递归问题只要考虑一个节点的执行情况
            int leftHeight = GetHeight(root.left);
            int rightHeight = GetHeight(root.right);
            if (Math.Abs(leftHeight - rightHeight) > 1)
                return false;
            else
                return IsBalanced(root.left) && IsBalanced(root.right);
        }
        public static int GetHeight(TreeNode node)
        {
            if (node == null)
                return 0;
            int left = GetHeight(node.left);
            int right = GetHeight(node.right);
            return 1 + (left > right ? left : right);
        }

        #endregion

        #region 20171225

        //507. Perfect Number
        //超时
        public bool CheckPerfectNumber(int num)
        {
            if (num <= 1)
                return true;
            int sum = 0;
            for (int i = 1; i < num; i++) {
                if (num % i == 0) {
                    sum += i;
                    if (sum == num)
                        return true;
                    else if (sum > num)
                        return false;
                }
            }
            return false;
        }
        public bool CheckPerfectNumber2(int num)
        {
            if (num == 1)
                return false;
            int sum = 1;
            for (int i = 2; i < Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    sum += i + num / i;
                }
            }
            sum++;
            return sum == num;
        }

        //53. Maximum Subarray 在一个数组中找到和最大的子数组的和
        public int MaxSubArray(int[] nums)
        {
            if (nums == null)
                return 0;
            //maxEndingHere为以当前下标为终点的数组所能达到的最大值
            int maxEndingHere = nums[0];
            int maxSoFar = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                //如果之前的最大值<0,则抛弃掉，赋值为当前值
                //否则加上当前值
                if (maxEndingHere < 0)
                    maxEndingHere = nums[i];
                else
                    maxEndingHere += nums[i];
                //取最大值
                maxSoFar = Math.Max(maxSoFar, maxEndingHere);
            }
            return maxSoFar;
        }

        public static void MaxSubArray2(int[] nums)
        {
            int maxEndingHere = nums[0];
            int maxSoFar = nums[0];
            int start = 0;
            int end = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                //如果之前的最大值<0,则抛弃掉，赋值为当前值
                //否则加上当前值
                if (maxEndingHere < 0)
                {
                    maxEndingHere = nums[i];
                    start = i;
                }
                else
                {
                    maxEndingHere += nums[i];
                }
                //取最大值
                int _res = Math.Max(maxEndingHere, maxSoFar);
                if (_res != maxSoFar)
                    end = i;
                maxSoFar = _res;
            }
            List<int> res = new List<int>();
            for (int i = start; i <= end; i++)
            {
                Console.Write(nums[i]);
            }
        }

        #endregion

        #region 20171224

        //非递归的形式遍历二叉树,后序遍历
        public static void traverseTreeBack(TreeNode root)
        {
            Stack<TreeNode> stack = new Stack<TreeNode>();
            while (root != null || stack.Count() != 0)
            {
                while (root != null)
                {
                    stack.Push(root);
                    root = root.left;
                }
                root = stack.Pop();
                root = root.right;
            }
        }
        //非递归的形式遍历二叉树,中序遍历
        public static void traverseTreeMid(TreeNode root)
        {
            Stack<TreeNode> stack = new Stack<TreeNode>();
            while (root != null || stack.Count() != 0)
            {
                while (root != null)
                {
                    stack.Push(root);
                    root = root.left;
                }
                root = stack.Pop();
                Console.Write(root.val);
                root = root.right;
            }
        }

        //非递归的形式遍历二叉树,前序遍历
        public static void traverseTreePre(TreeNode root)
        {
            Stack<TreeNode> stack = new Stack<TreeNode>();
            while (root != null || stack.Count() != 0)
            {
                while (root != null)
                {
                    Console.Write(root.val);
                    stack.Push(root);
                    root = root.left;
                }
                root = stack.Pop();
                root = root.right;
            }
        }

        //100. Same Tree
        public static bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null) return true;
            if (p == null || q == null) return false;
            if (p.val == q.val)
                return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
            return false;
        }

        //530. Minimum Absolute Difference in BST
        int min = int.MaxValue;
        int prev = -1;
        public int GetMinimumDifference(TreeNode root)
        {
            if (root == null)
                return min;
            //中序遍历
            GetMinimumDifference(root.left);
            if (prev != -1) {
                min = Math.Min(min, root.val - prev);
            }
            prev = root.val;
            GetMinimumDifference(root.right);
            return min;
        }

        //167. Two Sum II - Input array is sorted
        //超时
        public static int[] TwoSum(int[] numbers, int target)
        {
            if (numbers == null)
                return numbers;
            for (int i = 0; i < numbers.Length; i++) {
                if (numbers.Contains(target - numbers[i])) {
                    for (int j = i + 1; j < numbers.Length; j++) {
                        if (numbers[i] + numbers[j] == target)
                            return new int[2] { i+1, j+1 };
                    }
                }
            }
            return numbers;
        }
        public static int[] TwoSum2(int[] numbers, int target)
        {
            if (numbers == null)
                return numbers;
            int len = numbers.Length;
            for (int i = 0; i < len-1; i++)
            {
                int diff = target - numbers[i];
                int begin = i+1;
                int end = len - 1;
                while (begin <= end) {
                    int cur = begin + (end - begin) / 2;
                    if (numbers[cur] < diff)
                    {
                        begin = cur + 1;
                    }
                    else if (numbers[cur] > diff)
                    {
                        end = cur - 1;
                    }
                    else {
                        return new int[2] { i + 1, cur + 1 };
                    }
                }
            }
            return numbers;
        }

        #endregion

        #region 20171223

        //找到第一个非重复字符
        public static int FirstUniqChar(string s)
        {
            if (s == null || s == "")
                return -1;
            int[] nums = new int[26];
            for (int i = 0; i < s.Length; i++) {
                nums[s[i] - 'a']++;
            }
            int res = -1;
            for (int i = 0; i < nums.Length; i++) {
                if (nums[i] == 1)
                {
                    int index = s.IndexOf((char)(i + 'a'));
                    if (res == -1)
                    {
                        res = index;
                    }
                    else {
                        if (index < res)
                            res = index;
                    }
                }
            }
            return res;
        }

        //Find the sum of all left leaves in a given binary tree.
        public static int SumOfLeftLeaves(TreeNode root)
        {
            leftsum = 0;
            getLeftSum(root);
            return leftsum;
        }
        public static int leftsum = 0;
        public static void getLeftSum(TreeNode root)
        {
            if (root == null)
                return;
            if (root.left != null) {
                if (root.left.left == null && root.left.right == null)
                    leftsum += root.left.val;
                getLeftSum(root.left);
            }
            if (root.right != null) {
                getLeftSum(root.right);
            }
        }
        //获得所有最左子树的和
        public static int SumOfLeftLeaves2(TreeNode root)
        {
            if (root == null)
                return 0;
            int res = 0;
            if (root.left != null && root.left.left == null && root.left.right == null)
                res += root.left.val;
            res += SumOfLeftLeaves2(root.left);
            res += SumOfLeftLeaves2(root.right);
            return res;
        }
        public static int SumOfLeftLeaves3(TreeNode root) {
            if (root == null)
                return 0;
            int res = 0;
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);
            while (q.Count() != 0) {
                TreeNode curr = q.Dequeue();

                if (curr.left != null && curr.left.left == null && curr.left.right == null)
                    res += curr.left.val;
                if (curr.left != null)
                    q.Enqueue(curr.left);
                if (curr.right != null)
                    q.Enqueue(curr.right);
            }
            return res;
        }

        //169. Majority Element 查找数量超过n/2的数据
        public static int MajorityElement(int[] nums)
        {
            if (nums.Length == 1)
                return nums[0];
            int temp = nums[0];
            int count = 0;
            foreach (int val in nums) {
                if (count == 0)
                {
                    temp = val;
                }
                if (val == temp)
                    count++;
                else
                    count--;
            }
            return temp;
        }

        //383. Ransom Note
        public static bool CanConstruct(string ransomNote, string magazine)
        {
            if (ransomNote.Length > magazine.Length)
                return false;
            int[] table = new int[26];
            foreach(char c in ransomNote) {
                table[c - 'a']++;
            }
            foreach (char c in magazine) {
                table[c - 'a']--;
            }
            if (table.Max() > 0)
                return false;
            return true;
        }

        //453. Minimum Moves to Equal Array Elements
        public static int MinMoves(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;
            int val = nums.Min();
            int res = 0;
            foreach (int v in nums)
                res += (v - val);
            return res;
        }

        #endregion

        #region 20171222

        //70. Climbing Stairs
        public static int ClimbStairs(int n)
        {
            int[] tc = new int[n];
            if (n <= 3 )
                return n;
            tc[0] = 0;
            tc[1] = 1;
            tc[2] = 2;
            for (int i = 3; i < n; i ++) {
                tc[i] = (tc[i - 1]) + (tc[i - 2]);
            }
            return tc[tc.Length - 1] + tc[tc.Length-2];
        }

        //746. Min Cost Climbing Stairs爬楼梯问题, //递归解法
        public static int MinCostClimbingStairs(int[] cost)
        {
            return recur(0, cost);
        }
        public static int recur(int index,int[] cost) {
            if (index >= cost.Length)
                return 0;
            int val = cost[index];
            return Math.Min(recur(index + 1, cost) + val, recur(index + 2,cost) + val);
        }
        //动态规划解法
        public static int MinCostClimbingStairs2(int[] cost)
        {
            int cost_i_1 = 0;
            int cost_i_2 = 0;

            int len = cost.Length;
            int tc = 0;

            if (len == 1 || len == 0)
                return 0;
            for (int i = 2; i <= len; i++) {
                tc = Math.Min(cost[i - 1] + cost_i_1, cost[i - 2] + cost_i_2);
                cost_i_2 = cost_i_1;
                cost_i_1 = tc;
            }
            return tc;
        }

        #endregion

        #region 20171221


        //492. Construct the Rectangle
        public static int[] ConstructRectangle(int area)
        {
            int l = area;
            int w = 1;
            while (w < l) {
                w++;
                if (area % w == 0) {
                    l = area / w;
                }
            }
            int[] res = { w,l };
            return res;
        }

        //538. Convert BST to Greater Tree 从右边开始遍历
        public static TreeNode ConvertBST(TreeNode root)
        {
            recursionBST(root);
            return root;
        }
        public static int sum = 0;
        public static void recursionBST (TreeNode root)
        {
            if (root == null) {
                return;
            }
            recursionBST(root.right);
            sum += root.val;
            root.val = sum;
            recursionBST(root.left);
        }

        //538. Convert BST to Greater Tree 迭代求法
        public static TreeNode ConvertBST2(TreeNode root)
        {
            if (root == null)
                return root;
            int sum = 0;
            Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode t = root;
            while (t != null || stack.Count != 0) {
                 while (t != null) {
                    stack.Push(t);
                    t = t.right;
                }
                t = stack.Pop();
                t.val += sum;
                sum = t.val;
                t = t.left;
            }
            return root;
        }

        #endregion

        #region 20171217

        //748. Shortest Completing Word
        public static string ShortestCompletingWord(string licensePlate, string[] words)
        {
            licensePlate = licensePlate.ToLower();
            int[] sTable = new int[26];
            foreach (char c in licensePlate) {
                if (c >= 'a' && c <= 'z')
                    sTable[c - 'a']++;
            }
            string res = null;
            foreach (string str in words) {
                if (compareSring(sTable, str)) {
                    if (res == null)
                        res = str;
                    else if (res.Length > str.Length)
                        res = str;
                }
            }
            return res;
        }
        public static bool compareSring(int[] sTable,string s2) {
            int[] temp = new int[26];
            foreach (char c in s2) {
                temp[c - 'a']++;
            }
            for (int i = 0; i < 26; i++) {
                if (sTable[i] != 0 && sTable[i] > temp[i]) return false;
            }
            return true;
        }

        #endregion

        #region 20171216

        //171. Excel Sheet Column Number
        public static int TitleToNumber(string s)
        {
            if (s == null)
                return 0;
            int sum = 0;
            int index = 0;
            for (int i = s.Length - 1; i >= 0; i--) {
                sum += (s[i] - 'A' + 1) * (int)Math.Pow(26, index);
                index++;
            }
            return sum;
        }

        // 查找最大岛屿
        public static int MaxAreaOfIsland2(int[,] grid)
        {
            int max = 0;
            for (int i = 0; i < grid.GetLength(0); i++) {
                for (int j = 0; j < grid.GetLength(1); j++) {
                    if (grid[i,j] == 1)
                        max = Math.Max(max, areaOfIsland2(grid, i, j));
                }
            }
            return max;
        }
        public static int areaOfIsland2(int[,] grid, int x, int y) {
            if (x >= 0 && x < grid.GetLength(0) && y >= 0 && y < grid.GetLength(1)
                && grid[x, y] == 1) {
                grid[x, y] = 0;
                return 1 + areaOfIsland2(grid, x + 1, y)
                    + areaOfIsland2(grid, x - 1, y)
                    + areaOfIsland2(grid, x, y + 1)
                    + areaOfIsland2(grid, x, y - 1);
            }
            return 0;
        }

        // 查找最大岛屿
        public static int MaxAreaOfIsland(int[,] grid)
        {
            if (grid == null)
                return 0;
            List<int> len = new List<int>();
            for (int i = 0; i < grid.GetLength(0); i++) {
                for (int j = 0; j < grid.GetLength(1); j++) {
                    if (grid[i, j] == 1) {
                        len.Add(0);
                        search0(grid, i, j, len);
                    }
                }
            }
            len.Sort();
            if (len.Count == 0) {
                return 0;
            }
            return len[len.Count-1];
        }
        public static void search0(int[,] grid,int x,int y,List<int> len) {
            if (grid[x, y] == 0) {
                return;
            }
            grid[x, y] = 0;
            len[len.Count-1]++;
            if (x + 1 < grid.GetLength(0)) {
                search0(grid, x + 1, y, len);
            }
            if (x - 1 >= 0) {
                search0(grid, x - 1, y, len);
            }
            if (y + 1 < grid.GetLength(1)) {
                search0(grid, x, y + 1, len);
            }
            if (y - 1 >= 0) {
                search0(grid, x, y - 1, len);
            }
        }

        #endregion

        #region 20171215

        /// <summary>
        /// 606. Construct String from Binary Tree
        /// </summary>
        public static string Tree2str(TreeNode t)
        {
            if (t == null) return "";
            string res = t.val + "";
            string left = Tree2str(t.left);
            string right = Tree2str(t.right);

            if (left == "" && right == "") return res;
            if (left == "") return res + "()" + "(" + right + ")";
            if (right == "") return res + "(" + left + ")";
            return res + "(" + left + ")" + "(" + right + ")";
        }

        //Given a Binary Search Tree and a target number, return true if there exist two elements in the BST such that their sum is equal to the given target.
        public static bool FindTarget(TreeNode root, int k)
        {
            HashSet<int> set = new HashSet<int>();
            return FindTarget(root, k, set);
        }
        public static bool FindTarget(TreeNode root, int k, HashSet<int> set) {
            if (root == null)
                return false;
            if (set.Contains(k - root.val))
                return true;
            set.Add(root.val);
            return FindTarget(root.left, k, set) || FindTarget(root.right, k, set);
        }

        public static bool FindTarget2(TreeNode root,int k) {
            List<int> nums = new List<int>();
            inorder(root, nums);
            for (int i = 0, j = nums.Count - 1; i < j;) {
                if (nums[i] + nums[j] == k) return true;
                if(nums[i] + nums[j] < k) i++;
                else j--;
            }
            return false;
        }
        public static void inorder(TreeNode node,List<int> nums) {
            if (node == null) return;
            inorder(node.left, nums);
            nums.Add(node.val);
            inorder(node.right, nums);
        }

        //Given an array nums, write a function to move all 0's to the end of it while maintaining the relative order of the non-zero elements.
        //For example, given nums = [0, 1, 0, 3, 12], after calling your function, nums should be[1, 3, 12, 0, 0].
        public static void MoveZeroes(int[] nums)
        {
            if (nums == null)
                return;
            int poi1 = 0, poi2 = 0;
            for (int i = 0; i < nums.Length; i++) {
                if (nums[i] != 0)
                {
                    if (poi1 != poi2) {
                        nums[poi1] = nums[i];
                        nums[i] = 0;
                    }
                    poi1++;
                }
                poi2++;
            }
        }
        public static void MoveZeroes2(int[] nums)
        {
            int index = 0;
            foreach (int i in nums) {
                if (i != 0) {
                    nums[index++] = i;
                }
            }
            while (index < nums.Length) {
                nums[index++] = 0;
            }
        }

        //Given two strings s and t which consist of only lowercase letters.
        //String t is generated by random shuffling string s and then add one more letter at a random position.
        //Find the letter that was added in t.
        public static char FindTheDifference(string s, string t)
        {
            foreach (char c in t) {
                int index = s.IndexOf(c);
                if (index != -1)
                    s = s.Remove(index, 1);
                else return c;
            }
            return '0';
        }
        public static char FindTheDifference2(string s, string t)
        {
            int[] arr = new int[26];
            foreach (char c in s) {
                arr[c - 'a']++;
            }
            foreach (char c in t) {
                arr[c - 'a']--;
                if (arr[c - 'a'] < 0)
                    return c;
            }
            return '0';
        }
        public static char FindTheDifference3(string s, string t)
        {
            int res = 0;
            foreach (var i in s) {
                res ^= i;
            }
            foreach (var i in t) {
                res ^= i;
            }
            return (char)res;
        }

        //getsum
        public static int GetSum(int a, int b)
        {
            int[] nums = { a, b };
            return nums.Sum();
        }

        #endregion

        #region 20171214

        //Given an array of integers where 1 ≤ a[i] ≤ n (n = size of array), some elements appear twice and others appear once.
        //Find all the elements of[1, n] inclusive that do not appear in this array.
        //Could you do it without extra space and in O(n) runtime? You may assume the returned list does not count as extra space.
        public static IList<int> FindDisappearedNumbers(int[] nums)
        {
            IList<int> res = new List<int>();
            if (nums == null || nums.Length == 0)
                return res;
            HashSet<int> set = new HashSet<int>(nums);
            for (int i = 1; i <= nums.Length; i++) {
                if (!set.Contains(i))
                    res.Add(i);
            }
            return res;
        }
        public static IList<int> FindDisappearedNumbers2(int[] nums)
        {
            IList<int> ret = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int val = Math.Abs(nums[i]) - 1;
                if (nums[val] > 0)
                {
                    nums[val] = -nums[val];
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    ret.Add(i + 1);
                }
            }
            return ret;
        }

        public static int CountBinarySubstrings2(string s)
        {
            int res = 0;
            List<int> list = new List<int>();
            char last = s[0];
            int count = 1;
            for (int i = 1; i < s.Length; i++) {
                if (s[i] == s[i - 1]) count++;
                else {
                    list.Add(count);
                    count = 1;
                }
            }
            list.Add(count);
            for (int i = 1; i < list.Count; i++) {
                res += Math.Min(list[i], list[i - 1]);
            }
            return res;
        }

        //Give a string s, count the number of non-empty (contiguous) substrings that have the same number of 0's and 1's, and all the 0's and all the 1's in these substrings are grouped consecutively.
        public static int CountBinarySubstrings(string s)
        {
            if (s == null || s == "")
                return 0;
            int count = 0;
            char[] cs = s.ToCharArray();
            string list = "";
            list += cs[0];
            int temp1 = 1;
            int temp2 = 1;
            for (int i = 1; i < cs.Length; i++) {
                char c = cs[i];
                if (c != list.Last())
                {
                    temp2 = temp1;
                    temp1 = 1;
                    count++;
                    list += c;
                }
                else {
                    temp1++;
                    list += c;
                    if (list.Length >= temp1 * 2 && temp2 >= temp1) {
                        string s1 = list.Substring(list.Length - temp1, temp1);
                        string s2 = list.Substring(list.Length - temp1 - temp1, temp1);
                        if (s1 != s2)
                            count++;
                    }
                }
            }
            return count;
        }

        //USA，usa，Usa
        public static bool DetectCapitalUse(string word)
        {
            if (word == null)
                return false;
            char[] chars = word.ToCharArray();
            int count = 0;
            foreach (char c in chars) {
                if (c >= 'A' && c <= 'Z')
                    count++;
            }
            if (count == 1) {
                if (chars[0] >= 'A' && chars[0] <= 'Z')
                    return true;
            }
            if (count >= 1 && count != word.Length)
                return false;
            return true;
        }

        // 翻转二叉树
        public static TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
                return root;
            TreeNode t = root.left;
            root.left = InvertTree(root.right);
            root.right = InvertTree(t);
            return root;
        }

        //Given a list of sorted characters letters containing only lowercase letters, and given a target letter target, find the smallest element in the list that is larger than the given target.
        public static char NextGreatestLetter(char[] letters, char target)
        {
            if (letters == null || letters.Length == 0)
                return target;
            char res = '0';
            char min = letters[0];
            foreach (char c in letters) {
                if (res == '0')
                {
                    if (c > target)
                        res = c;
                }
                else {
                    if (c < res && c > target)
                        res = c;
                }
            }
            if (res == '0')
                return letters[0];
            return res;
        }

        #endregion

        #region 20171212

        //寻找最大深度
        //Given a binary tree, find its maximum depth.
        //The maximum depth is the number of nodes along the longest path from the root node down to the farthest leaf node.
        public static int MaxDepth(TreeNode root) {
            maxD = 0;
            if (root == null)
                return 0;
            if (root.left == null && root.right == null)
                return 1;
            recursion(root, 1);
            return maxD;
        }
        public static int maxD = 0;
        public static void recursion(TreeNode root, int count)
        {
            if (root.left == null && root.right == null)
            {
                if (maxD < count)
                    maxD = count;
                return;
            }
            if (root.left != null)
            {
                count++;
                recursion(root.left, count);
                count--;
            }
            if (root.right != null)
            {
                count++;
                recursion(root.right, count);
                count--;
            }
        }

        //Given a positive integer, check whether it has alternating bits: namely, if two adjacent bits will always have different values.
        public static bool HasAlternatingBits(int n)
            {
                int t = n & 1;//取得最后一位(t == 0->last = 1)
                n = n >> 1;
                while (n != 0) {
                    int tt = n & 1;
                    if (t == (n & tt))
                        return false;
                    t = tt;
                    n = n >> 1;
                }
                return true;
            }

        #endregion

        #region 20171210

        //Given an array of integers, every element appears twice except for one. Find that single one.
        //超时解
        public static int SingleNumber2(int[] nums)
        {
            if (nums.Length == 0)
                return nums[0];
            for (int i = 0; i < nums.Length; i++) {
                bool f = false;
                for (int j = 0; j < nums.Length; j++) {
                    if (nums[i] == nums[j] && i != j) {
                        f = true;
                        break;
                    }
                }
                if (!f)
                    return nums[i];
            }
            return 0;
        }
        //两个相同的数进行^（异或操作结果为0）
        public static int SingleNumber3(int[] nums)
        {
            if (nums.Length == 1)
                return nums[0];
            int res = nums[0];
            for (int i = 1; i < nums.Length; i++) {
                res ^= nums[i];
            }
            return res;
        }
        //利用其他数据结构HashSet
        public static int SingleNumber4(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();
            foreach (int v in nums) {
                if (set.Contains(v))
                    set.Remove(v);
                else
                    set.Add(v);
            }
            return set.First();
        }

        //292. Nim Game
        public static bool CanWinNim(int n)
        {
            return n % 4 != 0;
        }

        #endregion

        #region 20171209

        //Given two non-negative integers num1 and num2 represented as string, return the sum of num1 and num2.
        public static string AddStrings(string num1, string num2)
        {
            StringBuilder sb = new StringBuilder();
            int carry = 0;
            for (int i = num1.Length - 1, j = num2.Length - 1; carry == 1|| i >= 0 || j >= 0; i--, j--)
            {
                int x = i < 0 ? 0 : num1[i] - '0';
                int y = j < 0 ? 0 : num2[j] - '0';
                sb.Append((x + y + carry) % 10);
                carry = (x + y + carry) / 10;
            }
            char[] res = sb.ToString().ToCharArray();
            Array.Reverse(res);
            return new string(res);
        }

        //计算一个数各位相加知道和<10
        public static int AddDigits(int num)
        {
            if (num < 10)
                return num;
            int sum = 0;
            while (num >= 10) {
                sum += num % 10;
                num = num / 10;
                if (num < 10)
                {
                    num += sum;
                    sum = 0;
                }
            }
            return num;
        }

        //Given two binary strings, return their sum (also a binary string).
        //For example,
        //a = "11"
        //b = "1"
        //Return "100".
        public static string AddBinary(string a, string b)
        {
            double a_10 = 0,b_10 = 0;
            int indexa = 0;
            for (int i = a.Length-1; i >= 0; i--) {
                int v = a[i] == '1' ? 1 : 0;
                a_10 +=  v * (Math.Pow(2, indexa++));
            }
            double indexb = 0;
            for (int i = b.Length - 1; i >= 0; i--)
            {
                int v = b[i] == '1' ? 1 : 0;
                b_10 += v * (Math.Pow(2, indexb++));
            }
            StringBuilder sb = new StringBuilder();
            double res = a_10 + b_10;
            int ni = 0;
            while (res != 0)
            {
                ni = (int)res % 2;
                sb.Append(ni);
                res = res / 2;
            }
            Console.WriteLine(sb.Length);
            return sb.ToString();
        }

        //***
        //We have two special characters. The first character can be represented by one bit 0. The second character can be represented by two bits (10 or 11).
        public static bool IsOneBitCharacter(int[] bits)
        {
            int n = bits.Length;
            int i = 0;
            while (i < n - 1)
            {
                if (bits[i] == 0) i++;
                else i += 2;
            }
            return i == n - 1 ? true : false;
        }

        #endregion

        #region 20171208

        //将数组中的0移动到数组末尾,解法1最直观，效率不好
        public static int[] moveZero0(int[] arr) {
            int k = arr.Length;
            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] == 0) {
                    int j = k - 1;
                    while (j > i) {
                        if (arr[j] != 0)
                        {
                            arr[i] = arr[j];
                            arr[j] = 0;
                            k--;
                            break;
                        }
                        else {
                            k--;
                            j--;
                        }
                    }
                }
            }
            return arr;
        }

        public static int[] moveZero1(int[] arr)
        {
            int zero = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    zero++;
                }
                else {
                    arr[i - zero] = arr[i];
                }
            }
            for (int i = arr.Length - 1; i > arr.Length - 1 - zero; i--) {
                arr[i] = 0;
            }
            return arr;
        }

        public static int[] moveZero2(int[] arr)
        {
            int m = 0,n = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    n++;
                }
                else
                {
                    if (m != n) {
                        arr[m] = arr[n];
                        arr[n] = 0;
                    }
                    m++;
                    n++;
                }
            }
            return arr;
        }

        #endregion

        #region 20171207

        //521. Longest Uncommon Subsequence I
        public static int FindLUSlength(string a, string b)
        {
            if (a == b)
                return - 1;
            if (a.Contains(b))
                return a.Length;
            if (b.Contains(a))
                return b.Length;
            return a.Length > b.Length ? a.Length : b.Length;
        }

        //Given an integer, write a function to determine if it is a power of three.
        public static bool IsPowerOfThree(int n)
        {
            //return (n > 0 && 1162261467 % n == 0);
            if (n < 1) return false;
            while (n % 3 == 0)
            {
                n /= 3;
            }
            return n == 1;
        }

        //***
        //Given an array of integers and an integer k, find out whether there are two distinct indices i and j in the array such that nums[i] = nums[j] and the absolute difference between i and j is at most k.
        public static bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            if (nums == null || nums.Length < 1) return false;
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int cur = nums[i];
                if (map.ContainsKey(cur))
                {
                    int j = map[cur];
                    if (i - j <= k)
                        return true;
                }
                map.Remove(cur);
                map.Add(cur, i);
            }
            return false;
        }

        //Given an array of integers, find if the array contains any duplicates. Your function should return true if any value appears at least twice in the array, and it should return false if every element is distinct.
        public static bool ContainsDuplicate(int[] nums)
        {
            if (nums == null)
                return false;
            HashSet<int> set = new HashSet<int>(nums);
            return set.Count == nums.Length ? false : true;
        }

        //***
        //605. Can Place Flowers
        //public static bool CanPlaceFlowers(int[] flowerbed, int n)
        //{
        //    return true;
        //}

        //Say you have an array for which the ith element is the price of a given stock on day i.
        //If you were only permitted to complete at most one transaction(ie, buy one and sell one share of the stock), design an algorithm to find the maximum profit.
        public static int MaxProfit3(int[] prices)
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
