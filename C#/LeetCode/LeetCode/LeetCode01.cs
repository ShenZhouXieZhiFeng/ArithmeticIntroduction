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

            //            Console.Write(AddBinary("10100000100100110110010000010101111011011001101110111111111101000000101111001110001111100001101",
            //"110101001011101110001111100110001010100001101011101010000011011011001011101111001100000011011110011"));

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

            int[] res = ConstructRectangle(6);

            Console.ReadLine();
        }

        #region Medium

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
        public static int SingleNumber(int[] nums)
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
        public static int SingleNumber2(int[] nums)
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
        public static int SingleNumber3(int[] nums)
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
        public static bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            return true;
        }

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
