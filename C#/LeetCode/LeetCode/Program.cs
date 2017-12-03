using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //ListNode v1 = new ListNode(1);
            //ListNode v2 = new ListNode(2);
            //ListNode v3 = new ListNode(3);
            //ListNode v4 = new ListNode(4);

            //ListNode l1 = new ListNode(1);//1 1 3
            //l1.next = v1;
            //v1.next = v3;
            //ListNode l2 = new ListNode(2);//2 2 4
            //l2.next = v2;
            //v2.next = v4;

            //ListNode res = MergeTwoLists(l1, l2);

            //Console.WriteLine(1);
            List<int> res = (List<int>)SelfDividingNumbers(9,11);
            foreach (int v in res) {
                Console.WriteLine(v);
            }
        }


        #region easy

        //A self-dividing number is a number that is divisible by every digit it contains.
        //For example, 128 is a self-dividing number because 128 % 1 == 0, 128 % 2 == 0, and 128 % 8 == 0.
        //Also, a self-dividing number is not allowed to contain the digit zero.
        //Given a lower and upper number bound, output a list of every possible self dividing number, including the bounds if possible.
        public static IList<int> SelfDividingNumbers(int left, int right)
        {
            IList<int> res = new List<int>();
            if (left > right)
                return res;
            for (int i = left; i <= right; i++) {
                int t = i % 10;
                int d = i / 10;
                bool f = true;
                do
                {
                    if (t == 0 || i % t != 0)
                    {
                        f = false;
                        break;
                    }
                    t = d % 10;
                    d = d / 10;
                } while (t != 0 || d != 0);
                if (f)
                    res.Add(i);
            }
            return res;
        }
        public static IList<int> SelfDividingNumbers2(int left, int right) {
            IList<int> res = new List<int>();
            for (int i = left; i < right; i++) {
                int j = i;
                for (; j > 0; j /= 0) {
                    if ((j % 10) == 0 || (i % (j % 10) != 0)) {
                        break;
                    }
                }
                if (j == 0)
                    res.Add(i);
            }
            return res;
        }

        //The Hamming distance between two integers is the number of positions at which the corresponding bits are different.
        //Given two integers x and y, calculate the Hamming distance.
        public static int HammingDistance(int x, int y)
        {
            int res = 0, exc = x ^ y;//异或
            for (int i = 0; i < 32; i++) {
                res += (exc >> i) & 1;
            }
            return res;
        }

        //合并链表
        //Merge two sorted linked lists and return it as a new list. The new list should be made by splicing together the nodes of the first two lists.
        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null)
                return l2;
            if (l2 == null)
                return l1;
            ListNode merge = null;
            if (l1.val < l2.val)
            {
                merge = l1;
                merge.next = MergeTwoLists(l1.next, l2);
            }
            else {
                merge = l2;
                merge.next = MergeTwoLists(l1, l2.next);
            }
            return merge;
        }
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        //Given a string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
        //The brackets must close in the correct order, "()" and "()[]{}" are all valid but "(]" and "([)]" are not.
        public static bool IsValid(string s)
        {
            if (s == null || s == "")
                return false;
            Dictionary<char, char> dic = new Dictionary<char, char>();
            dic.Add('(', ')');
            dic.Add('{', '}');
            dic.Add('[', ']');
            Stack<char> stack = new Stack<char>();
            stack.Push(s[0]);
            for (int i = 1; i < s.Length; i ++) {
                if (stack.Count == 0)
                {
                    stack.Push(s[i]);
                }
                else{
                    if (dic.ContainsKey(stack.Peek()) && s[i] == dic[stack.Peek()])
                    {
                        stack.Pop();
                    }
                    else
                    {
                        stack.Push(s[i]);
                    }
                }
            }
            if (stack.Count == 0) {
                return true;
            }
            return false;
        }
        public static bool IsValid2(string s) {
            Stack<char> stack = new Stack<char>();
            foreach(char c in s.ToCharArray()) {
                if (c == '(')
                    stack.Push(')');
                else if (c == '{')
                    stack.Push('}');
                else if (c == '[')
                    stack.Push(']');
                else if (stack.Count == 0 || stack.Pop() != c)
                    return false;
            }
            if (stack.Count == 0)
                return true;
            return false;
        }

        //Write a function to find the longest common prefix string amongst an array of strings.
        //最长公共前缀
        //假设第一个字符串是公共最长前缀，第二个和第二个比较，从第0个字符开始比较，取出相同的字符返回
        //依次比较
        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length <= 0) {
                return "";
            }
            string res = strs[0];
            for (int i = 1; i < strs.Length; i++)
            {
                if (res.Length < 0)
                    break;
                res = getleast(res, strs[i]);
            }
            return res;
        }
        public static string getleast(string res, string target)
        {
            StringBuilder sb = new StringBuilder();
            int loop = res.Length > target.Length ? target.Length : res.Length;
            for (int i = 0; i < loop; i++) {
                if (res[i] == target[i])
                    sb.Append(res[i]);
                else break;
            }
            return sb.ToString();
        }

        //Given a roman numeral, convert it to an integer.
        //Input is guaranteed to be within the range from 1 to 3999.
        public static int RomanToInt(string s)
        {
            //单字符
            int[] v1 = new int[] { 1000, 500, 100, 50, 10, 5, 1 };
            String[] k1 = new String[] { "M", "D", "C", "L", "X", "V", "I" };

            //双字符数组  
            int[] v2 = new int[] { 900, 400, 90, 40, 9, 4 };
            String[] k2 = new String[] { "CM", "CD", "XC", "XL", "IX", "IV" };

            int res = 0;

            bool v2f = false;//判断双字符有没有匹配成功
            while (s.Length > 0) {
                if (s.Length > 1) {
                    string str1 = s.Substring(0, 2);
                    for (int i = 0; i < k2.Length; i++)
                    {
                        if (str1 == k2[i])
                        {
                            res += v2[i];
                            s = s.Substring(2);
                            v2f = true;
                            break;
                        }
                    }
                }
                if (!v2f) {
                    string str2 = s.Substring(0, 1);
                    for (int i = 0; i < k1.Length; i++)
                    {
                        if (str2 == k1[i])
                        {
                            res += v1[i];
                            s = s.Substring(1);
                            break;
                        }
                    }
                }
                v2f = false;
            }
            return res;
        }

        /// <summary>
        /// Determine whether an integer is a palindrome. Do this without extra space.
        /// 回文
        /// </summary>
        public static bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;
            int res = 0;
            int temp = x;
            while (temp != 0) {
                int last = temp % 10;
                int newRes = res * 10 + last;
                if ((newRes - last) / 10 != res)
                    return false;
                res = newRes;
                temp /= 10;
            }
            if (res == x)
                return true;
            return false;
        }

        /// <summary>
        /// 54321 - > 12345
        /// </summary>
        public static int Reverse(int x)
        {
            int res = 0;
            while (x != 0)
            {
                int last = x % 10;
                int newRes = res * 10 + last;
                //验证数据
                if ((newRes - last) / 10 != res)
                    return 0;
                res = newRes;
                x = x / 10;
            }
            return res;
        }

        //Given an array of integers, return indices of the two numbers such that they add up to a specific target.
        //You may assume that each input would have exactly one solution, and you may not use the same element twice.
        public static int[] TwoSum(int[] nums, int target)
        {
            if (nums == null)
                return nums;
            int[] res = new int[2];
            for (int i = 0; i < nums.Length; i++) {
                for (int j = i + 1; j < nums.Length; j++) {
                    if(nums[i] + nums[j] == target)
                    {
                        res[0] = i;
                        res[1] = j;
                    }
                }
            }
            return res;
        }
        #endregion

    }
}
