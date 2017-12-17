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

        static void Main(string[] args)
        {
            //Console.Write(checkStr01("awqs f"));
            //Console.Write(reverseStr("12345"));
            //Console.Write(checkStr02("qwer", "rewq"));
            Console.Write(changeStr_ans01("aaabbbcc"));

            Console.ReadLine();
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
        //使用位运算解题
        //public static bool checkStr01_an02(string str) {

        //}

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

    }
}
