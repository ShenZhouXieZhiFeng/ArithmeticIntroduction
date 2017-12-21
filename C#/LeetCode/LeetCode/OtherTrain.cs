using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /// <summary>
    /// 面试金典练习
    /// </summary>
    class OtherTrain
    {

        //static void Main(string[] args)
        //{
        //    //Console.Write(checkStr01("awqs f"));
        //    //Console.Write(reverseStr("12345"));
        //    //Console.Write(checkStr02("qwer", "rewq"));
        //    //Console.Write(changeStr_ans01("aaabbbcc"));
        //    ListNode h1 = new ListNode(4);
        //    ListNode h2 = new ListNode(5);
        //    ListNode h3 = new ListNode(2);
        //    ListNode h4 = new ListNode(1);
        //    h1.next = h2;
        //    h2.next = h3;
        //    h3.next = h4;
        //    ////removeRepetion(h1);
        //    //Console.Write(findLastIndexVal2(h1, 2));
        //    h1 = divisionListNode(h1, 3);

        //    Console.ReadLine();
        //}

        //以val为基准将链表分割成两部分，所有小于x的节点排在大于或等于x的节点之前
        public static ListNode divisionListNode(ListNode head,int val) {
            ListNode beforeStart = null;
            ListNode beforeEnd = null;
            ListNode afterStart = null;
            ListNode afterEnd = null;

            while (head != null) {
                ListNode next = head.next;
                head.next = null;
                if (head.val < val)
                {
                    if (beforeStart == null)
                    {
                        beforeStart = head;
                        beforeEnd = head;
                    }
                    else
                    {
                        beforeEnd.next = head;
                        beforeEnd = head;
                    }
                }
                else {
                    if (afterStart == null)
                    {
                        afterStart = head;
                        afterEnd = afterStart;
                    }
                    else {
                        afterEnd.next = head;
                        afterEnd = head;
                    }
                }
                head = next;
            }
            if (beforeStart != null)
            {
                beforeEnd.next = afterStart;
                return beforeStart;
            }
            return head;
        }

        // 检查一个字符串的所有字符是否全部都不同
        public static bool checkStr01(string str) {
            while(str.Length > 1) { 
                char c = str[0];
                str = str.Remove(0, 1);
                if (str.Contains(c))
                    return false;
            }
            return true;
        }
        //使用散列表解题
        public static bool checkStr01_an01(string str) {
            if (str.Length > 256) return false;
            bool[] cTab = new bool[256];
            for (int i = 0; i < str.Length; i++) {
                int val = str[i];//直接转ascii码
                if (cTab[val])
                    return false;
                cTab[val] = true;
            }
            return true;
        }

        // 翻转一个字符串
        public static string reverseStr(string str) {
            char[] chs = str.ToCharArray();
            int len = chs.Length;
            for (int i = 0; i < len / 2 ; i++) {
                char temp = chs[i];
                chs[i] = chs[len -1 - i];//
                chs[len -1 - i] = temp;
            }
            return new string(chs);
        }

        //判断str1重新排列后能否组成str2
        public static bool checkStr02(string str1,string str2) {
            if (str1.Length != str2.Length)
                return false;
            List<char> chs = new List<char>(str1);
            foreach (char c in str2) {
                if (chs.Contains(c))
                    chs.Remove(c);
                else return false;
            }
            return true;
        }

        //使用数组将一个字符串中的空格替换乘%20,字符串空间足够存放替换后的新字符串
        public static string changeEmp(string str) {
            char[] chs = new char[str.Length];
            int index = 0;
            foreach(char c in str) {
                if (c == ' ')
                {
                    chs[index++] = '%';
                    chs[index++] = '2';
                    chs[index++] = '0';
                }
                else {
                    chs[index++] = c;
                }
            }
            return new string(chs);
        }

        //压缩重复的字符串,如aaabbb->a3b3
        public static string changeStr(string str) {
            char[] chs = new char[str.Length];
            int index = 0;
            for (int i = 0; i < str.Length; i++) {
                int len = 1;
                chs[index++] = str[i];
                while (i < str.Length-1 && str[i] == str[i+1]) {
                    len++;
                    i++;
                }
                chs[index++] = len.ToString()[0];
            }
            if (index == 0)
                return str;
            string res = new string(chs);
            return res.Trim();
        }
        public static string changeStr_ans01(string str) {
            string mstr = "";
            char last = str[0];
            int count = 1;
            for (int i = 0; i < str.Length; i++) {
                if (str[i] == last)
                {
                    count++;
                }
                else {
                    mstr += last + "" + count;
                    last = str[i];
                    count = 1;
                }
            }
            return mstr + last + count;
        }

        // 去除链表中的重复元素
        public static void removeRepetion(ListNode head) {
            HashSet<int> set = new HashSet<int>();

            ListNode t1 = head;
            ListNode t2 = head.next;
            set.Add(t1.val);
            while (t2 != null) {
                if (set.Contains(t2.val))
                {
                    t1.next = t2.next;
                    t1 = t1.next;
                    if (t1 != null)
                        t2 = t1.next;
                    else
                        t2 = null;
                }
                else {
                    set.Add(t2.val);
                    t1 = t1.next;
                    t2 = t2.next;
                }
            }
        }
        //更简单的方式
        public static void removeRepetion2(ListNode head)
        {
            HashSet<int> set = new HashSet<int>();
            ListNode temp = head;
            ListNode t = null;
            while (temp != null) {
                if (set.Contains(temp.val))
                {
                    t.next = temp.next;
                }
                else {
                    set.Add(temp.val);
                    t = temp;
                }
                temp = temp.next;
            }
        }
        //不使用缓冲区
        public static void removeRepetion3(ListNode head) {
            ListNode t1 = head;
            while (t1 != null) {
                ListNode t2 = t1;
                while (t2.next != null) {
                    if (t2.next.val == t1.val)
                    {
                        t2.next = t2.next.next;
                    }
                    else {
                        t2 = t2.next;
                    }
                }
            }
        }

        //找出链表倒数第k个节点
        //递归方式
        public static int findLastIndexVal(ListNode n,int k) {
            if (n == null)
                return 0;
            int sum = findLastIndexVal(n.next, k) + 1;
            if (sum == k) {
                Console.Write(n.val);
            }
            return sum;
        }
        //迭代
        public static int findLastIndexVal2(ListNode n, int k) {
            ListNode t1 = n;
            ListNode t2 = n;
            int count = 0;
            while (t2 != null) {
                if (count >= k) {
                    t1 = t1.next;
                }
                //让t2先走k步
                t2 = t2.next;
                count++;
            }
            return t1.val;
        }


    }
}
